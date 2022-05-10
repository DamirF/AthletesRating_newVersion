using System;
using System.IO;
using System.Windows.Forms;
using AthletesRating.GeneralFunctionality;
using System.Data;
using System.Drawing;

namespace MainApplication.GeneralFunctionality
{
    internal class ProfilePicture
    {
        private static OpenFileDialog openFileDialog;
        private static readonly string path = @"D:\Projects\SportsmensRating\MainApplication\bin\Debug\netcoreapp3.1\resourses";

        public static void ProfilePictureSet(ref PictureBox PB, ref AthleteCard athlete)
        {
            PB.SizeMode = PictureBoxSizeMode.Zoom;
            
            if(File.Exists(@$"{path}/{athlete.accountInfo.Login}.jpg"))
            {
                using (Image img = Image.FromFile($"{path}/{athlete.accountInfo.Login}.jpg"))
                {
                    Bitmap bmp = new Bitmap(img);
                    PB.Image = bmp;
                }
            }
            else
            {
                if (athlete.Gender.Trim() == "Мужской")
                    PB.Image = Image.FromFile($"{path}/maleIcon.jpg");
                if (athlete.Gender.Trim() == "Женский")
                    PB.Image = Image.FromFile($"{path}/femaleIcon.jpg");
            }
        }
            


        public static void ProfilePictureLoad(ref PictureBox PB, ref AthleteCard athlete)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            PB.SizeMode = PictureBoxSizeMode.Zoom;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileToResources(ref athlete);
            }
            ProfilePictureSet(ref PB, ref athlete);
        }

        public static void ProfilePictureDelete(ref PictureBox PB, ref AthleteCard athlete)
        {
            string fileName = athlete.accountInfo.Login;
            string fullPath = $"{path}/{fileName}.jpg";
            try
            {
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ProfilePictureSet(ref PB, ref athlete);
        }

        private static void FileToResources(ref AthleteCard athlete)
        {
            string fileName = athlete.accountInfo.Login;
            string fullPath = @$"{path}/{fileName}.jpg";
            try
            {
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                    File.Copy(openFileDialog.FileName, fullPath);
                }
                else
                {
                    File.Copy(openFileDialog.FileName, fullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ChangeLoginPicture(string oldLogin, string newLogin)
        {
            try
            {
                if (File.Exists(@"...\MainApplication\Resources\" + oldLogin + ".jpg"))
                {
                    File.Delete(@"...\MainApplication\Resources\" + oldLogin + ".jpg");
                    File.Copy(openFileDialog.FileName, @"...\MainApplication\Resources\" + newLogin + ".jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
