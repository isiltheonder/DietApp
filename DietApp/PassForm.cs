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
    public partial class PassForm : Form
    {
        Classes.AppDbContext db = new Classes.AppDbContext();

        public PassForm(string language, string theme)
        {
            InitializeComponent();
            ChangeLanguage(language);
        }

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
                btnRecover.Text = "Göster";
                btnCancel.Text = "Vazgeç";
                gbRecovery.Text = "Şifre Kurtarma";
                lblEmail.Text = "Email";
                lblAnswer.Text = "Sorunun Cevabı";
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
                btnRecover.Text = "Recover";
                btnCancel.Text = "Cancel";
                gbRecovery.Text = "Recovery";
                lblEmail.Text = "Email";
                lblAnswer.Text = "Answer of the Question";
            }
        }

        private string TakeLanguageData()
        {
            string language = "EN";

            if (btnRecover.Text == "Göster")
            {
                language = "TR";
            }
            else
            {
                language = "EN";
            }

            return language;
        }

        private string TakeThemeData()
        {
            return "EN";
        }

        private void ClearTextboxes()
        {
            txtbEmail.Clear();
            txtbAnswer.Clear();
            lblOutput.Text = "";
        }

        #endregion

        #region Events

        private void msiTr_Click(object sender, EventArgs e)
        {
            ChangeLanguage("TR");
        }

        private void msiEng_Click(object sender, EventArgs e)
        {
            ChangeLanguage("EN");
        }

        private void txtbEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtbEmail.Text.Trim();
            var user = db.Users.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                lblOutput.Text = user.SecurityQuestion.ToString();
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            string email = txtbEmail.Text.Trim();
            var user = db.Users.FirstOrDefault(u => u.Email == email);
            string answer = txtbAnswer.Text.Trim();
            string language = TakeLanguageData();

            user = db.Users.FirstOrDefault(u => u.SecurityAnswer == answer);

            if (user != null && language == "TR")
            {
                string password = user.Password.ToString();
                lblOutput.Text = "Şifreniz: " + password;
            }
            else if (user != null && language == "EN")
            {
                string password = user.Password.ToString();
                lblOutput.Text = "Your Password: " + password;
            }
            else if (user == null && language == "TR")
            {
                MessageBox.Show("Cevabınız yanlış.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextboxes();
                return;
            }
            else if (user == null && language == "EN")
            {
                MessageBox.Show("Your answer is not valid.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextboxes();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string language = TakeLanguageData();
            string theme = TakeThemeData();
            LoginForm frm = new LoginForm(language, theme);
            frm.Show();
            this.Hide();
        }

        private void PassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
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
            MessageBox.Show("As a result of the work that lasted for 2.5 years and about 130 people worked at different times, we, as Fittle, reached a serious audience in a short time. :)\r\n\r\nWhat are we doing ?\r\n\r\nWe call it everybody's diet! : We offer diet lists suitable for users' needs and characteristics.\r\n\r\nWe are following! : We evaluate how much and how the given diet lists are applied according to the incoming data, and we send warnings to users where necessary.\r\n\r\nWe're not here to sit!  : We provide exercise plans to increase physical activity.\r\n\r\nWe meet! : We offer the chance to communicate with other users with the same goals and experts registered with Fittle.\r\n\r\nWe inform! : We aim to provide the most accurate information by including expert posts(articles, videos).\r\n\r\nWe use technology! : We make diet lists and dietitians easily accessible with our iphone and android applications.\r\n\r\nWe are socializing! : We bring individual efforts for a balanced and healthy diet to the social environment, making it fun and making it easier to reach the goal.", "Fittle", MessageBoxButtons.OK);
        }
        #endregion


    }
}
