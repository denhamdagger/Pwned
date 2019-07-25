using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Check_Pwned
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddPasswordAPIDescription();
        }

        private void GetHash_Click(object sender, EventArgs e)
        {
            lbresults.Items.Clear();

            try
            {
                GetHash.Enabled = false;

                GenerateShaHash(SHA1.Create());
                GenerateShaHash(SHA256.Create());
                GenerateShaHash(SHA384.Create());
                GenerateShaHash(SHA512.Create());
                GenerateShaHash(MD5.Create());
                GenerateBCryptHash();
            }
            finally
            {
                GetHash.Enabled = true;
            }
        }

        private void GenerateShaHash(HashAlgorithm _sha)
        {
            string _hash = GenerateHash(_sha, txtPassword.Text);
            FetchResults(_hash, _sha.GetType().Name);
        }

        private void GenerateBCryptHash()
        {
            string _hash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
            FetchResults(_hash.ToUpper(), "BCrypt");
        }

        private void FetchResults(string Hash, string HashType)
        {
            Application.DoEvents();

            txtAlgorithm.Text = HashType;
            txtPassWordHash.Text = Hash;

            Thread.Sleep(500);
            List<string> _matches = GetPwnedData(txtPassWordHash.Text.Substring(0, 5)).FindAll(c => c.Contains(txtPassWordHash.Text));

            foreach (var _match in _matches)
                lbresults.Items.Add($"{HashType.Replace("CryptoServiceProvider","")} - {_match}");
        }

        private static string GenerateHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            return sBuilder.ToString().ToUpper();
        }

        private static List<string> GetPwnedData(string Hash)
        {
            List<string> _res = new List<string>();

            HttpClient client = new HttpClient();
            Uri _url = new Uri($"https://api.pwnedpasswords.com/range/{Hash}");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

            HttpResponseMessage resp = client.GetAsync(_url).Result;
            string _data = "";

            if (resp.IsSuccessStatusCode)
            {
                _data = resp.Content.ReadAsStringAsync().Result;
            }

            foreach (var _item in _data.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
                _res.Add($"{Hash}{_item}");

            return _res;
        }

        private static List<Breach> GetBreachesCompanies()
        {
            List<Breach> _res = new List<Breach>();

            HttpClient client = new HttpClient();
            Uri _url = new Uri($"https://haveibeenpwned.com/api/v2/breaches");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage resp = client.GetAsync(_url).Result;

            if (resp.IsSuccessStatusCode)
            {
                _res = JsonConvert.DeserializeObject<List<Breach>>(resp.Content.ReadAsStringAsync().Result);
            }
            
            return _res;
        }

        private void btnGetBreaches_Click(object sender, EventArgs e)
        {
            try
            {
                btnGetBreaches.Enabled = false;

                List<Breach> _data = GetBreachesCompanies();
                txtTotalBreaches.Text = "0";

                dgvBreach.Rows.Clear();

                txtTotalBreaches.Text = _data.Count.ToString();

                foreach (var _breach in _data.OrderByDescending(c => c.BreachDate))
                {
                    string _salted = "";
                    string _hash = GetVulnerabilityType(_breach.Description.ToUpper());

                    if (_breach.Description.ToUpper().Contains(" SALT"))
                        _salted = "True";

                    if (_breach.Description.ToUpper().Contains(" UNSALT"))
                        _salted = "False";

                    dgvBreach.Rows.Add(_breach.Name, _breach.Domain, _breach.BreachDate, _breach.PwnCount.ToString(),
                        _breach.IsVerified.ToString(), _salted, _hash, _breach.DataClasses.OrderBy(c => c).Aggregate((c, n) => $"{c}, {n}"));

                    dgvBreach.Rows[dgvBreach.Rows.Count - 1].Cells["colName"].ToolTipText = _breach.Description;

                }

                cboHashType.Items.Clear();

                List<string> _filters = dgvBreach.Rows.Cast<DataGridViewRow>()
                           .Where(x => string.IsNullOrEmpty(x.Cells["colVulnerability"].Value.ToString()) != true)
                           .Select(x => x.Cells["colVulnerability"].Value.ToString())
                           .Distinct()
                           .ToList();
                _filters.Add("__ALL__");
                _filters.Add("__NULL__");

                foreach (string aa in _filters.OrderBy(c => c))
                    cboHashType.Items.Add(aa);

                cboHashType.SelectedIndex = 0;
            }
            finally
            {
                btnGetBreaches.Enabled = true;
            }
        }

        private string GetVulnerabilityType(string Data)
        {
            string _hash = "";

            // Databases
            if (Data.Contains(" DATABASE "))
                _hash = "<database>";

            if (Data.Contains(" MYSQL "))
                _hash = "MYSQL";

            if (Data.Contains(" MONGODB ") || Data.Contains(" MONGO DB ") || Data.Contains(" MONGO-DB "))
                _hash = "MONGODB";

            // Non-disclosed Algorithm
            if (Data.Contains("ALGORITHM"))
                _hash = "<algorithm>";

            if (Data.Contains("HASH"))
                _hash = "<hash>";

            if (Data.Contains(" SALTED "))
                _hash = "<salted hash>";

            // Disclosed Algorithm
            if (Data.Contains("SHA-1") || Data.Contains("SHA1"))
                _hash = "SHA-1";
            else if (Data.Contains("SHA-256") || Data.Contains("SHA256"))
                _hash = "SHA-256";
            else if (Data.Contains("SHA-384") || Data.Contains("SHA384"))
                _hash = "SHA-384";
            else if (Data.Contains("SHA-512") || Data.Contains("SHA512"))
                _hash = "SHA-512";
            else if (Data.Contains("MD5"))
                _hash = "MD5";
            else if (Data.Contains("BCRYPT"))
                _hash = "BCRYPT";
            else if (Data.Contains("PHPASS"))
                _hash = "PHPASS";
            else if (Data.Contains("PBKDF2"))
                _hash = "PBKDF2";
            else if (Data.Contains("DESCRYPT"))
                _hash = "DESCRYPT";
            else if (Data.Contains("PLAIN TEXT PASSWORD"))
                _hash = "Plain text";
            else if (Data.Contains("PLAIN TEXT"))
                _hash = "Plain text";

            return _hash;
        }

        private void dgvBreach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvBreach.Columns["colName"].Index && e.RowIndex >= 0)
                MessageBox.Show(dgvBreach.Rows[e.RowIndex].Cells["colName"].ToolTipText, dgvBreach.Rows[e.RowIndex].Cells["colName"].Value.ToString());
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            var _cb = (CheckBox)sender;

            if (_cb.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void AddPasswordAPIDescription()
        {
            txtPasswordDesc.Text = $"When you press Scan it generates a hash for all the common hashing algorithms and sends the first 5 chars to: {Environment.NewLine}";
            txtPasswordDesc.Text += $"https://api.pwnedpasswords.com/range/nnnnn {Environment.NewLine}{Environment.NewLine}";
            txtPasswordDesc.Text += $"The API will return all hash codes that match the first 5 characters. {Environment.NewLine}";
            txtPasswordDesc.Text += $"We then compare the results with the complete hash code and check for a match.{Environment.NewLine}{Environment.NewLine}";
            txtPasswordDesc.Text += $"The output format is: {Environment.NewLine}";
            txtPasswordDesc.Text += $"<Algorithm> - <Hash>:<Number of Hits> {Environment.NewLine}";
        }

        private void cboHashType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _filter = ((ComboBox)sender).SelectedItem.ToString();

            foreach (DataGridViewRow _row in dgvBreach.Rows)
            {
                if (_filter == "__ALL__")
                    _row.Visible = true;
                else if (_filter == "__NULL__" && string.IsNullOrEmpty(_row.Cells["colVulnerability"].Value.ToString()))
                    _row.Visible = true;
                else if (_row.Cells["colVulnerability"].Value.ToString() == _filter)
                    _row.Visible = true;
                else
                    _row.Visible = false;
            }
        }
    }
}

