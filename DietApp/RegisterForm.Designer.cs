namespace DietApp
{
    partial class RegisterForm
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLang = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEng = new System.Windows.Forms.ToolStripMenuItem();
            this.msiTr = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.gbRegistry = new System.Windows.Forms.GroupBox();
            this.cbSecurity = new System.Windows.Forms.ComboBox();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtbAnswer = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.msMenu.SuspendLayout();
            this.gbRegistry.SuspendLayout();
            this.gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSettings});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(706, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // msSettings
            // 
            this.msSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiLang});
            this.msSettings.Name = "msSettings";
            this.msSettings.Size = new System.Drawing.Size(61, 20);
            this.msSettings.Text = "Settings";
            // 
            // msiLang
            // 
            this.msiLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiEng,
            this.msiTr});
            this.msiLang.Name = "msiLang";
            this.msiLang.Size = new System.Drawing.Size(180, 22);
            this.msiLang.Text = "Language";
            // 
            // msiEng
            // 
            this.msiEng.Name = "msiEng";
            this.msiEng.Size = new System.Drawing.Size(180, 22);
            this.msiEng.Text = "English";
            this.msiEng.Click += new System.EventHandler(this.msiEng_Click);
            // 
            // msiTr
            // 
            this.msiTr.Name = "msiTr";
            this.msiTr.Size = new System.Drawing.Size(180, 22);
            this.msiTr.Text = "Turkish";
            this.msiTr.Click += new System.EventHandler(this.msiTr_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.LightGray;
            this.lblGreeting.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGreeting.Location = new System.Drawing.Point(12, 43);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(244, 29);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Create New Account";
            // 
            // gbRegistry
            // 
            this.gbRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegistry.Controls.Add(this.cbSecurity);
            this.gbRegistry.Controls.Add(this.lblSecurity);
            this.gbRegistry.Controls.Add(this.lblAnswer);
            this.gbRegistry.Controls.Add(this.txtbAnswer);
            this.gbRegistry.Controls.Add(this.lblPass);
            this.gbRegistry.Controls.Add(this.txtbPass);
            this.gbRegistry.Controls.Add(this.txtbEmail);
            this.gbRegistry.Controls.Add(this.lblEmail);
            this.gbRegistry.Location = new System.Drawing.Point(32, 86);
            this.gbRegistry.Name = "gbRegistry";
            this.gbRegistry.Size = new System.Drawing.Size(328, 350);
            this.gbRegistry.TabIndex = 2;
            this.gbRegistry.TabStop = false;
            this.gbRegistry.Text = "Registry";
            // 
            // cbSecurity
            // 
            this.cbSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecurity.FormattingEnabled = true;
            this.cbSecurity.Items.AddRange(new object[] {
            "What is the name of the primary school you went to?",
            "What is the name of your first pet?",
            "What city were you born in?",
            "What is your oldest sibling’s middle name?",
            "What was the make and model of your first car?"});
            this.cbSecurity.Location = new System.Drawing.Point(6, 211);
            this.cbSecurity.Name = "cbSecurity";
            this.cbSecurity.Size = new System.Drawing.Size(310, 24);
            this.cbSecurity.TabIndex = 3;
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecurity.Location = new System.Drawing.Point(7, 191);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(145, 18);
            this.lblSecurity.TabIndex = 3;
            this.lblSecurity.Text = "Security Question *";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnswer.Location = new System.Drawing.Point(6, 270);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(70, 18);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Answer *";
            // 
            // txtbAnswer
            // 
            this.txtbAnswer.Location = new System.Drawing.Point(6, 290);
            this.txtbAnswer.Name = "txtbAnswer";
            this.txtbAnswer.Size = new System.Drawing.Size(310, 23);
            this.txtbAnswer.TabIndex = 4;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.Location = new System.Drawing.Point(3, 113);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(87, 18);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password *";
            // 
            // txtbPass
            // 
            this.txtbPass.Location = new System.Drawing.Point(5, 133);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(311, 23);
            this.txtbPass.TabIndex = 2;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(6, 55);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(310, 23);
            this.txtbEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(7, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 18);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email *";
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPersonInfo.Controls.Add(this.rbFemale);
            this.gbPersonInfo.Controls.Add(this.rbMale);
            this.gbPersonInfo.Controls.Add(this.lblGender);
            this.gbPersonInfo.Controls.Add(this.nudHeight);
            this.gbPersonInfo.Controls.Add(this.nudWeight);
            this.gbPersonInfo.Controls.Add(this.lblHeight);
            this.gbPersonInfo.Controls.Add(this.nudAge);
            this.gbPersonInfo.Controls.Add(this.lblWeight);
            this.gbPersonInfo.Controls.Add(this.lblAge);
            this.gbPersonInfo.Controls.Add(this.lblLastName);
            this.gbPersonInfo.Controls.Add(this.txtbLastName);
            this.gbPersonInfo.Controls.Add(this.lblFirstName);
            this.gbPersonInfo.Controls.Add(this.txtbFirstName);
            this.gbPersonInfo.Location = new System.Drawing.Point(354, 86);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(328, 350);
            this.gbPersonInfo.TabIndex = 3;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Information";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFemale.Location = new System.Drawing.Point(151, 292);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(68, 20);
            this.rbFemale.TabIndex = 11;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMale.Location = new System.Drawing.Point(57, 292);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(53, 20);
            this.rbMale.TabIndex = 10;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.Location = new System.Drawing.Point(6, 270);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(72, 18);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender *";
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 2;
            this.nudHeight.Location = new System.Drawing.Point(232, 211);
            this.nudHeight.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(83, 23);
            this.nudHeight.TabIndex = 9;
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 1;
            this.nudWeight.Location = new System.Drawing.Point(121, 212);
            this.nudWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(83, 23);
            this.nudWeight.TabIndex = 8;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeight.Location = new System.Drawing.Point(229, 190);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(65, 18);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height *";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(6, 211);
            this.nudAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(83, 23);
            this.nudAge.TabIndex = 7;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeight.Location = new System.Drawing.Point(118, 190);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(67, 18);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight *";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(6, 191);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 18);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age *";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.Location = new System.Drawing.Point(6, 113);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 18);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(5, 133);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(310, 23);
            this.txtbLastName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(5, 55);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(310, 23);
            this.txtbFirstName.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.Location = new System.Drawing.Point(532, 457);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 50);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(32, 457);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::DietApp.Properties.Resources.soluk;
            this.ClientSize = new System.Drawing.Size(706, 519);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.gbPersonInfo);
            this.Controls.Add(this.gbRegistry);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(611, 558);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.gbRegistry.ResumeLayout(false);
            this.gbRegistry.PerformLayout();
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msSettings;
        private System.Windows.Forms.ToolStripMenuItem msiLang;
        private System.Windows.Forms.ToolStripMenuItem msiEng;
        private System.Windows.Forms.ToolStripMenuItem msiTr;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox gbRegistry;
        private System.Windows.Forms.ComboBox cbSecurity;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtbAnswer;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
    }
}