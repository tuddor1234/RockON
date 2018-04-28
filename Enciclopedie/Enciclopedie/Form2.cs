using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enciclopedie
{
    public partial class Form2 : Form
    {
        int SongsIndex = 0;
        string home = "www.google.com";
        Band currentBand;
        

        public Form2(Band band)
        {
            InitializeComponent();
            currentBand = band;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            browser.ScriptErrorsSuppressed = true;
            player.ScriptErrorsSuppressed = true;
            browser.Navigate(ConvertStringForBrowser(currentBand.offcialWebsite));

            player.Navigate(currentBand.songsURL[0]);
            despre.Text = ConvertStringForText(currentBand.about);
            currentSongTitle_Label.Text = "Now playing: \n" + currentBand.songsTitles[0];
        }

        string ConvertStringForBrowser(string s)
        {
            int p = 0;
            if (s[0] == '#') p++;
            string s1 = s.Substring(p, s.Length - 2);
            return s1;
        }

        string ConvertStringForText(string s)
        {
            return s.Substring(5, s.Length-11);
        }



        bool mousePreesed;
        int coordX = -1;
        int coordY = -1;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePreesed = true;
            coordX = e.X;
            coordY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousePreesed = false;
            coordX = -1;
            coordY = -1;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePreesed)
            {
                this.SetDesktopLocation(MousePosition.X - coordX, MousePosition.Y - coordY);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //   Form1 form1 = new Form1();
            // form1.ShowDialog();
           
            this.Close();
            browser.Navigate(home);
            player.Navigate(home);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SongsIndex++;
            if (SongsIndex >= 5) SongsIndex = 0;
            player.Navigate(currentBand.songsURL[SongsIndex]);
            currentSongTitle_Label.Text = "Now playing: \n" + currentBand.songsTitles[SongsIndex];
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            SongsIndex--;
            if (SongsIndex <= 0) SongsIndex = 4;
            player.Navigate(currentBand.songsURL[SongsIndex]);
            currentSongTitle_Label.Text = "Now playing: \n" + currentBand.songsTitles[SongsIndex];
        }
    }
}
