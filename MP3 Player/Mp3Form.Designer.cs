namespace MP3_Player
{
    partial class Mp3Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mp3Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sound_BTN = new System.Windows.Forms.PictureBox();
            this.Add_BTN = new System.Windows.Forms.PictureBox();
            this.Go_BTN = new System.Windows.Forms.PictureBox();
            this.Back_BTN = new System.Windows.Forms.PictureBox();
            this.Start_BTN = new System.Windows.Forms.PictureBox();
            this.Stop_BTN = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.music_name_panel = new System.Windows.Forms.Panel();
            this.music_name_label = new System.Windows.Forms.Label();
            this.SoundAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.MusicStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.full_time_label = new System.Windows.Forms.Label();
            this.this_time_label = new System.Windows.Forms.Label();
            this.MusicListTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sound_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.music_name_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 39);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "MP3 Player";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(343, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(29, 26);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 3;
            this.minimize.TabStop = false;
            this.toolTip1.SetToolTip(this.minimize, "Bük");
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(378, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 26);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.toolTip1.SetToolTip(this.close, "Çıxış");
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.Sound_BTN);
            this.panel2.Controls.Add(this.Add_BTN);
            this.panel2.Controls.Add(this.Go_BTN);
            this.panel2.Controls.Add(this.Back_BTN);
            this.panel2.Controls.Add(this.Start_BTN);
            this.panel2.Controls.Add(this.Stop_BTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 55);
            this.panel2.TabIndex = 1;
            // 
            // Sound_BTN
            // 
            this.Sound_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sound_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Sound_BTN.Image")));
            this.Sound_BTN.Location = new System.Drawing.Point(343, 11);
            this.Sound_BTN.Name = "Sound_BTN";
            this.Sound_BTN.Size = new System.Drawing.Size(52, 36);
            this.Sound_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sound_BTN.TabIndex = 0;
            this.Sound_BTN.TabStop = false;
            this.toolTip1.SetToolTip(this.Sound_BTN, "Səs");
            this.Sound_BTN.Click += new System.EventHandler(this.Sound_BTN_Click);
            this.Sound_BTN.MouseLeave += new System.EventHandler(this.PictureBox8_MouseLeave);
            this.Sound_BTN.MouseHover += new System.EventHandler(this.BackGroundHover);
            // 
            // Add_BTN
            // 
            this.Add_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Add_BTN.Image")));
            this.Add_BTN.Location = new System.Drawing.Point(18, 11);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(52, 36);
            this.Add_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Add_BTN.TabIndex = 3;
            this.Add_BTN.TabStop = false;
            this.toolTip1.SetToolTip(this.Add_BTN, "Mahnı Listi");
            this.Add_BTN.Click += new System.EventHandler(this.Open_BTN_Click);
            this.Add_BTN.MouseLeave += new System.EventHandler(this.PictureBox8_MouseLeave);
            this.Add_BTN.MouseHover += new System.EventHandler(this.BackGroundHover);
            // 
            // Go_BTN
            // 
            this.Go_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Go_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Go_BTN.Image")));
            this.Go_BTN.Location = new System.Drawing.Point(265, 11);
            this.Go_BTN.Name = "Go_BTN";
            this.Go_BTN.Size = new System.Drawing.Size(52, 36);
            this.Go_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Go_BTN.TabIndex = 2;
            this.Go_BTN.TabStop = false;
            this.toolTip1.SetToolTip(this.Go_BTN, "İrəli");
            this.Go_BTN.Click += new System.EventHandler(this.Go_BTN_Click);
            this.Go_BTN.MouseLeave += new System.EventHandler(this.PictureBox8_MouseLeave);
            this.Go_BTN.MouseHover += new System.EventHandler(this.BackGroundHover);
            // 
            // Back_BTN
            // 
            this.Back_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Back_BTN.Image")));
            this.Back_BTN.Location = new System.Drawing.Point(93, 11);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(52, 36);
            this.Back_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back_BTN.TabIndex = 1;
            this.Back_BTN.TabStop = false;
            this.toolTip1.SetToolTip(this.Back_BTN, "Geri");
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            this.Back_BTN.MouseLeave += new System.EventHandler(this.PictureBox8_MouseLeave);
            this.Back_BTN.MouseHover += new System.EventHandler(this.BackGroundHover);
            // 
            // Start_BTN
            // 
            this.Start_BTN.Cursor = System.Windows.Forms.Cursors.No;
            this.Start_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Start_BTN.Image")));
            this.Start_BTN.Location = new System.Drawing.Point(181, 11);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(52, 36);
            this.Start_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Start_BTN.TabIndex = 4;
            this.Start_BTN.TabStop = false;
            this.toolTip1.SetToolTip(this.Start_BTN, "Başlat");
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // Stop_BTN
            // 
            this.Stop_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Stop_BTN.Image")));
            this.Stop_BTN.Location = new System.Drawing.Point(181, 11);
            this.Stop_BTN.Name = "Stop_BTN";
            this.Stop_BTN.Size = new System.Drawing.Size(52, 36);
            this.Stop_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Stop_BTN.TabIndex = 2;
            this.Stop_BTN.TabStop = false;
            this.toolTip1.SetToolTip(this.Stop_BTN, "Dayandır");
            this.Stop_BTN.Visible = false;
            this.Stop_BTN.Click += new System.EventHandler(this.Stop_BTN_Click);
            this.Stop_BTN.MouseLeave += new System.EventHandler(this.PictureBox8_MouseLeave);
            this.Stop_BTN.MouseHover += new System.EventHandler(this.BackGroundHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(377, 214);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // music_name_panel
            // 
            this.music_name_panel.Controls.Add(this.music_name_label);
            this.music_name_panel.Location = new System.Drawing.Point(56, 42);
            this.music_name_panel.Name = "music_name_panel";
            this.music_name_panel.Size = new System.Drawing.Size(297, 30);
            this.music_name_panel.TabIndex = 3;
            this.music_name_panel.Visible = false;
            // 
            // music_name_label
            // 
            this.music_name_label.AutoSize = true;
            this.music_name_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.music_name_label.Location = new System.Drawing.Point(210, 6);
            this.music_name_label.Name = "music_name_label";
            this.music_name_label.Size = new System.Drawing.Size(83, 18);
            this.music_name_label.TabIndex = 4;
            this.music_name_label.Text = "Music Name";
            // 
            // SoundAnimationTimer
            // 
            this.SoundAnimationTimer.Interval = 10;
            this.SoundAnimationTimer.Tick += new System.EventHandler(this.SoundAnimationTimer_Tick);
            // 
            // MusicStatusTimer
            // 
            this.MusicStatusTimer.Tick += new System.EventHandler(this.MusicStatusTimer_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(66, 285);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(287, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll_1);
            // 
            // full_time_label
            // 
            this.full_time_label.AutoSize = true;
            this.full_time_label.Location = new System.Drawing.Point(319, 269);
            this.full_time_label.Name = "full_time_label";
            this.full_time_label.Size = new System.Drawing.Size(34, 13);
            this.full_time_label.TabIndex = 5;
            this.full_time_label.Text = "00:00";
            // 
            // this_time_label
            // 
            this.this_time_label.AutoSize = true;
            this.this_time_label.Location = new System.Drawing.Point(63, 269);
            this.this_time_label.Name = "this_time_label";
            this.this_time_label.Size = new System.Drawing.Size(34, 13);
            this.this_time_label.TabIndex = 6;
            this.this_time_label.Text = "00:00";
            // 
            // MusicListTimer
            // 
            this.MusicListTimer.Tick += new System.EventHandler(this.MusicListTimer_Tick);
            // 
            // Mp3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(410, 364);
            this.Controls.Add(this.this_time_label);
            this.Controls.Add(this.full_time_label);
            this.Controls.Add(this.music_name_panel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mp3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mp3Form_FormClosed);
            this.Load += new System.EventHandler(this.Mp3Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sound_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.music_name_panel.ResumeLayout(false);
            this.music_name_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Sound_BTN;
        private System.Windows.Forms.PictureBox Back_BTN;
        private System.Windows.Forms.PictureBox Go_BTN;
        private System.Windows.Forms.PictureBox Stop_BTN;
        private System.Windows.Forms.PictureBox Add_BTN;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Start_BTN;
        private System.Windows.Forms.Panel music_name_panel;
        private System.Windows.Forms.Label music_name_label;
        private System.Windows.Forms.Timer SoundAnimationTimer;
        private System.Windows.Forms.Timer MusicStatusTimer;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label full_time_label;
        private System.Windows.Forms.Label this_time_label;
        private System.Windows.Forms.Timer MusicListTimer;
    }
}

