using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Player
{
    public partial class SoundForm : Form
    {
        public SoundForm()
        {
            InitializeComponent();
        }
        Sound sound = new Sound();
        public static int leftvalue = 1000;
        public static int rightvalue = 1000;
        public static int soundvalue = 1000;
        public static int tizvalue = 1000;
        public static int bassvalue = 1000;
        private void Left_Trackbar_Scroll(object sender, EventArgs e)
        {
            sound.LeftSound = Left_Trackbar.Value;
            leftvalue = Left_Trackbar.Value;
        }

        private void Right_Trackbar_Scroll(object sender, EventArgs e)
        {
            sound.RightSound = Right_Trackbar.Value;
            rightvalue= Right_Trackbar.Value;
        }

        private void Sound_Trackbar_Scroll(object sender, EventArgs e)
        {
            sound.MotherSound = Sound_Trackbar.Value;
            soundvalue = Sound_Trackbar.Value;
        }

        private void Tiz_Trackbar_Scroll(object sender, EventArgs e)
        {
            sound.TizSound = Tiz_Trackbar.Value;
            tizvalue = Tiz_Trackbar.Value;
        }

        private void Bass_Trackbar_Scroll(object sender, EventArgs e)
        {
            sound.BassSound = Bass_Trackbar.Value;
            bassvalue = Bass_Trackbar.Value;
        }

        private void SoundForm_Load(object sender, EventArgs e)
        {
            Left_Trackbar.Value = leftvalue;
            Right_Trackbar.Value = rightvalue;
            Sound_Trackbar.Value = soundvalue;
            Tiz_Trackbar.Value = tizvalue;
            Bass_Trackbar.Value = bassvalue;
        }
    }
}
