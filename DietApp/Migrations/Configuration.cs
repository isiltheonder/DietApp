namespace DietApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DietApp.Classes.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DietApp.Classes.AppDbContext db)
        {
            string currentDir = Environment.CurrentDirectory;

            if (!db.Users.Any())
            {
                string passwordAdmin = "Admin123*";
                string password1 = "Burumal96*";
                string password2 = "Ison1994+";
                string password3 = "Burcinilkerr123/";
                string password4 = "Fatihbag96-";

                #region Users

                db.Users.Add(new Classes.User()
                {
                    Email = "admin@mail.com",
                    Password = passwordAdmin,
                    IsAdmin = true,
                    SecurityQuestion = "Admin",
                    SecurityAnswer = "Admin"
                });
                db.Users.Add(new Classes.User()
                {
                    Email = "burumalkan1996@gmail.com",
                    Password = password1,
                    IsAdmin = true,
                    SecurityQuestion = "Admin",
                    SecurityAnswer = "Admin"
                });
                db.Users.Add(new Classes.User()
                {
                    Email = "isilonder94@gmail.com",
                    Password = password2,
                    IsAdmin = true,
                    SecurityQuestion = "Admin",
                    SecurityAnswer = "Admin"
                });
                db.Users.Add(new Classes.User()
                {
                    Email = "burcinilkerr@gmail.com",
                    Password = password3,
                    IsAdmin = true,
                    SecurityQuestion = "Admin",
                    SecurityAnswer = "Admin"
                });
                db.Users.Add(new Classes.User()
                {
                    Email = "sunthewitcher@gmail.com",
                    Password = password4,
                    IsAdmin = true,
                    SecurityQuestion = "Admin",
                    SecurityAnswer = "Admin"
                });
            }

            #endregion

            #region Categories

            if (!db.Categories.Any())
            {
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Yemekler"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Deniz Mahsülleri"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Sebzeler"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Meyveler"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Et Ürünleri"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Süt Ürünleri"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Yağlar"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Kuru Bakliyatlar"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Ekmek Grubu Besinler"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Kuruyemiş"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "Tatlılar"
                });
                db.Categories.Add(new Classes.Category()
                {
                    Description = "İçecekler"
                });
            }

            #endregion

            #region Foods

            if (!db.Foods.Any())
            {

                db.Foods.Add(new Classes.Food()
                {
                    Name = "Fırında Kuru Fasulye",
                    Calorie = 94d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\1_Fırında Kuru Fasulye.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Havuçlu Bezelye",
                    Calorie = 48d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\2_Havuçlu Bezelye.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Humus",
                    Calorie = 177d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\3_Humus.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Pişmiş Enginar",
                    Calorie = 53d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\4_Pişmiş Enginar.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Hünkar Beğendi",
                    Calorie = 174d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\5_Hünkar Beğendi.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kıymalı Pide",
                    Calorie = 186d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\6_Kıymalı Pide.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Patates Püresi",
                    Calorie = 83d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\7_Patates Püresi.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Pişmiş Kereviz",
                    Calorie = 26d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\8_Pişmiş Kereviz.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Patates Salatası",
                    Calorie = 143d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\9_Patates Salatası.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Adana Kebap",
                    Calorie = 240d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\10_Adana Kebap.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Bulgur Pilavı",
                    Calorie = 215d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\11_Bulgur Pilavı.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Sucuklu Kaşarlı Pide",
                    Calorie = 305d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\12_Sucuklu Kaşarlı Pide.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Lazanya",
                    Calorie = 132d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\13_Lazanya.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Tereyağlı Pirinç Pilavı",
                    Calorie = 185d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\14_Tereyağlı Pirinç Pilavı.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kuzu Tandır",
                    Calorie = 150d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\15_Kuzu Tandır.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kıymalı Makarna",
                    Calorie = 130d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\16_Kıymalı Makarna.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Karışık Pizza",
                    Calorie = 185d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\17_Karışık Pizza.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Zeytinyağlı Yaprak Sarma",
                    Calorie = 125d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\18_Zeytinyağlı Yaprakj Sarma.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Peynirli Makarna",
                    Calorie = 140d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\19_Peynirlki Makarna.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Esmer Pirinç",
                    Calorie = 362d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\20_Esmer Pirinç.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Tavuklu Salata",
                    Calorie = 48d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\21_Tavuklu Salata.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kıymalı Dolma",
                    Calorie = 80d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\22_Kıymalı Dolma.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Zeytinyağlı Taze Fasulye",
                    Calorie = 50d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\23_Zeytinyağlı Taze Fasulye.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Fırında Tavuk",
                    Calorie = 138d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\24_Fırında Tavul.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Karnıyarık",
                    Calorie = 134d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\25_Karnıyarık.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Zeytinyağlı Dolma",
                    Calorie = 175d,
                    CategoryID = 1,
                    PicturePath = currentDir + @"\..\..\Resources\26_Zeytinyağlı Dolma.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Ahtapot",
                    Calorie = 164d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\27_Ahtapot.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Karides",
                    Calorie = 100d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\28_Karides.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kalamar Tava",
                    Calorie = 205d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\29_Kalamar Tava.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Midye Dolma",
                    Calorie = 85d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\30_Midye Dolma.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Hamsi Tava",
                    Calorie = 150d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\31_Hamsi Tava.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Somon",
                    Calorie = 180d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\32_Somon.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Palamut",
                    Calorie = 135d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\33_Palamut.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Levrek",
                    Calorie = 95d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\34_Levrek.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Çupra",
                    Calorie = 110d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\35_Çupra.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "İstavrit",
                    Calorie = 200d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\36_İstavrit.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Barbun",
                    Calorie = 125d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\37_Barbun.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Tekir",
                    Calorie = 115d,
                    CategoryID = 2,
                    PicturePath = currentDir + @"\..\..\Resources\38_Tekir.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Taze Mısır",
                    Calorie = 96d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\39_Taze Mısır.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Bezelye",
                    Calorie = 84d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\40_Bezelye.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Haşlanmış Patates",
                    Calorie = 76d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\41_Haşlanmış Patates.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Pırasa",
                    Calorie = 42d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\42_Pırasa.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Pancar",
                    Calorie = 43d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\43_Pancar.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Havuç",
                    Calorie = 42d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\44_Havuç.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kereviz",
                    Calorie = 40d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\45_Kereviz.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kuru Soğan",
                    Calorie = 38d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\46_Kuru Soğan.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Fasulye",
                    Calorie = 32d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\47_Fasülye.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Mantar",
                    Calorie = 28d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\48_Mantar.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Karnabahar",
                    Calorie = 27d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\49_Karnabahar.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Ispanak",
                    Calorie = 26d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\50_Ispanak.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Lahana",
                    Calorie = 24d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\51_Lahana.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Biber",
                    Calorie = 22d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\52_Biber.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Domates",
                    Calorie = 22d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\53_Domates.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Turp",
                    Calorie = 19d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\54_Turp.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Salatalık",
                    Calorie = 15d,
                    CategoryID = 3,
                    PicturePath = currentDir + @"\..\..\Resources\55_Salatalık.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Avokado",
                    Calorie = 167d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\56_Avokado.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Muz",
                    Calorie = 85d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\57_Muz.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "İncir",
                    Calorie = 80d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\58_İncir.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Erik",
                    Calorie = 75d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\59_Erik.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kiraz",
                    Calorie = 70d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\60_Kiraz.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Üzüm",
                    Calorie = 67d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\61_Üzüm.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Armut",
                    Calorie = 61d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\62_Armut.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Elma",
                    Calorie = 58d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\63_Elma.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Vişne",
                    Calorie = 58d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\64_Vişne.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kayısı",
                    Calorie = 51d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\65_Kayısı.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Portakal",
                    Calorie = 49d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\66_Portakal.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Mandalina",
                    Calorie = 46d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\67_Mandalina.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Şeftali",
                    Calorie = 38d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\68_Şeftali.jpg.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Çilek",
                    Calorie = 37d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\69_Çilek.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kavun",
                    Calorie = 33d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\70_Kavun.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Limon",
                    Calorie = 27d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\71_Limon.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Karpuz",
                    Calorie = 26d,
                    CategoryID = 4,
                    PicturePath = currentDir + @"\..\..\Resources\72_Karpuz.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Domuz",
                    Calorie = 513d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\73_Domuz.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Ördek",
                    Calorie = 404d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\74_Ördek.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Yağlı Koyun Eti",
                    Calorie = 310d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\75_Yağlı Koyun Eti.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Yağlı Sığır Eti",
                    Calorie = 301d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\76_Yağlı Sığır Eti.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kuzu Pirzola",
                    Calorie = 263d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\77_Kuzu Pirzola.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Koyun Eti",
                    Calorie = 246d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\78_Koyun Eti.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Az Yağlı Sığır Eti",
                    Calorie = 225d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\79_Az Yağlı Sığır Eti.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Dana Eti",
                    Calorie = 223d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\80_Dana Eti.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Tavuk Eti",
                    Calorie = 215d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\81_Tavuk Eti.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Hindi",
                    Calorie = 160d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\82_Hindi.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Biftek",
                    Calorie = 156d,
                    CategoryID = 5,
                    PicturePath = currentDir + @"\..\..\Resources\83_Biftek.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kaşar Peyniri",
                    Calorie = 404d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\84_Kaşar Peyniri.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Krem Peynir",
                    Calorie = 349d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\85_Krem Peynir.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Dil Peyniri",
                    Calorie = 330d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\86_Dil Peyniri.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Beyaz Peynir",
                    Calorie = 289d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\87_Beyaz Peynir.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Tulum Peyniri",
                    Calorie = 257d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\89_Tulum Peyniri.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Krema",
                    Calorie = 134d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\90_Krema.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Koyun Sütü",
                    Calorie = 108d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\91_Koyun Sütü.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Lor Peyniri",
                    Calorie = 90d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\92_Lor Peyniri.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Yoğurt",
                    Calorie = 62d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\93_Yoğurt.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "İnek Sütü",
                    Calorie = 61d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\94_İnek Sütü.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Ayran",
                    Calorie = 38d,
                    CategoryID = 6,
                    PicturePath = currentDir + @"\..\..\Resources\95_Ayran.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Zeytin Yağı",
                    Calorie = 88d,
                    CategoryID = 7,
                    PicturePath = currentDir + @"\..\..\Resources\96_Zeytin Yağı.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "İç Yağı",
                    Calorie = 75d,
                    CategoryID = 7,
                    PicturePath = currentDir + @"\..\..\Resources\97_İç Yağı.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Margarin",
                    Calorie = 71d,
                    CategoryID = 7,
                    PicturePath = currentDir + @"\..\..\Resources\98_Margarin.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Tereyağı",
                    Calorie = 71d,
                    CategoryID = 7,
                    PicturePath = currentDir + @"\..\..\Resources\99_Tereyağı.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Mayonez",
                    Calorie = 39d,
                    CategoryID = 7,
                    PicturePath = currentDir + @"\..\..\Resources\100_Mayonez.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Hardal",
                    Calorie = 14d,
                    CategoryID = 7,
                    PicturePath = currentDir + @"\..\..\Resources\101_Hardal.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Ketçap",
                    Calorie = 10d,
                    CategoryID = 7,
                    PicturePath = currentDir + @"\..\..\Resources\102_Ketçap.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Pirinç",
                    Calorie = 363d,
                    CategoryID = 8,
                    PicturePath = currentDir + @"\..\..\Resources\103_Pirinç.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Nohut",
                    Calorie = 360d,
                    CategoryID = 8,
                    PicturePath = currentDir + @"\..\..\Resources\104_Nohut.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Fasulye",
                    Calorie = 340d,
                    CategoryID = 8,
                    PicturePath = currentDir + @"\..\..\Resources\105_Fasulye.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Mercimek",
                    Calorie = 340d,
                    CategoryID = 8,
                    PicturePath = currentDir + @"\..\..\Resources\106_Mercimek.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Talaş Böreği",
                    Calorie = 615d,
                    CategoryID = 9,
                    PicturePath = currentDir + @"\..\..\Resources\107_Talaş Böreği.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Mısır Unu",
                    Calorie = 368d,
                    CategoryID = 9,
                    PicturePath = currentDir + @"\..\..\Resources\108_Mısır Unu.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Beyaz Un",
                    Calorie = 365d,
                    CategoryID = 9,
                    PicturePath = currentDir + @"\..\..\Resources\109_Beyaz Un.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Makarna",
                    Calorie = 307d,
                    CategoryID = 9,
                    PicturePath = currentDir + @"\..\..\Resources\110_Makarna.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Yufka",
                    Calorie = 257d,
                    CategoryID = 9,
                    PicturePath = currentDir + @"\..\..\Resources\111_Yufka.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Beyaz Ekmek",
                    Calorie = 69d,
                    CategoryID = 9,
                    PicturePath = currentDir + @"\..\..\Resources\112_Beyaz Ekmek.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Çavdar Ekmeği",
                    Calorie = 60d,
                    CategoryID = 9,
                    PicturePath = currentDir + @"\..\..\Resources\113_Çavdar Ekmeği.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kepek Ekmeği",
                    Calorie = 53d,
                    CategoryID = 9,
                    PicturePath = currentDir + @"\..\..\Resources\114_Kepek Ekmeği.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Ceviz",
                    Calorie = 651d,
                    CategoryID = 10,
                    PicturePath = currentDir + @"\..\..\Resources\116_Ceviz.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Fındık",
                    Calorie = 634d,
                    CategoryID = 10,
                    PicturePath = currentDir + @"\..\..\Resources\117_Fındık.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Badem",
                    Calorie = 598d,
                    CategoryID = 10,
                    PicturePath = currentDir + @"\..\..\Resources\118_Badem.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Antep Fıstığı",
                    Calorie = 594d,
                    CategoryID = 10,
                    PicturePath = currentDir + @"\..\..\Resources\119_Antep Fıstığı.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Yer Fıstığı",
                    Calorie = 582d,
                    CategoryID = 10,
                    PicturePath = currentDir + @"\..\..\Resources\120_Yer Fıstığı.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Patlamış Mısır",
                    Calorie = 386d,
                    CategoryID = 10,
                    PicturePath = currentDir + @"\..\..\Resources\121_Patlamış Mısır.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kavrulmuş Kestane",
                    Calorie = 245d,
                    CategoryID = 10,
                    PicturePath = currentDir + @"\..\..\Resources\122_Kavrulmuş Kestane.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Haşlanmış Kestane",
                    Calorie = 131d,
                    CategoryID = 10,
                    PicturePath = currentDir + @"\..\..\Resources\123_Haşlanmış Kestane.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Çıkolatalı Pasta",
                    Calorie = 431d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\124_Çıkolatalı Pasta.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Bisküvi",
                    Calorie = 418d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\125_Bisküvi.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Elmalı Tart",
                    Calorie = 323d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\126_Elmalı Tart.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Pandispanya",
                    Calorie = 280d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\127_Pandispanya.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Dondurma",
                    Calorie = 193d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\128_Dondurma.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Sütlü Çikolata",
                    Calorie = 106d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\129_Sütlü Çikolata.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Bİtter Çikolata",
                    Calorie = 95d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\130_Bİtter Çikolata.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kakao",
                    Calorie = 29d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\131_Kakao.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Bal",
                    Calorie = 15d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\132_Bal.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Üzüm Pekmezi",
                    Calorie = 14d,
                    CategoryID = 11,
                    PicturePath = currentDir + @"\..\..\Resources\133_Üzüm Pekmezi.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Sütlü ve Şekerli Kakao",
                    Calorie = 91d,
                    CategoryID = 12,
                    PicturePath = currentDir + @"\..\..\Resources\134_Sütlü ve Şekerli Kakao.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Kola",
                    Calorie = 59d,
                    CategoryID = 12,
                    PicturePath = currentDir + @"\..\..\Resources\135_Kola.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Elma Suyu",
                    Calorie = 47d,
                    CategoryID = 12,
                    PicturePath = currentDir + @"\..\..\Resources\136_Elma Suyu.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Meyveli Soda",
                    Calorie = 46d,
                    CategoryID = 12,
                    PicturePath = currentDir + @"\..\..\Resources\137_Meyveli Soda.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Portakal Suyu",
                    Calorie = 45d,
                    CategoryID = 12,
                    PicturePath = currentDir + @"\..\..\Resources\138_Portakal Suyu.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Soğuk Çay",
                    Calorie = 30d,
                    CategoryID = 12,
                    PicturePath = currentDir + @"\..\..\Resources\139_Soğuk Çay.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Şekersiz Sade Kahve",
                    Calorie = 9d,
                    CategoryID = 12,
                    PicturePath = currentDir + @"\..\..\Resources\140_Şekersiz Sade Kahve.jpg"
                });
                db.Foods.Add(new Classes.Food()
                {
                    Name = "Şekersiz Çay",
                    Calorie = 3d,
                    CategoryID = 12,
                    PicturePath = currentDir + @"\..\..\Resources\141_Şekersiz Çay.jpg"
                });
            }

            #endregion

        }
    }
}
