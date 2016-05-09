namespace KeyGeneratorApp
{
    partial class licenceKeyGeneratorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(licenceKeyGeneratorUI));
            this.nbLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.openButton = new System.Windows.Forms.Button();
            this.saveCheckBox = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.copyAllButton = new System.Windows.Forms.Button();
            this.generateLicenceKeyButton = new System.Windows.Forms.Button();
            this.licenceKeyCopyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.validDateCopyButton = new System.Windows.Forms.Button();
            this.accountNumberCopyButton = new System.Windows.Forms.Button();
            this.licenceKeyTextBox = new System.Windows.Forms.TextBox();
            this.maxAccountNumberLabel = new System.Windows.Forms.Label();
            this.maxValidDaysLabel = new System.Windows.Forms.Label();
            this.validTillabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.digitCheckDaysLabel = new System.Windows.Forms.Label();
            this.digitCheckLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.validityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyboardpictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nbLabel
            // 
            this.nbLabel.AutoSize = true;
            this.nbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nbLabel.Location = new System.Drawing.Point(12, 28);
            this.nbLabel.Name = "nbLabel";
            this.nbLabel.Size = new System.Drawing.Size(496, 17);
            this.nbLabel.TabIndex = 0;
            this.nbLabel.Text = "N.B: Ensure that today\'s DATE(dd-mm-yyyy) on this computer is set correctly.";
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(511, 26);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Password: ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(144, 63);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(223, 24);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(368, 60);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(87, 28);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            this.loginButton.MouseHover += new System.EventHandler(this.loginButton_MouseHover);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.openButton);
            this.groupBox.Controls.Add(this.saveCheckBox);
            this.groupBox.Controls.Add(this.resetButton);
            this.groupBox.Controls.Add(this.copyAllButton);
            this.groupBox.Controls.Add(this.generateLicenceKeyButton);
            this.groupBox.Controls.Add(this.licenceKeyCopyButton);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.validDateCopyButton);
            this.groupBox.Controls.Add(this.accountNumberCopyButton);
            this.groupBox.Controls.Add(this.licenceKeyTextBox);
            this.groupBox.Controls.Add(this.maxAccountNumberLabel);
            this.groupBox.Controls.Add(this.maxValidDaysLabel);
            this.groupBox.Controls.Add(this.validTillabel);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.digitCheckDaysLabel);
            this.groupBox.Controls.Add(this.digitCheckLabel);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.validityTextBox);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.accountNumberTextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox.Location = new System.Drawing.Point(15, 92);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(577, 285);
            this.groupBox.TabIndex = 24;
            this.groupBox.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(336, 256);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(79, 23);
            this.openButton.TabIndex = 72;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Visible = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveCheckBox
            // 
            this.saveCheckBox.AutoSize = true;
            this.saveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCheckBox.Location = new System.Drawing.Point(129, 257);
            this.saveCheckBox.Name = "saveCheckBox";
            this.saveCheckBox.Size = new System.Drawing.Size(186, 22);
            this.saveCheckBox.TabIndex = 71;
            this.saveCheckBox.Text = "Save all data in a .txt file.";
            this.saveCheckBox.UseVisualStyleBackColor = true;
            this.saveCheckBox.CheckedChanged += new System.EventHandler(this.saveCheckBox_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(6, 108);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 57);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset All";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // copyAllButton
            // 
            this.copyAllButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.copyAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyAllButton.ForeColor = System.Drawing.Color.White;
            this.copyAllButton.Location = new System.Drawing.Point(433, 108);
            this.copyAllButton.Name = "copyAllButton";
            this.copyAllButton.Size = new System.Drawing.Size(135, 57);
            this.copyAllButton.TabIndex = 6;
            this.copyAllButton.Text = "Copy All";
            this.copyAllButton.UseVisualStyleBackColor = false;
            this.copyAllButton.Click += new System.EventHandler(this.copyAllButton_Click);
            // 
            // generateLicenceKeyButton
            // 
            this.generateLicenceKeyButton.AccessibleName = "";
            this.generateLicenceKeyButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.generateLicenceKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateLicenceKeyButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.generateLicenceKeyButton.Location = new System.Drawing.Point(129, 108);
            this.generateLicenceKeyButton.Name = "generateLicenceKeyButton";
            this.generateLicenceKeyButton.Size = new System.Drawing.Size(286, 57);
            this.generateLicenceKeyButton.TabIndex = 5;
            this.generateLicenceKeyButton.Text = "Generate Licence Key";
            this.generateLicenceKeyButton.UseVisualStyleBackColor = false;
            this.generateLicenceKeyButton.Click += new System.EventHandler(this.generateLicenceKeyButton_Click);
            // 
            // licenceKeyCopyButton
            // 
            this.licenceKeyCopyButton.AccessibleName = "";
            this.licenceKeyCopyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.licenceKeyCopyButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.licenceKeyCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenceKeyCopyButton.ForeColor = System.Drawing.Color.White;
            this.licenceKeyCopyButton.Location = new System.Drawing.Point(433, 193);
            this.licenceKeyCopyButton.Name = "licenceKeyCopyButton";
            this.licenceKeyCopyButton.Size = new System.Drawing.Size(135, 34);
            this.licenceKeyCopyButton.TabIndex = 7;
            this.licenceKeyCopyButton.Text = "Copy";
            this.licenceKeyCopyButton.UseVisualStyleBackColor = false;
            this.licenceKeyCopyButton.Click += new System.EventHandler(this.licenceKeyCopyButton_Click);
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Licence  Key:";
            // 
            // validDateCopyButton
            // 
            this.validDateCopyButton.AccessibleName = "";
            this.validDateCopyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.validDateCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validDateCopyButton.ForeColor = System.Drawing.Color.White;
            this.validDateCopyButton.Location = new System.Drawing.Point(502, 52);
            this.validDateCopyButton.Name = "validDateCopyButton";
            this.validDateCopyButton.Size = new System.Drawing.Size(66, 29);
            this.validDateCopyButton.TabIndex = 9;
            this.validDateCopyButton.Text = "Copy";
            this.validDateCopyButton.UseVisualStyleBackColor = false;
            this.validDateCopyButton.Click += new System.EventHandler(this.validDateCopyButton_Click);
            // 
            // accountNumberCopyButton
            // 
            this.accountNumberCopyButton.AccessibleName = "";
            this.accountNumberCopyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.accountNumberCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberCopyButton.ForeColor = System.Drawing.Color.White;
            this.accountNumberCopyButton.Location = new System.Drawing.Point(288, 25);
            this.accountNumberCopyButton.Margin = new System.Windows.Forms.Padding(1);
            this.accountNumberCopyButton.Name = "accountNumberCopyButton";
            this.accountNumberCopyButton.Size = new System.Drawing.Size(66, 29);
            this.accountNumberCopyButton.TabIndex = 8;
            this.accountNumberCopyButton.Text = "Copy";
            this.accountNumberCopyButton.UseVisualStyleBackColor = false;
            this.accountNumberCopyButton.Click += new System.EventHandler(this.accountNumberCopyButton_Click);
            // 
            // licenceKeyTextBox
            // 
            this.licenceKeyTextBox.AccessibleName = "";
            this.licenceKeyTextBox.BackColor = System.Drawing.Color.White;
            this.licenceKeyTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.licenceKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenceKeyTextBox.ForeColor = System.Drawing.Color.Black;
            this.licenceKeyTextBox.Location = new System.Drawing.Point(129, 199);
            this.licenceKeyTextBox.Name = "licenceKeyTextBox";
            this.licenceKeyTextBox.ReadOnly = true;
            this.licenceKeyTextBox.Size = new System.Drawing.Size(286, 26);
            this.licenceKeyTextBox.TabIndex = 70;
            this.licenceKeyTextBox.TabStop = false;
            this.licenceKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxAccountNumberLabel
            // 
            this.maxAccountNumberLabel.AccessibleName = "";
            this.maxAccountNumberLabel.AutoSize = true;
            this.maxAccountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAccountNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.maxAccountNumberLabel.Location = new System.Drawing.Point(128, 9);
            this.maxAccountNumberLabel.Name = "maxAccountNumberLabel";
            this.maxAccountNumberLabel.Size = new System.Drawing.Size(180, 15);
            this.maxAccountNumberLabel.TabIndex = 33;
            this.maxAccountNumberLabel.Text = "MAX: 999999999999 (12 digits)";
            this.maxAccountNumberLabel.Visible = false;
            // 
            // maxValidDaysLabel
            // 
            this.maxValidDaysLabel.AccessibleName = "";
            this.maxValidDaysLabel.AutoSize = true;
            this.maxValidDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxValidDaysLabel.ForeColor = System.Drawing.Color.Red;
            this.maxValidDaysLabel.Location = new System.Drawing.Point(410, 9);
            this.maxValidDaysLabel.Name = "maxValidDaysLabel";
            this.maxValidDaysLabel.Size = new System.Drawing.Size(63, 13);
            this.maxValidDaysLabel.TabIndex = 32;
            this.maxValidDaysLabel.Text = "MAX: Value";
            this.maxValidDaysLabel.Visible = false;
            // 
            // validTillabel
            // 
            this.validTillabel.AccessibleName = "";
            this.validTillabel.AutoSize = true;
            this.validTillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validTillabel.ForeColor = System.Drawing.Color.Red;
            this.validTillabel.Location = new System.Drawing.Point(409, 55);
            this.validTillabel.Name = "validTillabel";
            this.validTillabel.Size = new System.Drawing.Size(91, 20);
            this.validTillabel.TabIndex = 31;
            this.validTillabel.Text = "dd-mm-yyyy";
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(347, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Valid till: ";
            // 
            // digitCheckDaysLabel
            // 
            this.digitCheckDaysLabel.AccessibleName = "";
            this.digitCheckDaysLabel.AutoSize = true;
            this.digitCheckDaysLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitCheckDaysLabel.ForeColor = System.Drawing.Color.Red;
            this.digitCheckDaysLabel.Location = new System.Drawing.Point(480, 24);
            this.digitCheckDaysLabel.Name = "digitCheckDaysLabel";
            this.digitCheckDaysLabel.Size = new System.Drawing.Size(23, 27);
            this.digitCheckDaysLabel.TabIndex = 29;
            this.digitCheckDaysLabel.Text = "x";
            this.digitCheckDaysLabel.Visible = false;
            // 
            // digitCheckLabel
            // 
            this.digitCheckLabel.AccessibleName = "";
            this.digitCheckLabel.AutoSize = true;
            this.digitCheckLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.digitCheckLabel.Location = new System.Drawing.Point(271, 25);
            this.digitCheckLabel.Name = "digitCheckLabel";
            this.digitCheckLabel.Size = new System.Drawing.Size(23, 27);
            this.digitCheckLabel.TabIndex = 28;
            this.digitCheckLabel.Text = "x";
            this.digitCheckLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(499, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "( in days )";
            // 
            // validityTextBox
            // 
            this.validityTextBox.AccessibleName = "";
            this.validityTextBox.BackColor = System.Drawing.Color.White;
            this.validityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validityTextBox.Location = new System.Drawing.Point(412, 26);
            this.validityTextBox.MaxLength = 5;
            this.validityTextBox.Name = "validityTextBox";
            this.validityTextBox.Size = new System.Drawing.Size(87, 26);
            this.validityTextBox.TabIndex = 4;
            this.validityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.validityTextBox.Click += new System.EventHandler(this.validityTextBox_Click);
            this.validityTextBox.TextChanged += new System.EventHandler(this.validityTextBox_TextChanged);
            this.validityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.validityTextBox_KeyDown);
            this.validityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validityTextBox_KeyPress);
            this.validityTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validityTextBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Validity: ";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.AccessibleName = "";
            this.accountNumberTextBox.BackColor = System.Drawing.Color.White;
            this.accountNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberTextBox.Location = new System.Drawing.Point(129, 27);
            this.accountNumberTextBox.MaxLength = 12;
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(159, 26);
            this.accountNumberTextBox.TabIndex = 3;
            this.accountNumberTextBox.Tag = "";
            this.accountNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accountNumberTextBox.Click += new System.EventHandler(this.accountNumberTextBox_Click);
            this.accountNumberTextBox.TextChanged += new System.EventHandler(this.accountNumberTextBox_TextChanged);
            this.accountNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.accountNumberTextBox_KeyDown);
            this.accountNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountNumberTextBox_KeyPress);
            this.accountNumberTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.accountNumberTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Account Number: ";
            // 
            // keyboardpictureBox
            // 
            this.keyboardpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("keyboardpictureBox.Image")));
            this.keyboardpictureBox.Location = new System.Drawing.Point(40, 348);
            this.keyboardpictureBox.Name = "keyboardpictureBox";
            this.keyboardpictureBox.Size = new System.Drawing.Size(42, 23);
            this.keyboardpictureBox.TabIndex = 75;
            this.keyboardpictureBox.TabStop = false;
            this.keyboardpictureBox.Click += new System.EventHandler(this.keyboardpictureBox_Click);
            // 
            // licenceKeyGeneratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(608, 389);
            this.Controls.Add(this.keyboardpictureBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.nbLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "licenceKeyGeneratorUI";
            this.Text = "Licence Key Generator";
            this.Load += new System.EventHandler(this.licenceKeyGeneratorUI_Load);
            this.Resize += new System.EventHandler(this.licenceKeyGeneratorUI_Resize);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nbLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button generateLicenceKeyButton;
        private System.Windows.Forms.Button licenceKeyCopyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button validDateCopyButton;
        private System.Windows.Forms.Button accountNumberCopyButton;
        private System.Windows.Forms.TextBox licenceKeyTextBox;
        private System.Windows.Forms.Label maxAccountNumberLabel;
        private System.Windows.Forms.Label maxValidDaysLabel;
        private System.Windows.Forms.Label validTillabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label digitCheckDaysLabel;
        private System.Windows.Forms.Label digitCheckLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox validityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyAllButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.CheckBox saveCheckBox;
        private System.Windows.Forms.PictureBox keyboardpictureBox;
    }
}

