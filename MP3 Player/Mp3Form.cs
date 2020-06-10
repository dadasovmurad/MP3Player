using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Player
{
    public partial class Mp3Form : Form
    {
        public Mp3Form()
        {
            InitializeComponent();
        }
        Sound sound = new Sound();
        GlobalKeyboardHook gHook;

        List<string> musiclist = new List<string>();
        int x, y;
        bool move;
        bool warning = true;
        bool volume = true;
        private void Mp3Form_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                gHook.HookedKeys.Add(key);
            }
            gHook.hook();
        }
        private void SoundValuesStatic()
        {
            sound.MotherSound = 1000;
            sound.LeftSound = 1000;
            sound.RightSound = 1000;
            sound.TizSound = 1000;
        }
        private void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D8)
            {
                if (SoundForm.soundvalue <= 900)
                {
                    SoundForm.soundvalue += 100;
                    sound.MotherSound = SoundForm.soundvalue;
                }
            }
            else if(e.KeyCode==Keys.D9)
            {
                if (SoundForm.soundvalue >= 100)
                {
                    SoundForm.soundvalue -= 100;
                    sound.MotherSound = SoundForm.soundvalue;
                }
            }
            else if (e.KeyCode == Keys.D0)
            {
                if (volume)
                {
                    sound.MotherSound = 0;
                    SoundForm.soundvalue = 0;
                    volume = false;
                }
                else
                {
                    sound.MotherSound = 1000;
                    SoundForm.soundvalue = 1000;
                    volume = true;
                }
            }
        }

        private void BackGroundHover(object sender, EventArgs e)
        {
            // arxa plana yaxinlasmaq
            //PictureBox picturebox = (PictureBox)sender;
            //int argb = 224;
            //picturebox.BackColor = Color.FromArgb(argb, argb, argb, argb);
        }

        private void PictureBox8_MouseLeave(object sender, EventArgs e)
        {
         //   PictureBox picturebox = (PictureBox)sender;
            //picturebox.BackColor = Color.FromArgb(241,239,241);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Proqramı bağlamaq istədiyinizdən əminsiniz ?","Diqqət !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == dialog)
            {
                Application.Exit();
            }
        }

        private void Start_BTN_Click(object sender, EventArgs e)
        {
            if (Start_BTN.Cursor == Cursors.Hand)
            {
                if (Sound.musiclist.Count > 0)
                {
                    trackBar1.Enabled = true;
                    Stop_BTN.Visible = true;
                    Start_BTN.Visible = false;
                    music_name_panel.Visible = true;
                    sound.Play();
                    //music_name_label.Text = musicname;
                    sound.ToplamSure();
                    trackBar1.Maximum = sound._sn_ToplamSure;
                    SoundAnimationTimer.Enabled = true;
                    MusicStatusTimer.Enabled = true;
                }
            }
        }

        private void Stop_BTN_Click(object sender, EventArgs e)
        {
            trackBar1.Enabled = false;
            Start_BTN.Visible = true;
            Stop_BTN.Visible = false;
            sound.Stop();
            SoundAnimationTimer.Stop();
        }
        private void Open_BTN_Click(object sender, EventArgs e)
        {
            if (Sound.musiclist.Count > 0 && warning)
            {
                MessageBox.Show("Mahnı listində mahnı silinərsə, mahnılar ən başa dönəcək.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                warning = false;
            }
            MusicListForm msform = new MusicListForm();
            msform.ShowDialog();
            MusicListTimer.Enabled = true;
        }
        private void MusicListTimer_Tick(object sender, EventArgs e)
        {
            if (MusicListForm.exit)
            {
                // timeri ise salaq gorek nolur
                if (MusicListForm.userslc)
                {
                    int rowindex = MusicListForm.rowindex;
                    if (rowindex >= 0)
                    {
                        MusicListTimer.Stop();
                        Start_BTN.Cursor = Cursors.Hand;
                        sound.Close();
                        if (Sound.musiclist.Count>0)
                        {
                            sound.Open(Sound.musiclist[rowindex]);
                            sound.Play();
                            music_name_label.Text = sound.NameParse(Sound.musiclist[rowindex]);
                            music_name_panel.Visible = true;
                            Start_BTN_Click(sender, e);

                            //Stop_BTN.Visible = true;
                            //Start_BTN.Visible = false;
                            Sound.musicCount = rowindex;
                            SoundAnimationTimer.Enabled = true;
                            if (sound.mp3_Durum() == "")
                            {
                                MessageBox.Show("File zədələnib və ya adında düzgün simvollar yoxdur !","Diqqət !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                Go_BTN_Click(sender, e);
                            }
                        }
                        else
                        {
                            trackBar1.Value = 0;
                            this_time_label.Text = "00:00";
                            full_time_label.Text = "00:00";
                            music_name_panel.Visible = false;
                            Sound.musicCount = 0;
                            sound.Stop();
                            Stop_BTN_Click(sender, e);
                            Start_BTN.Cursor = Cursors.No;
                            MusicStatusTimer.Stop();
                        }
                    }
                    return;
                }
                MusicListTimer.Stop();
                Stop_BTN.Visible = false;
                Start_BTN.Visible = true;
                Start_BTN.Cursor = Cursors.Hand;
                sound.Close();
                // musicname = Sound.musiclist[Sound.musicCount];
                if (Sound.musiclist.Count > 0)
                {
                    sound.Open(Sound.musiclist[0]);
                    music_name_label.Text = sound.NameParse(Sound.musiclist[0]);
                    music_name_panel.Visible = true;
                    SoundAnimationTimer.Enabled = true;
                }
                else
                {
                    this_time_label.Text = "00:00";
                    full_time_label.Text = "00:00";
                    MusicStatusTimer.Stop();
                    music_name_panel.Visible = false;
                    trackBar1.Value = 0;
                    trackBar1.Enabled = false;
                    Start_BTN.Cursor = Cursors.No;
                }
            }
        }
       
        private void Back_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sound.musicCount != 0)
                {
                    Sound.musicCount--;
                   
                    var msc = Sound.musiclist[Sound.musicCount];
                   
                    sound.Close();
                    sound.Open(msc);
                    sound.Play();
                    Stop_BTN.Visible = true;
                    Start_BTN.Visible = false;
                    music_name_label.Text = sound.NameParse(msc);
                    SoundAnimationTimer.Enabled = true;
                }
                else
                {
                    Sound.musicCount = 0;
                    var msc = Sound.musiclist[0];
                    sound.Close();
                    sound.Open(msc);
                    sound.Play();
                    Stop_BTN.Visible = true;
                    Start_BTN.Visible = false;
                    music_name_label.Text = sound.NameParse(msc);
                    SoundAnimationTimer.Enabled = true;
                }
                music_name_label.Left = 300;
                SelectedSound();
                if (sound.mp3_Durum() == "")
                {
                    Go_BTN_Click(sender, e);
                }
            }
            catch (Exception) { }
        }
        private void Go_BTN_Click(object sender, EventArgs e)
        {
            try
            {
               
                Sound.musicCount++;
                if (Sound.musiclist.Count > Sound.musicCount)
                {
                    Stop_BTN.Visible = true;
                    Start_BTN.Visible = false;
                    SoundAnimationTimer.Enabled = true;
                    var msc = Sound.musiclist[Sound.musicCount];
                    sound.Close();
                    sound.Open(msc);
                    sound.Play();
                    music_name_label.Text = sound.NameParse(msc);
                }
                else
                {
                    Sound.musicCount = 0;
                    var msc = Sound.musiclist[0];
                    sound.Close();
                    sound.Open(msc);
                    sound.Play();
                    Stop_BTN.Visible = true;
                    Start_BTN.Visible = false;
                    music_name_label.Text = sound.NameParse(msc);
                    SoundAnimationTimer.Enabled = true;
                }
                music_name_label.Left = 300;
                if (sound.mp3_Durum() == "")
                {
                    Go_BTN_Click(sender, e);
                }
                SelectedSound();
            }
            catch (Exception) { }
        }
        private void SelectedSound()
        {
            sound.LeftSound = SoundForm.leftvalue;
            sound.RightSound = SoundForm.rightvalue;
            sound.MotherSound = SoundForm.soundvalue;
            sound.TizSound = SoundForm.tizvalue;
            sound.BassSound = SoundForm.bassvalue;
        }

        private void SoundAnimationTimer_Tick(object sender, EventArgs e)
        {
            music_name_label.Left--;
            if (music_name_label.Left+200 < music_name_panel.Left)
            {
                music_name_label.Left = 300;
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            Cursor = Cursors.Default;

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x= e.X;
            y = e.Y;
            Cursor = Cursors.SizeAll;


        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void MusicStatusTimer_Tick(object sender, EventArgs e)
        {
            sound.Pozisyon();
            if (trackBar1.Value == sound._sn_ToplamSure)
            {
                MusicStatusTimer.Stop();
                trackBar1.Value = 0;
                Start_BTN.Visible = true;
                Stop_BTN.Visible = false;
                sound.Stop();
                Go_BTN_Click(sender, e);
                Start_BTN_Click(sender, e);
            }
            else
            {
                trackBar1.Value = sound._sn_Pozisyon;
                full_time_label.Text = sound._st_ToplamSure.ToString();
                this_time_label.Text = sound._st_Pozisyon;
            }
        }

        private void TrackBar1_Scroll_1(object sender, EventArgs e)
        {
            sound.Stop();
            double d = TimeSpan.FromSeconds(trackBar1.Value).TotalMilliseconds;
            sound.IleriGeriSar(d);
            sound.Play();
        }

        private void Sound_BTN_Click(object sender, EventArgs e)
        {
            SoundForm sndfrm = new SoundForm();
            sndfrm.ShowDialog();
        }

        private void Mp3Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            sound.Close();
            sound.Save(Sound.musiclist);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);

            }
        }
    }
}
