using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // pentru baze de date
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Enciclopedie
{
    public partial class Form1 : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        public List<Band> bands = new List<Band>();
        public int PhotoX=175, PhotoY=175;
      

        public Form1()
        {
            InitializeComponent();
            
        }
   
      

        private void AddBandsOnScreen()
        {
            //concat the file location
            string photosPath = Directory.GetCurrentDirectory() + @"\BandsPhotos";
            
         
            foreach (Band b in bands)
            {
                b.photo = new PictureBox();
                b.photo.Size = new Size(PhotoX,PhotoY);
                b.photo.Load(photosPath + @"\" + b.name.ToLower() + ".jpg");
                b.photo.BackgroundImageLayout = ImageLayout.Tile;
                b.photo.Click += new EventHandler(OpenBandForm);
                grid.Controls.Add(b.photo);

            }
           
        }
      

        private void OpenBandForm(object sender, EventArgs e)
        {
            Band b = searchTheBand(sender);
            Form2 frm = new Form2(b);
            frm.ShowDialog();
            

        }

        private Band searchTheBand(object sender)
        {
         
            for(int i=0;i<bands.Capacity;i++)
            {
                if (sender == bands[i].photo) return bands[i];
            }
            return null;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
          

             string path = Directory.GetCurrentDirectory() + "\\Artists.accdb";
        
            try
            {
               //link to Database
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ path +";Persist Security Info = False; ";
                connection.Open();
                
                //search the bands
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM bands";
                OleDbDataReader reader = command.ExecuteReader();

                //Read every item of the database
                while (reader.Read())
                {
                    Band b = new Band(reader["Picture"].ToString());
                    b.name = reader["Name"].ToString();
                    string year = reader["Year"].ToString();
                    b.begingYear = Convert.ToInt32(year);
                    for (int i = 1; i <= 5; i++)
                    {                     
                        b.songsTitles[i-1] = reader["Song"+i+"_Name"].ToString();
                        b.songsURL[i-1] = reader["Song" + i + "_Link"].ToString(); 
                    }
                    b.ID = Convert.ToInt32(reader["ID"].ToString());
                    b.offcialWebsite = reader["Official Website"].ToString();
                    b.about = reader["About"].ToString();

                   // rtTest.Text += b.offcialWebsite + " *****";
                    bands.Add(b);
                }
            
                //close database connection
                reader.Close();
                command.ExecuteNonQuery();
                connection.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            // add images on in flowPanel
            AddBandsOnScreen();
            
        }


        /*
            Mouse form movement
         */
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
            if(mousePreesed)
            {
                this.SetDesktopLocation(MousePosition.X - coordX, MousePosition.Y - coordY);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       
    }
}
