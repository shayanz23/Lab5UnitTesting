using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace Lab6UnitTesting
{
    public partial class Form1 : Form
    {
        SoundPlayer bMusic;
        SoundPlayer lMusic;
        bool bgPlaying; 

        public Form1()
        {
            
            InitializeComponent();
            WMP.URL = @"birdForest.mp3";
            WMP.settings.playCount = 999;
            WMP.Ctlcontrols.stop();
            WMP.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayLSound(object sender, EventArgs e)
        {
            bMusic = new SoundPlayer(@"birdJungle.wav");
            bMusic.Play(); 
        }

        private void PlayBSound(object sender, EventArgs e)
        {
            bMusic = new SoundPlayer(@"birdForest.wav");
            bMusic.PlayLooping();
            WMP.Ctlcontrols.stop(); 
            bgPlaying= true;
        }

        private void PlayMediaPlayer(object sender, EventArgs e)
        {
            if(bgPlaying == true)
            {
                bMusic.Stop();
                bgPlaying = false;
            }

            WMP.Ctlcontrols.play();
        }

    }
}
