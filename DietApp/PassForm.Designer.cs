namespace DietApp
{
    partial class PassForm
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.gbRecovery = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
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
            this.gbRecovery.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(6, 31);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 27);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(6, 51);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(222, 30);
            this.txtbEmail.TabIndex = 1;
            this.txtbEmail.TextChanged += new System.EventHandler(this.txtbEmail_TextChanged);
            // 
            // txtbAnswer
            // 
            this.txtbAnswer.Location = new System.Drawing.Point(6, 117);
            this.txtbAnswer.Name = "txtbAnswer";
            this.txtbAnswer.Size = new System.Drawing.Size(222, 30);
            this.txtbAnswer.TabIndex = 2;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnswer.Location = new System.Drawing.Point(6, 97);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(277, 27);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Answer of the Question";
            // 
            // gbRecovery
            // 
            this.gbRecovery.BackColor = System.Drawing.Color.LightCoral;
            this.gbRecovery.Controls.Add(this.btnCancel);
            this.gbRecovery.Controls.Add(this.btnRecover);
            this.gbRecovery.Controls.Add(this.lblOutput);
            this.gbRecovery.Controls.Add(this.lblEmail);
            this.gbRecovery.Controls.Add(this.txtbAnswer);
            this.gbRecovery.Controls.Add(this.lblAnswer);
            this.gbRecovery.Controls.Add(this.txtbEmail);
            this.gbRecovery.Location = new System.Drawing.Point(12, 27);
            this.gbRecovery.Name = "gbRecovery";
            this.gbRecovery.Size = new System.Drawing.Size(464, 231);
            this.gbRecovery.TabIndex = 4;
            this.gbRecovery.TabStop = false;
            this.gbRecovery.Text = "Recover Password";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(9, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecover.BackColor = System.Drawing.Color.DarkGray;
            this.btnRecover.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecover.Location = new System.Drawing.Point(129, 196);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(100, 30);
            this.btnRecover.TabIndex = 4;
            this.btnRecover.Text = "Recover";
            this.btnRecover.UseVisualStyleBackColor = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.BackColor = System.Drawing.SystemColors.Window;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(238, 19);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(220, 206);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.msMenu.Size = new System.Drawing.Size(483, 33);
            this.msMenu.TabIndex = 5;
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
            // 
            // msiLight
            // 
            this.msiLight.Name = "msiLight";
            this.msiLight.Size = new System.Drawing.Size(205, 34);
            this.msiLight.Text = "Light Mode";
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
            // PassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 251);
            this.Controls.Add(this.gbRecovery);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(505, 307);
            this.MinimumSize = new System.Drawing.Size(505, 307);
            this.Name = "PassForm";
            this.Text = "Password Recovery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassForm_FormClosing);
            this.gbRecovery.ResumeLayout(false);
            this.gbRecovery.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.GroupBox gbRecovery;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.Button btnCancel;
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
    }
}