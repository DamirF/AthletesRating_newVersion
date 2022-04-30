using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using AthletesRating.GeneralFunctionality;
using System.Data;
using SportsmansRating;
using System.Drawing;

namespace MainApplication.GeneralFunctionality
{
    internal class ProfilePicture
    {
        private static OpenFileDialog openFileDialog;
        private static readonly string path = "D:/Projects/SportsmensRating/MainApplication/bin/Debug/netcoreapp3.1/resourses";

        public static void ProfilePictureSet(ref PictureBox PB, ref AthleteCard athlete)
        {
            PB.SizeMode = PictureBoxSizeMode.CenterImage;
            if(File.Exists($"{path}/{athlete.accountInfo.Login}.jpg"))
            {
                PB.Image = Image.FromFile($"{path}/{athlete.accountInfo.Login}.jpg");
            }
            else
            {
                if(athlete.Gender == "Мужской   ")
                    PB.Image = Image.FromFile($"{path}/maleIcon.png");
                if (athlete.Gender == "Женский   ")
                    PB.Image = Image.FromFile($"{path}/femaleIcon.png");
            }
        }
            


        public static void ProfilePictureLoad(ref PictureBox PB, ref AthleteCard athlete)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            PB.SizeMode = PictureBoxSizeMode.CenterImage;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PB.Image = Image.FromFile(openFileDialog.FileName);
            }
            FileToResources(ref athlete);
        }
        private static void FileToResources(ref AthleteCard athlete)
        {
            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();
            string fileName = athlete.accountInfo.Login;
            string fullPath = $"{path}/{fileName}.jpg";
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
