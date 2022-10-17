namespace DietApp
{
    partial class LoginForm
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
            this.msiThemes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDark = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLight = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLang = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEng = new System.Windows.Forms.ToolStripMenuItem();
            this.msiTr = new System.Windows.Forms.ToolStripMenuItem();
            this.msAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msiContact = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLicence = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDesc = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblForget = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSettings,
            this.msAbout});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(511, 33);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // msSettings
            // 
            this.msSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiThemes,
            this.msiLang});
            this.msSettings.Name = "msSettings";
            this.msSettings.Size = new System.Drawing.Size(92, 29);
            this.msSettings.Text = "Settings";
            // 
            // msiThemes
            // 
            this.msiThemes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiDark,
            this.msiLight});
            this.msiThemes.Name = "msiThemes";
            this.msiThemes.Size = new System.Drawing.Size(191, 34);
            this.msiThemes.Text = "Themes";
            // 
            // msiDark
            // 
            this.msiDark.Name = "msiDark";
            this.msiDark.Size = new System.Drawing.Size(205, 34);
            this.msiDark.Text = "Dark Mode";
            this.msiDark.Click += new System.EventHandler(this.msiDark_Click);
            // 
            // msiLight
            // 
            this.msiLight.Name = "msiLight";
            this.msiLight.Size = new System.Drawing.Size(205, 34);
            this.msiLight.Text = "Light Mode";
            this.msiLight.Click += new System.EventHandler(this.msiLight_Click);
            // 
            // msiLang
            // 
            this.msiLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiEng,
            this.msiTr});
            this.msiLang.Name = "msiLang";
            this.msiLang.Size = new System.Drawing.Size(191, 34);
            this.msiLang.Text = "Language";
            // 
            // msiEng
            // 
            this.msiEng.Name = "msiEng";
            this.msiEng.Size = new System.Drawing.Size(170, 34);
            this.msiEng.Text = "English";
            this.msiEng.Click += new System.EventHandler(this.msiEng_Click);
            // 
            // msiTr
            // 
            this.msiTr.Name = "msiTr";
            this.msiTr.Size = new System.Drawing.Size(170, 34);
            this.msiTr.Text = "Turkish";
            this.msiTr.Click += new System.EventHandler(this.msiTr_Click);
            // 
            // msAbout
            // 
            this.msAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiContact,
            this.msiLicence,
            this.msiAboutUs});
            this.msAbout.Name = "msAbout";
            this.msAbout.Size = new System.Drawing.Size(78, 29);
            this.msAbout.Text = "About";
            // 
            // msiContact
            // 
            this.msiContact.Name = "msiContact";
            this.msiContact.Size = new System.Drawing.Size(270, 34);
            this.msiContact.Text = "Contact";
            this.msiContact.Click += new System.EventHandler(this.msiContact_Click);
            // 
            // msiLicence
            // 
            this.msiLicence.Name = "msiLicence";
            this.msiLicence.Size = new System.Drawing.Size(270, 34);
            this.msiLicence.Text = "Licence";
            this.msiLicence.Click += new System.EventHandler(this.msiLicence_Click);
            // 
            // msiAboutUs
            // 
            this.msiAboutUs.Name = "msiAboutUs";
            this.msiAboutUs.Size = new System.Drawing.Size(270, 34);
            this.msiAboutUs.Text = "About Us";
            this.msiAboutUs.Click += new System.EventHandler(this.msiAboutUs_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDesc.Location = new System.Drawing.Point(79, 195);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(348, 115);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "This app helps you managing your diet easier by tracking your calorie index per d" +
    "ay, tracking your exercise activity throught the day, and tracking your hydratio" +
    "n level.";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbLogin
            // 
            this.gbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogin.BackColor = System.Drawing.Color.Silver;
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtbPass);
            this.gbLogin.Controls.Add(this.txtbEmail);
            this.gbLogin.Controls.Add(this.lblPass);
            this.gbLogin.Controls.Add(this.lblEmail);
            this.gbLogin.Location = new System.Drawing.Point(79, 303);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(348, 227);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(167, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtbPass
            // 
            this.txtbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPass.Location = new System.Drawing.Point(66, 137);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.PasswordChar = '*';
            this.txtbPass.Size = new System.Drawing.Size(221, 30);
            this.txtbPass.TabIndex = 3;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbEmail.Location = new System.Drawing.Point(66, 59);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(221, 30);
            this.txtbEmail.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.Location = new System.Drawing.Point(63, 117);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(122, 27);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(63, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 27);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblRegister
            // 
            this.lblRegister.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegister.Location = new System.Drawing.Point(333, 547);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRegister.Size = new System.Drawing.Size(94, 17);
            this.lblRegister.TabIndex = 4;
            this.lblRegister.Text = "Register";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // lblForget
            // 
            this.lblForget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblForget.AutoSize = true;
            this.lblForget.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForget.Location = new System.Drawing.Point(77, 547);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(220, 26);
            this.lblForget.TabIndex = 3;
            this.lblForget.Text = "Forgot My Password";
            this.lblForget.Click += new System.EventHandler(this.lblForget_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DietApp.Properties.Resources.fittlebaslik;
            this.pictureBox1.Location = new System.Drawing.Point(79, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(511, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblForget);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(533, 612);
            this.MinimumSize = new System.Drawing.Size(533, 612);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msSettings;
        private System.Windows.Forms.ToolStripMenuItem msiThemes;
        private System.Windows.Forms.ToolStripMenuItem msiDark;
        private System.Windows.Forms.ToolStripMenuItem msiLight;
        private System.Windows.Forms.ToolStripMenuItem msiLang;
        private System.Windows.Forms.ToolStripMenuItem msiEng;
        private System.Windows.Forms.ToolStripMenuItem msiTr;
        private System.Windows.Forms.ToolStripMenuItem msAbout;
        private System.Windows.Forms.ToolStripMenuItem msiContact;
        private System.Windows.Forms.ToolStripMenuItem msiLicence;
        private System.Windows.Forms.ToolStripMenuItem msiAboutUs;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblForget;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

