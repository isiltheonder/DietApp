using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp
{
    public partial class LoginForm : Form
    {
        Classes.AppDbContext db = new Classes.AppDbContext();

        public LoginForm(string language, string theme)
        {
            InitializeComponent();
            ChangeLanguage(language);
        }

        #region Events

        private void lblRegister_Click(object sender, EventArgs e)
        {
            GoToForm("Register");
            ClearTextboxes();
        }

        private void lblForget_Click(object sender, EventArgs e)
        {
            GoToForm("Pass");
            ClearTextboxes();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLoginInfo();
            ClearTextboxes();
        }

        private void msiTr_Click(object sender, EventArgs e)
        {
            ChangeLanguage("TR");
        }

        private void msiEng_Click(object sender, EventArgs e)
        {
            ChangeLanguage("EN");
        }

        private void msiDark_Click(object sender, EventArgs e)
        {

        }

        private void msiLight_Click(object sender, EventArgs e)
        {

        }
        private void msiContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please let us know if you have any questions, want to comment or want to know more about our company.\r\nContact Information : Ankara Teknoloji Geliştirme Bölgesi, G Blok, Üniversiteler Mahallesi Beytepe Lodumlu Köy Yolu Caddesi No:91, 06800 Bilkent Çankaya / ANKARA​​\r\nÇankaya / Ankara - Türkiye\r\nPhone : 444 33 30", "Contact!!", MessageBoxButtons.OK);
        }

        private void msiLicence_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilge Adam Boost Star Programmer Development Program ");

        }

        private void msiAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("As a result of the work that lasted for 2.5 years and about 130 people worked at different times, we, as Fittle, reached a serious audience in a short time. :)\r\n\r\nWhat are we doing ?\r\n\r\nWe call it everybody's diet! : We offer diet lists suitable for users' needs and characteristics.\r\n\r\nWe are following! : We evaluate how much and how the given diet lists are applied according to the incoming data, and we send warnings to users where necessary.\r\n\r\nWe're not here to sit!  : We provide exercise plans to increase physical activity.\r\n\r\nWe meet! : We offer the chance to communicate with other users with the same goals and experts registered with Fittle.\r\n\r\nWe inform! : We aim to provide the most accurate information by including expert posts(articles, videos).\r\n\r\nWe use technology! : We make diet lists and dietitians easily accessible with our iphone and android applications.\r\n\r\nWe are socializing! : We bring individual efforts for a balanced and healthy diet to the social environment, making it fun and making it easier to reach the goal.", "Fittle",MessageBoxButtons.OK);
        }

        #endregion

        #region Methods

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
                //lblGreeting.Text = "FITTLE'a Hoşgeldiniz";
                lblDesc.Text = "Bu uygulama, günlük kalori indeksinizi takip ederek, gün boyunca egzersiz aktivitenizi takip ederek ve hidrasyon seviyenizi takip ederek diyetinizi daha kolay yönetmenize yardımcı olur.";
                gbLogin.Text = "Oturum Açma";
                lblEmail.Text = "Email";
                lblPass.Text = "Şifre";
                btnLogin.Text = "Oturum Aç";
                lblForget.Text = "Şifremi Unuttum";
                lblRegister.Text = "Kayıt Oluştur";
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
                //lblGreeting.Text = "Welcome to FITTLE";
                lblDesc.Text = "This app helps you managing your diet easier by tracking your calorie index per day, tracking your exercise activity throught the day, and tracking your hydration level.";
                gbLogin.Text = "Login";
                lblEmail.Text = "Email";
                lblPass.Text = "Password";
                btnLogin.Text = "Login";
                lblForget.Text = "Forgot My Password";
                lblRegister.Text = "Register";
            }
        }

        private void ClearTextboxes()
        {
            txtbEmail.Clear();
            txtbPass.Clear();
        }

        private void CheckLoginInfo()
        {
            string email = txtbEmail.Text.Trim();
            string password = txtbPass.Text.Trim();
            string language = TakeLanguageData();
            string theme = TakeThemeData();

            if ((email == "" || password == "") && language == "TR")
            {
                MessageBox.Show("Email veya şifre boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if ((email == "" || password == "") && language == "EN")
            {
                MessageBox.Show("Email and password fields cannot be empty.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            int userId = 0;

            if (user != null)
            {
                userId = user.ID;

                if (user.IsAdmin == false)
                {
                    MainForm frm = new MainForm(language, userId);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    var result = MessageBox.Show("Do you want to open the food list?", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        AdminForm frm = new AdminForm(language, theme, userId);
                        frm.Show();
                        this.Hide();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MainForm frm = new MainForm(language, userId);
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            else if (user == null && language == "TR")
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextboxes();
                return;
            }
            else
            {
                MessageBox.Show("User cannot be found.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextboxes();
                return;
            }
        }

        private string TakeThemeData()
        {
            return "EN";
        }

        private void GoToForm(string formName)
        {
            string language = TakeLanguageData();
            string theme = TakeThemeData();

            if (formName == "Register")
            {
                RegisterForm frm = new RegisterForm(language);
                frm.Show();
                this.Hide();
            }
            else if (formName == "Pass")
            {
                PassForm frm = new PassForm(language, theme);
                frm.Show();
                this.Hide();
            }
        }

        private string TakeLanguageData()
        {
            string language = "EN";

            if (btnLogin.Text == "Oturum Aç")
            {
                language = "TR";
            }
            else
            {
                language = "EN";
            }

            return language;
        }

        #endregion

        
    }
}
