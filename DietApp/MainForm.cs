using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DietApp.Classes;

namespace DietApp
{
    public partial class MainForm : Form
    {
        AppDbContext db = new AppDbContext();
        private readonly int _userId;

        public MainForm(string language, int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadData();
            LoadCmbData();
            ChangeLanguage(language);
        }

        #region Methods

        private void ChangeLanguage(string language)
        {
            if (language == "TR")
            {
                msMenus.Text = "Menüler";
                msiReport.Text = "Günlük Rapor";
                msiLogOut.Text = "Çıkış Yap";
                msSettings.Text = "Ayarlar";
                msiLang.Text = "Diller";
                msiEng.Text = "İngilizce";
                msiTr.Text = "Türkçe";
                btnAddDiet.Text = "Öğün Ekle";
                btnDeleteDiet.Text = "Öğün Kaldır";
                gbDiet.Text = "Diyet";
                lblMeal.Text = "Öğün";
                lblFood.Text = "Yiyecek";
                lblAmount.Text = "Miktar";
                lblDate.Text = "Tarih";
                lblFoodPic.Text = "Yiyecek";
                lblDietList.Text = "Diet List";
            }
            else
            {
                msMenus.Text = "Menus";
                msiReport.Text = "Daily Report";
                msiLogOut.Text = "Logout";
                msSettings.Text = "Settings";
                msiLang.Text = "Language";
                msiEng.Text = "English";
                msiTr.Text = "Turkish";
                btnAddDiet.Text = "Add Diet";
                btnDeleteDiet.Text = "Delete Diet";
                gbDiet.Text = "Diet";
                lblMeal.Text = "Meal";
                lblFood.Text = "Food";
                lblAmount.Text = "Amount";
                lblDate.Text = "Date";
                lblFoodPic.Text = "Food";
                lblDietList.Text = "Diet List";
            }
        }

        private string TakeLanguageData()
        {
            string language = "EN";

            if (btnAddDiet.Text == "Öğün Ekle")
            {
                language = "TR";
            }
            else
            {
                language = "EN";
            }

            return language;
        }

        private void TakeUserInput(out Food food, out double amount, out DateTime date, out Meal meal)
        {
            int foodId = cbFood.SelectedIndex + 1;
            food = db.Foods.FirstOrDefault(f => f.ID == foodId);
            amount = (double)nudAmount.Value;
            date = dtpDate.Value;
            switch (cbMeal.SelectedIndex)
            {
                case 0:
                    meal = Meal.Breakfast;
                    break;
                case 1:
                    meal = Meal.Lunch;
                    break;
                case 2:
                    meal = Meal.Dinner;
                    break;
                case 3:
                    meal = Meal.Snack;
                    break;
                default:
                    meal = Meal.Cheating;
                    break;
            }
        }



        private void ClearBoxes()
        {
            dtpDate.Value = DateTime.Now;
            nudAmount.Value = 0;
        }
        private void LoadCmbData()
        {
            #region Misc.

            cbFood.DataSource = db.Foods.ToList();
            Meal meal1 = Meal.Breakfast;
            Meal meal2 = Meal.Lunch;
            Meal meal3 = Meal.Dinner;
            Meal meal4 = Meal.Snack;
            Meal meal5 = Meal.Cheating;
            cbMeal.Items.Add(meal1);
            cbMeal.Items.Add(meal2);
            cbMeal.Items.Add(meal3);
            cbMeal.Items.Add(meal4);
            cbMeal.Items.Add(meal5);
            cbMeal.SelectedIndex = 0;

            #endregion
        }

        private void LoadData()
        {
            var user = db.Users.FirstOrDefault(u => u.ID == _userId);
            dgvDietList.DataSource = db.DietFoods.Select(df => new
            {
                df.Diet.ID,
                df.Diet.Date,
                df.Diet.Meal,
                df.Food.Name,
                df.Diet.TotalCalories
            })
            .ToList();
        }

        #endregion

        #region Eventss

        private void btnDeleteDiet_Click(object sender, EventArgs e)
        {
            int dietId = (int)dgvDietList.CurrentRow.Cells[0].Value;
            Diet diet = db.Diets.FirstOrDefault(f => f.ID == dietId);
            db.Diets.Remove(diet);
            db.SaveChanges();
            LoadData();
            ClearBoxes();
        }

        private void btnAddDiet_Click(object sender, EventArgs e)
        {
            Food food;
            Meal meal;
            double amount;
            DateTime date;
            string language = TakeLanguageData();

            TakeUserInput(out food, out amount, out date, out meal);

            var user = db.Users.FirstOrDefault(u => u.ID == _userId);
            double totalcal = CalculateTotalCal(amount, food);

            if (date > DateTime.Now && language=="TR") 
            {
                MessageBox.Show($"Lütfen {DateTime.Now}'dan büyük tarih girmeyiniz");
                return;
            }
            else if (date > DateTime.Now && language == "EN")
            {
                MessageBox.Show($"Please do not enter a value greater than {DateTime.Now}");
                return;
            }
            var newdiet = db.Diets.Add(new Diet()
            {
                UserID = _userId,
                TotalCalories = totalcal,
                Date = date,
                Meal = meal
            });

            var dietFood = db.DietFoods.Add(new DietFood()
            {
                FoodID = food.ID,
                DietID = newdiet.ID
            });

            newdiet.DietFoodID = dietFood.ID;

            user.Diets.Add(newdiet);
            db.SaveChanges();
            ClearBoxes();
            LoadData();

        }

        private double CalculateTotalCal(double amount, Food food)
        {
            return (food.Calorie / 100) * amount;
        }

        #endregion

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int foodId = cbFood.SelectedIndex + 1;
                Food food = db.Foods.FirstOrDefault(f => f.ID == foodId);

                if (food.PicturePath != "" || food.PicturePath != null)
                {
                    string path = food.PicturePath;
                    if (path != null)
                        pbFoodPic.Image = Image.FromFile(path);
                }

            }
            // silinecekk
            catch (Exception)
            {
                MessageBox.Show("Resim boyutu çok büyük");
                return;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void msiLogOut_Click(object sender, EventArgs e)
        {
            string language = TakeLanguageData();
            string theme = TakeThemeData();

            LoginForm frm = new LoginForm(language, theme);
            frm.Show();
            this.Hide();
        }

        private string TakeThemeData()
        {
            return "EN";
        }

        private void dgvDietList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            db.SaveChanges();
        }

        private void msiTr_Click(object sender, EventArgs e)
        {
            string language = TakeLanguageData();
            ChangeLanguage(language);
        }

        private void msiEng_Click(object sender, EventArgs e)
        {
            string language = TakeLanguageData();
            ChangeLanguage(language);
        }
    }
}
