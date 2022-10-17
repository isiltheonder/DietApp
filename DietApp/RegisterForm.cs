using DietApp.Classes;
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
    public partial class RegisterForm : Form
    {
         Classes.AppDbContext db = new Classes.AppDbContext();

        public RegisterForm(string language)
        {
            InitializeComponent();
            ChangeLanguage(language);
            SelectComboboxItem();
        }

        #region Methods

        private void SelectComboboxItem()
        {
            cbSecurity.SelectedIndex = 0;
        }

        private void ChangeLanguage(string language)
        {
            if (language == "TR")
            {
                msSettings.Text = "Ayarlar";
                msiLang.Text = "Diller";
                msiEng.Text = "İngilizce";
                msiTr.Text = "Türkçe";
                btnRegister.Text = "Kayıt Ol";
                btnCancel.Text = "Vazgeç";
                gbRegistry.Text = "Kayıt";
                gbPersonInfo.Text = "Kişisel Bilgiler";
                lblGreeting.Text = "Hesap Oluştur";
                lblEmail.Text = "Email *";
                lblPass.Text = "Şifre *";
                lblSecurity.Text = "Güvenlik Sorusu *";
                lblAnswer.Text = "Sorunun Cevabı *";
                lblFirstName.Text = "İsim";
                lblLastName.Text = "Soyisim";
                lblAge.Text = "Yaş *";
                lblWeight.Text = "Ağırlık *";
                lblHeight.Text = "Boy *";
                lblGender.Text = "Cinsiyet *";
                rbFemale.Text = "Kadın";
                rbMale.Text = "Erkek";
            }
            else
            {
                msSettings.Text = "Settings";
                msiLang.Text = "Language";
                msiEng.Text = "English";
                msiTr.Text = "Turkish";
                btnRegister.Text = "Register";
                btnCancel.Text = "Cancel";
                gbRegistry.Text = "Registry";
                gbPersonInfo.Text = "Information";
                lblGreeting.Text = "Create New Account";
                lblEmail.Text = "Email *";
                lblPass.Text = "Password *";
                lblSecurity.Text = "Security Question *";
                lblAnswer.Text = "Answer *";
                lblFirstName.Text = "First Name";
                lblLastName.Text = "Last Name";
                lblAge.Text = "Age *";
                lblWeight.Text = "Weight *";
                lblHeight.Text = "Height *";
                lblGender.Text = "Gender *";
                rbFemale.Text = "Male";
                rbMale.Text = "Female";
            }
        }

        private string TakeLanguageData()
        {
            string language = "EN";

            if (btnRegister.Text == "Kayıt Ol")
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
            txtbPass.Clear();
            txtbAnswer.Clear();
            cbSecurity.SelectedIndex = 0;
            txtbFirstName.Clear();
            txtbLastName.Clear();
            nudAge.Value = 0;
            nudHeight.Value = 0;
            nudWeight.Value = 0;
            rbFemale.Checked = false;
            rbMale.Checked = false;
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Helper.PasswordAdvisor pa = new Helper.PasswordAdvisor();
            string language = TakeLanguageData();
            string email = txtbEmail.Text.Trim();
            string password = txtbPass.Text.Trim();

            if ((txtbEmail.Text == "") || (password == "") || (txtbAnswer.Text == "") || (rbMale.Checked == false && rbFemale.Checked == false) && language == "TR")
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextboxes();
                return;
            }
            else if ((txtbEmail.Text == "") || (password == "") || (txtbAnswer.Text == "") || (rbMale.Checked == false && rbFemale.Checked == false) && language == "EN")
            {
                MessageBox.Show("Please enter required information.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextboxes();
                return;
            }
            else
            {
                if ((pa.PasswordChecker(password) == false || !email.Contains('@') || !email.Contains(".com")) && language == "TR")
                {
                    MessageBox.Show("Hatalı giriş yaptınız.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Şifre: \n\r- Minimum 8 karakter\n\r- En az 1 tane büyük harf\n\r- En az 1 tane rakam\n\r- En az 1 tane simge içermelidir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearTextboxes();
                    return;
                }
                else if ((pa.PasswordChecker(password) == false || !email.Contains('@') || !email.Contains(".com")) && language == "EN")
                {
                    MessageBox.Show("Invalid entry detected.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Password: \n\r- Minimum 8 characters\n\r- At least 1 uppercase\n\r- At least 1 number\n\r- At least 1 special character", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearTextboxes();
                    return;
                }
                else if(pa.PasswordChecker(password) == false && language == "TR")
                {
                    MessageBox.Show("Şifre: \n\r - Minimum 8 karakter\n\r - En az 1 tane büyük harf\n\r - En az 1 tane rakam\n\r - En az 1 tane simge içermelidir.");
                    ClearTextboxes();
                    return;
                }
                else if (pa.PasswordChecker(password) == false && language == "EN")
                {
                    MessageBox.Show("Password: \n\r- Minimum 8 characters\n\r- At least 1 uppercase\n\r- At least 1 number\n\r- At least 1 special character");
                    ClearTextboxes();
                    return;
                }
                else if (pa.PasswordChecker(password) == true && email.Contains('@') && email.Contains(".com") && language == "TR")
                {
                    Gender gender = Gender.Male;

                    if (rbFemale.Checked)
                    {
                        gender = Gender.Female;
                    }
                    else
                    {
                        gender = Gender.Male;
                    }

                    string answer = txtbAnswer.Text.Trim();
                    string question = cbSecurity.SelectedItem.ToString();
                    string firstName = txtbFirstName.Text.Trim();
                    string lastName = txtbLastName.Text.Trim();
                    int age = (int)nudAge.Value;
                    double weight = (double)nudWeight.Value;
                    double height = (double)nudHeight.Value;

                    var user = db.Users.Add(new Classes.User()
                    {
                        Email = email,
                        Password = password,
                        SecurityAnswer = answer,
                        SecurityQuestion = question,
                        IsAdmin = false
                    });

                    int userId = user.ID;

                    var userDetail = db.UserDetails.Add(new Classes.UserDetail()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Weight = weight,
                        Height = height,
                        Gender = gender,
                        UserID = userId
                    });

                    int userDetailId = userDetail.ID;

                    user.UserDetailID = userDetailId;

                    MessageBox.Show("Hesabınız oluşturulmuştur.");

                    db.SaveChanges();
                    ClearTextboxes();
                }
                else if (pa.PasswordChecker(password) == true && email.Contains('@') && email.Contains(".com") && language == "EN")
                {
                    Gender gender = Gender.Male;

                    if (rbFemale.Checked)
                    {
                        gender = Gender.Female;
                    }
                    else
                    {
                        gender = Gender.Male;
                    }

                    string answer = txtbAnswer.Text.Trim();
                    string question = cbSecurity.SelectedItem.ToString();
                    string firstName = txtbFirstName.Text.Trim();
                    string lastName = txtbLastName.Text.Trim();
                    int age = (int)nudAge.Value;
                    double weight = (double)nudWeight.Value;
                    double height = (double)nudHeight.Value;

                    var user = db.Users.Add(new Classes.User()
                    {
                        Email = email,
                        Password = password,
                        SecurityAnswer = answer,
                        SecurityQuestion = question,
                        IsAdmin = false
                    });

                    int userId = user.ID;

                    var userDetail = db.UserDetails.Add(new Classes.UserDetail()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Weight = weight,
                        Height = height,
                        Gender = gender,
                        UserID = userId
                    });

                    int userDetailId = userDetail.ID;

                    user.UserDetailID = userDetailId;

                    MessageBox.Show("Your account is created.");

                    db.SaveChanges();
                    ClearTextboxes();
                }
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string language = TakeLanguageData();
            string theme = TakeThemeData();

            LoginForm frm = new LoginForm(language, theme);
            frm.Show();
            this.Hide();
        }

        #endregion
    }
}
