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
    public partial class MusicListForm : Form
    {
        public MusicListForm()
        {
            InitializeComponent();
        }
        Sound sound = new Sound();
        public static bool exit = false;
        public static bool userslc = false;
        public static int rowindex = -1;
        int count = 0;

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
                    dialog.Multiselect = true;
                    if (DialogResult.OK == dialog.ShowDialog())
                    {
                        sound.Close();
                        foreach (var item in dialog.FileNames)
                        {
                            Sound.musiclist.Add(item);
                            count++;
                            listBox1.Items.Add(count.ToString() + ". " + sound.NameParse(item));
                            exit = true;
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void Remove_BTN_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                var dialog = MessageBox.Show("Bütün mahnı listi silinsin ?", "Diqqət !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                    Sound.musiclist.Clear();
                    sound.Remove();
                    exit = true;
                }
            }
        }

        private void Selected_Rmv_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count > 0)
                {
                    var index = listBox1.SelectedIndex;
                    Sound.musiclist.RemoveAt(index);
                    listBox1.Items.RemoveAt(index);
                    exit = true;
                }
            }
            catch (Exception) { }
        }

        private void MusicListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void MusicListForm_Load(object sender, EventArgs e)
        {
            if (Sound.newload)
            {
                Sound.musiclist.Clear();
                foreach (string item in sound.Select())
                {
                    Sound.musiclist.Add(item);
                }
                Sound.newload = false;
            }

            foreach (var item in Sound.musiclist)
            {
                count++;
                listBox1.Items.Add(count.ToString() + ". " + sound.NameParse(item));
            }
            exit = false;
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            Sound.musicCount = listBox1.SelectedIndex;
            rowindex = listBox1.SelectedIndex;
            if (rowindex >= 0)
            {
                userslc = true;
                exit = true;
                this.Close();
            }
         
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
