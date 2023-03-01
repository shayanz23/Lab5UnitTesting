using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5UnitTesting
{
    public abstract class Media
    {
        public abstract string title { get; set; }
        public abstract string fileLocation { get; set; }
    }

    public class Audio : Media
    {
        public override string title { get; set; }

        public override string fileLocation { get; set; }

        public string album { get; set; }

        public string artist { get; set; }

        public string genre { get; set; }

        public int durationSec { get; set; }

        public Image coverArt { get; set; }

    }

    public class Video : Media
    {
        public override string title { get; set; }

        public override string fileLocation { get; set; }

        public string genre { get; set; }
    
        public string director { get; set; }

        public int durationSec { get; set; }

        public string description { get; set; }
    }

    public class Image : Media
    {
        public override string title { get; set; }

        public override string fileLocation { get; set; }

        public Size resolution { get; set; }

        public int date { get; set; }

        public string description { get; set; }
    }

    public class MediaScanner
    {
        ArrayList audio = new ArrayList();
        ArrayList video = new ArrayList();
        ArrayList images = new ArrayList();

        public bool scanMedia()
        {
            return false;
        }

    }
}
