namespace Check_Pwned
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHashType = new System.Windows.Forms.ComboBox();
            this.txtTotalBreaches = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBreach = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBreachDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPwnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsVerified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVulnerability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataClasses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetBreaches = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPasswordDesc = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlgorithm = new System.Windows.Forms.TextBox();
            this.lbresults = new System.Windows.Forms.ListBox();
            this.txtPassWordHash = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetHash = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreach)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1323, 615);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboHashType);
            this.tabPage1.Controls.Add(this.txtTotalBreaches);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvBreach);
            this.tabPage1.Controls.Add(this.btnGetBreaches);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1315, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List all Breaches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filter by Vulnerability Column:";
            // 
            // cboHashType
            // 
            this.cboHashType.BackColor = System.Drawing.SystemColors.Control;
            this.cboHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHashType.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHashType.FormattingEnabled = true;
            this.cboHashType.Location = new System.Drawing.Point(633, 26);
            this.cboHashType.Name = "cboHashType";
            this.cboHashType.Size = new System.Drawing.Size(146, 24);
            this.cboHashType.TabIndex = 16;
            this.cboHashType.SelectedIndexChanged += new System.EventHandler(this.cboHashType_SelectedIndexChanged);
            // 
            // txtTotalBreaches
            // 
            this.txtTotalBreaches.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBreaches.Location = new System.Drawing.Point(296, 26);
            this.txtTotalBreaches.Name = "txtTotalBreaches";
            this.txtTotalBreaches.ReadOnly = true;
            this.txtTotalBreaches.Size = new System.Drawing.Size(40, 24);
            this.txtTotalBreaches.TabIndex = 15;
            this.txtTotalBreaches.Text = "0";
            this.txtTotalBreaches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Breaches:";
            // 
            // dgvBreach
            // 
            this.dgvBreach.AllowUserToAddRows = false;
            this.dgvBreach.AllowUserToDeleteRows = false;
            this.dgvBreach.AllowUserToResizeRows = false;
            this.dgvBreach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBreach.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvBreach.CausesValidation = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBreach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBreach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDomain,
            this.colBreachDate,
            this.colPwnCount,
            this.colIsVerified,
            this.colSalted,
            this.colVulnerability,
            this.colDataClasses});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBreach.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvBreach.EnableHeadersVisualStyles = false;
            this.dgvBreach.Location = new System.Drawing.Point(16, 106);
            this.dgvBreach.MultiSelect = false;
            this.dgvBreach.Name = "dgvBreach";
            this.dgvBreach.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBreach.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvBreach.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Info;
            this.dgvBreach.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvBreach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBreach.ShowCellErrors = false;
            this.dgvBreach.ShowCellToolTips = false;
            this.dgvBreach.ShowEditingIcon = false;
            this.dgvBreach.ShowRowErrors = false;
            this.dgvBreach.Size = new System.Drawing.Size(1277, 466);
            this.dgvBreach.TabIndex = 13;
            this.dgvBreach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBreach_CellClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 160;
            // 
            // colDomain
            // 
            this.colDomain.HeaderText = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.ReadOnly = true;
            this.colDomain.Width = 160;
            // 
            // colBreachDate
            // 
            dataGridViewCellStyle11.Format = "D";
            dataGridViewCellStyle11.NullValue = null;
            this.colBreachDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.colBreachDate.HeaderText = "Breach Date";
            this.colBreachDate.Name = "colBreachDate";
            this.colBreachDate.ReadOnly = true;
            this.colBreachDate.Width = 80;
            // 
            // colPwnCount
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            this.colPwnCount.DefaultCellStyle = dataGridViewCellStyle12;
            this.colPwnCount.HeaderText = "Pwn Count";
            this.colPwnCount.Name = "colPwnCount";
            this.colPwnCount.ReadOnly = true;
            this.colPwnCount.Width = 70;
            // 
            // colIsVerified
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colIsVerified.DefaultCellStyle = dataGridViewCellStyle13;
            this.colIsVerified.HeaderText = "Is Verified";
            this.colIsVerified.Name = "colIsVerified";
            this.colIsVerified.ReadOnly = true;
            this.colIsVerified.Width = 70;
            // 
            // colSalted
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSalted.DefaultCellStyle = dataGridViewCellStyle14;
            this.colSalted.HeaderText = "Salted";
            this.colSalted.Name = "colSalted";
            this.colSalted.ReadOnly = true;
            this.colSalted.Width = 50;
            // 
            // colVulnerability
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colVulnerability.DefaultCellStyle = dataGridViewCellStyle15;
            this.colVulnerability.HeaderText = "Vulnerability";
            this.colVulnerability.Name = "colVulnerability";
            this.colVulnerability.ReadOnly = true;
            // 
            // colDataClasses
            // 
            this.colDataClasses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDataClasses.HeaderText = "Data Classes";
            this.colDataClasses.Name = "colDataClasses";
            this.colDataClasses.ReadOnly = true;
            // 
            // btnGetBreaches
            // 
            this.btnGetBreaches.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBreaches.Location = new System.Drawing.Point(16, 19);
            this.btnGetBreaches.Name = "btnGetBreaches";
            this.btnGetBreaches.Size = new System.Drawing.Size(121, 37);
            this.btnGetBreaches.TabIndex = 12;
            this.btnGetBreaches.Text = "Fetch";
            this.btnGetBreaches.UseVisualStyleBackColor = true;
            this.btnGetBreaches.Click += new System.EventHandler(this.btnGetBreaches_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.txtPasswordDesc);
            this.tabPage2.Controls.Add(this.chkShowPassword);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtAlgorithm);
            this.tabPage2.Controls.Add(this.lbresults);
            this.tabPage2.Controls.Add(this.txtPassWordHash);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.GetHash);
            this.tabPage2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1315, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check for Password Breach";
            // 
            // txtPasswordDesc
            // 
            this.txtPasswordDesc.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordDesc.Location = new System.Drawing.Point(22, 377);
            this.txtPasswordDesc.Multiline = true;
            this.txtPasswordDesc.Name = "txtPasswordDesc";
            this.txtPasswordDesc.ReadOnly = true;
            this.txtPasswordDesc.Size = new System.Drawing.Size(1275, 142);
            this.txtPasswordDesc.TabIndex = 24;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(340, 27);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(144, 21);
            this.chkShowPassword.TabIndex = 23;
            this.chkShowPassword.Text = "Show Password:";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hash:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Algorithm:";
            // 
            // txtAlgorithm
            // 
            this.txtAlgorithm.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlgorithm.Location = new System.Drawing.Point(146, 75);
            this.txtAlgorithm.Name = "txtAlgorithm";
            this.txtAlgorithm.ReadOnly = true;
            this.txtAlgorithm.Size = new System.Drawing.Size(339, 24);
            this.txtAlgorithm.TabIndex = 20;
            // 
            // lbresults
            // 
            this.lbresults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbresults.BackColor = System.Drawing.SystemColors.Info;
            this.lbresults.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresults.FormattingEnabled = true;
            this.lbresults.ItemHeight = 16;
            this.lbresults.Location = new System.Drawing.Point(22, 172);
            this.lbresults.Name = "lbresults";
            this.lbresults.Size = new System.Drawing.Size(1275, 180);
            this.lbresults.TabIndex = 17;
            // 
            // txtPassWordHash
            // 
            this.txtPassWordHash.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWordHash.Location = new System.Drawing.Point(146, 104);
            this.txtPassWordHash.Multiline = true;
            this.txtPassWordHash.Name = "txtPassWordHash";
            this.txtPassWordHash.ReadOnly = true;
            this.txtPassWordHash.Size = new System.Drawing.Size(1151, 53);
            this.txtPassWordHash.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtPassword.Location = new System.Drawing.Point(146, 24);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(187, 24);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Password:";
            // 
            // GetHash
            // 
            this.GetHash.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetHash.Location = new System.Drawing.Point(490, 17);
            this.GetHash.Name = "GetHash";
            this.GetHash.Size = new System.Drawing.Size(110, 37);
            this.GetHash.TabIndex = 13;
            this.GetHash.Text = "Scan";
            this.GetHash.UseVisualStyleBackColor = true;
            this.GetHash.Click += new System.EventHandler(this.GetHash_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Click on the Name column to get a description of the breach";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 639);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check if you have been Pwned";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtTotalBreaches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBreach;
        private System.Windows.Forms.Button btnGetBreaches;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAlgorithm;
        private System.Windows.Forms.ListBox lbresults;
        private System.Windows.Forms.TextBox txtPassWordHash;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetHash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.TextBox txtPasswordDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHashType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBreachDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPwnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVulnerability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataClasses;
        private System.Windows.Forms.Label label6;
    }
}

