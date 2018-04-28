using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enciclopedie
{
     public class Band
    {
        public int ID;
        public string name;
        public int begingYear;
        public string[] songsTitles = new string[5];
        public string[] songsURL = new string[5];
        public string offcialWebsite;
        public string photoLink;
        public string backgroundPhotoLink;
        public string about;
        public System.Windows.Forms.PictureBox photo;

        public Band(string link)
        {
            photoLink = link;
           
           // photo.Size = new System.Drawing.Size(140, 140);
         
        }
    }



}
