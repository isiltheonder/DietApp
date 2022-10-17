using DietApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp
{
    public partial class AdminForm : Form
    {
        Classes.AppDbContext db = new Classes.AppDbContext();
        private readonly int _userId;

        public AdminForm(string language, string theme, int userId)
        {

            InitializeComponent();
            ShowData();
            ChangeLanguage(language);
            _userId = userId;
        }

        #region Methods

        private Food TakeFoodData()
        {
            int foodId = dgvFoodList.CurrentRow.Index + 1;
            Food food = db.Foods.FirstOrDefault(f => f.ID == foodId);
            return food;
        }

        private void EnableElements()
        {
            btnAdd.Enabled = true;
            dgvFoodList.Enabled = true;

            var food = TakeFoodData();
            if (!db.Foods.Any(f => f.ID == food.ID))
            {
                if (TakeLanguageData() == "TR")
                {
                    btnAdd.Text = "Ekle";
                    btnRemove.Text = "Sil";
                }
                else
                {
                    btnAdd.Text = "Add";
                    btnRemove.Text = "Remove";
                }
            }
            else
            {
                if (TakeLanguageData() == "TR")
                {
                    btnAdd.Text = "Düzenle";
                    btnRemove.Text = "Vazgeç";
                }
                else
                {
                    btnAdd.Text = "Edit";
                    btnRemove.Text = "Cancel";
                }
            }
        }

        private void ShowData()
        {
            dgvFoodList.DataSource = db.Foods
                .Select(f => new
                {
                    ID = f.ID,
                    FoodName = f.Name,
                    Category = f.Category.Description,
                    Calorie = f.Calorie,
                    PicturePath = f.PicturePath
                })
                .ToList();

            cbCategory.DataSource = db.Categories.ToList();
        }

        private void ChangeLanguage(string language)
        {
            if (language == "TR")
            {
                msSettings.Text = "Ayarlar";
                msiThemes.Text = "Temalar";
                msiLang.Text = "Diller";
                msiDark.Text = "Koyu Tema";
                msiLight.Text = "Açık Tema";
                msiEng.Text = "İngilizce";
                msiTr.Text = "Türkçe";
                msAbout.Text = "Hakkında";
                msiContact.Text = "İletişim";
                msiLicence.Text = "Lisans";
                msiAboutUs.Text = "Hakkımızda";
                lblCalorie.Text = "Kalori";
                lblCategory.Text = "Kategori";
                lblPath.Text = "Resim Dosya Yolu";
                lblPreview.Text = "Resim Önizleme";
            }
            else
            {
                msSettings.Text = "Settings";
                msiThemes.Text = "Themes";
                msiLang.Text = "Language";
                msiDark.Text = "Dark Theme";
                msiLight.Text = "Light Theme";
                msiEng.Text = "English";
                msiTr.Text = "Turkish";
                msAbout.Text = "About";
                msiContact.Text = "Contact";
                msiLicence.Text = "Licence";
                msiAboutUs.Text = "About Us";
                lblCalorie.Text = "Calorie";
                lblCategory.Text = "Category";
                lblPath.Text = "Picture Path";
                lblPreview.Text = "Picture Preview";
            }
        }

        private void TakeUserInput(out string foodName, out int categoryId, out double calorie, out string path)
        {
            foodName = txtbFoodName.Text.Trim();
            categoryId = cbCategory.SelectedIndex + 1;
            calorie = (double)nudCalorie.Value;
            path = txtbPicturePath.Text;
        }

        private void ClearTextboxes()
        {
            txtbFoodName.Clear();
            txtbPicturePath.Clear();
            pbPicturePreview.Image.Dispose();
            nudCalorie.Value = 0;
        }

        private string TakeThemeData()
        {
            return "EN";
        }

        private string TakeLanguageData()
        {
            string language = "EN";

            if (btnAdd.Text == "Oturum Aç")
            {
                language = "TR";
            }
            else
            {
                language = "EN";
            }

            return language;
        }

        private void AddorEditFood()
        {
            if (btnAdd.Text == "Add" || btnAdd.Text == "Ekle")
            {
                TakeUserInput(out string foodName, out int categoryId, out double calorie, out string path);

                db.Foods.Add(new Food()
                {
                    Name = foodName,
                    CategoryID = categoryId,
                    Calorie = calorie,
                    PicturePath = path
                });
                EnableElements();
                db.SaveChanges();
                ClearTextboxes();
                ShowData();
            }
            else
            {
                var food = TakeFoodData();

                TakeUserInput(out string foodName, out int categoryId, out double calorie, out string path);

                food.Name = foodName;
                food.CategoryID = categoryId;
                food.Calorie = calorie;
                food.PicturePath = path;

                db.SaveChanges();
                ClearTextboxes();
                EnableElements();
                ShowData();
            }
        }

        #endregion

        #region Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add" || btnAdd.Text == "Ekle")
                AddorEditFood();
            else
            {
                var food = TakeFoodData();
                food.Name = txtbFoodName.Text.Trim();
                food.CategoryID = cbCategory.SelectedIndex + 1;
                food.Calorie = (double)nudCalorie.Value;
                food.PicturePath = txtbPicturePath.Text;
                db.SaveChanges();
                ClearTextboxes();
                EnableElements();
                ShowData();
                btnAdd.Text = "Add";
                btnRemove.Text = "Remove";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (btnRemove.Text == "Sil" || btnRemove.Text == "Remove")
            {
                var food = TakeFoodData();

                db.Foods.Remove(food);
                db.SaveChanges();
                ClearTextboxes();
                ShowData();
            }
            else
            {
                ClearTextboxes();
                EnableElements();
                ShowData();
                btnAdd.Text = "Add";
                btnRemove.Text = "Remove";
            }
        }

        private void btnOpenFileExplorer_Click(object sender, EventArgs e)
        {
            string path = "";
            var result = ofdFileExplorer.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = ofdFileExplorer.FileName;
            }

            txtbPicturePath.Text = path;
        }

        private void txtbPicturePath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtbPicturePath.Text != "")
                    pbPicturePreview.Image = Image.FromFile(txtbPicturePath.Text);
            }
            catch
            {
                MessageBox.Show("Resim boyutu çok büyük tekrar deneyiniz");
                return;
            }

            if (CheckInputs())
                EnableElements();
        }

        private void dgvFoodList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAdd.Enabled = false;
            dgvFoodList.Enabled = false;

            if (TakeLanguageData() == "TR")
            {
                btnAdd.Text = "Değiştir";
                btnRemove.Text = "İptal";
            }
            else
            {
                btnAdd.Text = "Edit";
                btnRemove.Text = "Cancel";
            }

            Food food = TakeFoodData();

            txtbFoodName.Text = food.Name;
            cbCategory.SelectedIndex = food.CategoryID - 1;
            nudCalorie.Value = (decimal)food.Calorie;
            if (food.PicturePath != "" || food.PicturePath != null)
            {
                txtbPicturePath.Text = food.PicturePath;
            }
            else
                return;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string language = TakeLanguageData();
            string theme = TakeThemeData();
            MainForm frm = new MainForm(language, _userId);
            frm.Show();
            this.Hide();
        }

        #endregion

        public bool CheckInputs()
        {
            if (txtbFoodName.Text == "" || txtbPicturePath.Text == "")
                return false;
            else
                return true;
        }

        private void pbPicturePreview_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (CheckInputs())
                EnableElements();
        }

        private void nudCalorie_ValueChanged(object sender, EventArgs e)
        {
            if (CheckInputs())
                EnableElements();
        }

        private void txtbFoodName_TextChanged(object sender, EventArgs e)
        {
            if (CheckInputs())
                EnableElements();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckInputs())
                EnableElements();
        }
    }
}
