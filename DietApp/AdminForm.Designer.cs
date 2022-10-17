namespace DietApp
{
    partial class AdminForm
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
            this.gbFoodAdd = new System.Windows.Forms.GroupBox();
            this.pbPicturePreview = new System.Windows.Forms.PictureBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnOpenFileExplorer = new System.Windows.Forms.Button();
            this.txtbPicturePath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.nudCalorie = new System.Windows.Forms.NumericUpDown();
            this.txtbFoodName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblFoodList = new System.Windows.Forms.Label();
            this.ofdFileExplorer = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.msMenu.SuspendLayout();
            this.gbFoodAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicturePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSettings,
            this.msAbout});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(997, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // msSettings
            // 
            this.msSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiThemes,
            this.msiLang});
            this.msSettings.Name = "msSettings";
            this.msSettings.Size = new System.Drawing.Size(61, 20);
            this.msSettings.Text = "Settings";
            // 
            // msiThemes
            // 
            this.msiThemes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiDark,
            this.msiLight});
            this.msiThemes.Name = "msiThemes";
            this.msiThemes.Size = new System.Drawing.Size(126, 22);
            this.msiThemes.Text = "Themes";
            // 
            // msiDark
            // 
            this.msiDark.Name = "msiDark";
            this.msiDark.Size = new System.Drawing.Size(140, 22);
            this.msiDark.Text = "Dark Theme";
            // 
            // msiLight
            // 
            this.msiLight.Name = "msiLight";
            this.msiLight.Size = new System.Drawing.Size(140, 22);
            this.msiLight.Text = "Light Theme";
            // 
            // msiLang
            // 
            this.msiLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiEng,
            this.msiTr});
            this.msiLang.Name = "msiLang";
            this.msiLang.Size = new System.Drawing.Size(126, 22);
            this.msiLang.Text = "Language";
            // 
            // msiEng
            // 
            this.msiEng.Name = "msiEng";
            this.msiEng.Size = new System.Drawing.Size(112, 22);
            this.msiEng.Text = "English";
            // 
            // msiTr
            // 
            this.msiTr.Name = "msiTr";
            this.msiTr.Size = new System.Drawing.Size(112, 22);
            this.msiTr.Text = "Turkish";
            // 
            // msAbout
            // 
            this.msAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiContact,
            this.msiLicence,
            this.msiAboutUs});
            this.msAbout.Name = "msAbout";
            this.msAbout.Size = new System.Drawing.Size(52, 20);
            this.msAbout.Text = "About";
            // 
            // msiContact
            // 
            this.msiContact.Name = "msiContact";
            this.msiContact.Size = new System.Drawing.Size(123, 22);
            this.msiContact.Text = "Contact";
            // 
            // msiLicence
            // 
            this.msiLicence.Name = "msiLicence";
            this.msiLicence.Size = new System.Drawing.Size(123, 22);
            this.msiLicence.Text = "Licence";
            // 
            // msiAboutUs
            // 
            this.msiAboutUs.Name = "msiAboutUs";
            this.msiAboutUs.Size = new System.Drawing.Size(123, 22);
            this.msiAboutUs.Text = "About Us";
            // 
            // gbFoodAdd
            // 
            this.gbFoodAdd.BackgroundImage = global::DietApp.Properties.Resources.soluk1;
            this.gbFoodAdd.Controls.Add(this.pbPicturePreview);
            this.gbFoodAdd.Controls.Add(this.lblPreview);
            this.gbFoodAdd.Controls.Add(this.btnOpenFileExplorer);
            this.gbFoodAdd.Controls.Add(this.txtbPicturePath);
            this.gbFoodAdd.Controls.Add(this.lblPath);
            this.gbFoodAdd.Controls.Add(this.btnAdd);
            this.gbFoodAdd.Controls.Add(this.cbCategory);
            this.gbFoodAdd.Controls.Add(this.nudCalorie);
            this.gbFoodAdd.Controls.Add(this.txtbFoodName);
            this.gbFoodAdd.Controls.Add(this.lblCategory);
            this.gbFoodAdd.Controls.Add(this.label4);
            this.gbFoodAdd.Controls.Add(this.lblCalorie);
            this.gbFoodAdd.Controls.Add(this.lblFoodName);
            this.gbFoodAdd.Location = new System.Drawing.Point(13, 28);
            this.gbFoodAdd.Margin = new System.Windows.Forms.Padding(4);
            this.gbFoodAdd.Name = "gbFoodAdd";
            this.gbFoodAdd.Padding = new System.Windows.Forms.Padding(4);
            this.gbFoodAdd.Size = new System.Drawing.Size(344, 419);
            this.gbFoodAdd.TabIndex = 1;
            this.gbFoodAdd.TabStop = false;
            this.gbFoodAdd.Text = "Food Addition";
            // 
            // pbPicturePreview
            // 
            this.pbPicturePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbPicturePreview.BackColor = System.Drawing.Color.Transparent;
            this.pbPicturePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPicturePreview.Location = new System.Drawing.Point(14, 196);
            this.pbPicturePreview.Name = "pbPicturePreview";
            this.pbPicturePreview.Size = new System.Drawing.Size(188, 200);
            this.pbPicturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicturePreview.TabIndex = 9;
            this.pbPicturePreview.TabStop = false;
            this.pbPicturePreview.BackgroundImageChanged += new System.EventHandler(this.pbPicturePreview_BackgroundImageChanged);
            // 
            // lblPreview
            // 
            this.lblPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPreview.AutoSize = true;
            this.lblPreview.BackColor = System.Drawing.Color.LightCoral;
            this.lblPreview.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPreview.Location = new System.Drawing.Point(11, 176);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(128, 19);
            this.lblPreview.TabIndex = 8;
            this.lblPreview.Text = "Picture Preview";
            // 
            // btnOpenFileExplorer
            // 
            this.btnOpenFileExplorer.Location = new System.Drawing.Point(208, 123);
            this.btnOpenFileExplorer.Name = "btnOpenFileExplorer";
            this.btnOpenFileExplorer.Size = new System.Drawing.Size(35, 23);
            this.btnOpenFileExplorer.TabIndex = 3;
            this.btnOpenFileExplorer.Text = "...";
            this.btnOpenFileExplorer.UseVisualStyleBackColor = true;
            this.btnOpenFileExplorer.Click += new System.EventHandler(this.btnOpenFileExplorer_Click);
            // 
            // txtbPicturePath
            // 
            this.txtbPicturePath.Location = new System.Drawing.Point(11, 123);
            this.txtbPicturePath.Name = "txtbPicturePath";
            this.txtbPicturePath.Size = new System.Drawing.Size(191, 23);
            this.txtbPicturePath.TabIndex = 6;
            this.txtbPicturePath.TextChanged += new System.EventHandler(this.txtbPicturePath_TextChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.Color.LightCoral;
            this.lblPath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPath.Location = new System.Drawing.Point(11, 102);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(102, 19);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "Picture Path";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(222, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(162, 54);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(173, 24);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // nudCalorie
            // 
            this.nudCalorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCalorie.DecimalPlaces = 1;
            this.nudCalorie.Location = new System.Drawing.Point(218, 196);
            this.nudCalorie.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCalorie.Name = "nudCalorie";
            this.nudCalorie.Size = new System.Drawing.Size(65, 23);
            this.nudCalorie.TabIndex = 4;
            this.nudCalorie.ValueChanged += new System.EventHandler(this.nudCalorie_ValueChanged);
            // 
            // txtbFoodName
            // 
            this.txtbFoodName.Location = new System.Drawing.Point(11, 55);
            this.txtbFoodName.Name = "txtbFoodName";
            this.txtbFoodName.Size = new System.Drawing.Size(145, 23);
            this.txtbFoodName.TabIndex = 1;
            this.txtbFoodName.TextChanged += new System.EventHandler(this.txtbFoodName_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.LightCoral;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(159, 33);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 19);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(289, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "/ kcal";
            // 
            // lblCalorie
            // 
            this.lblCalorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.BackColor = System.Drawing.Color.LightCoral;
            this.lblCalorie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalorie.Location = new System.Drawing.Point(218, 176);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(63, 19);
            this.lblCalorie.TabIndex = 0;
            this.lblCalorie.Text = "Calorie";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.BackColor = System.Drawing.Color.LightCoral;
            this.lblFoodName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFoodName.Location = new System.Drawing.Point(8, 34);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(97, 19);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Food Name";
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoodList.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Location = new System.Drawing.Point(367, 44);
            this.dgvFoodList.MultiSelect = false;
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowHeadersVisible = false;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(620, 450);
            this.dgvFoodList.TabIndex = 8;
            this.dgvFoodList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFoodList_CellMouseDoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkGray;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(235, 454);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblFoodList
            // 
            this.lblFoodList.AutoSize = true;
            this.lblFoodList.BackColor = System.Drawing.Color.LightCoral;
            this.lblFoodList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFoodList.Location = new System.Drawing.Point(364, 24);
            this.lblFoodList.Name = "lblFoodList";
            this.lblFoodList.Size = new System.Drawing.Size(81, 19);
            this.lblFoodList.TabIndex = 5;
            this.lblFoodList.Text = "Food List";
            // 
            // ofdFileExplorer
            // 
            this.ofdFileExplorer.FileName = "openFileDialog1";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(12, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DietApp.Properties.Resources.soluk1;
            this.ClientSize = new System.Drawing.Size(997, 506);
            this.Controls.Add(this.lblFoodList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.gbFoodAdd);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1013, 545);
            this.Name = "AdminForm";
            this.Text = "Food List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.gbFoodAdd.ResumeLayout(false);
            this.gbFoodAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicturePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msSettings;
        private System.Windows.Forms.ToolStripMenuItem msAbout;
        private System.Windows.Forms.GroupBox gbFoodAdd;
        private System.Windows.Forms.TextBox txtbFoodName;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown nudCalorie;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCalorie;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblFoodList;
        private System.Windows.Forms.TextBox txtbPicturePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog ofdFileExplorer;
        private System.Windows.Forms.Button btnOpenFileExplorer;
        private System.Windows.Forms.PictureBox pbPicturePreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.ToolStripMenuItem msiThemes;
        private System.Windows.Forms.ToolStripMenuItem msiLang;
        private System.Windows.Forms.ToolStripMenuItem msiContact;
        private System.Windows.Forms.ToolStripMenuItem msiLicence;
        private System.Windows.Forms.ToolStripMenuItem msiAboutUs;
        private System.Windows.Forms.ToolStripMenuItem msiDark;
        private System.Windows.Forms.ToolStripMenuItem msiLight;
        private System.Windows.Forms.ToolStripMenuItem msiEng;
        private System.Windows.Forms.ToolStripMenuItem msiTr;
        private System.Windows.Forms.Button btnCancel;
    }
}