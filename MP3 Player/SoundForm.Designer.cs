namespace MP3_Player
{
    partial class SoundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundForm));
            this.Left_Trackbar = new System.Windows.Forms.TrackBar();
            this.Right_Trackbar = new System.Windows.Forms.TrackBar();
            this.Tiz_Trackbar = new System.Windows.Forms.TrackBar();
            this.Sound_Trackbar = new System.Windows.Forms.TrackBar();
            this.Bass_Trackbar = new System.Windows.Forms.TrackBar();
            this.music_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiz_Trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sound_Trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bass_Trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_Trackbar
            // 
            this.Left_Trackbar.Location = new System.Drawing.Point(14, 52);
            this.Left_Trackbar.Maximum = 1000;
            this.Left_Trackbar.Name = "Left_Trackbar";
            this.Left_Trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Left_Trackbar.Size = new System.Drawing.Size(45, 187);
            this.Left_Trackbar.TabIndex = 0;
            this.Left_Trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Left_Trackbar.Value = 1000;
            this.Left_Trackbar.Scroll += new System.EventHandler(this.Left_Trackbar_Scroll);
            // 
            // Right_Trackbar
            // 
            this.Right_Trackbar.Location = new System.Drawing.Point(102, 52);
            this.Right_Trackbar.Maximum = 1000;
            this.Right_Trackbar.Name = "Right_Trackbar";
            this.Right_Trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Right_Trackbar.Size = new System.Drawing.Size(45, 187);
            this.Right_Trackbar.TabIndex = 1;
            this.Right_Trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Right_Trackbar.Value = 1000;
            this.Right_Trackbar.Scroll += new System.EventHandler(this.Right_Trackbar_Scroll);
            // 
            // Tiz_Trackbar
            // 
            this.Tiz_Trackbar.Location = new System.Drawing.Point(278, 52);
            this.Tiz_Trackbar.Maximum = 1000;
            this.Tiz_Trackbar.Name = "Tiz_Trackbar";
            this.Tiz_Trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Tiz_Trackbar.Size = new System.Drawing.Size(45, 187);
            this.Tiz_Trackbar.TabIndex = 3;
            this.Tiz_Trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Tiz_Trackbar.Value = 1000;
            this.Tiz_Trackbar.Scroll += new System.EventHandler(this.Tiz_Trackbar_Scroll);
            // 
            // Sound_Trackbar
            // 
            this.Sound_Trackbar.Location = new System.Drawing.Point(190, 52);
            this.Sound_Trackbar.Maximum = 1000;
            this.Sound_Trackbar.Name = "Sound_Trackbar";
            this.Sound_Trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Sound_Trackbar.Size = new System.Drawing.Size(45, 187);
            this.Sound_Trackbar.TabIndex = 2;
            this.Sound_Trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Sound_Trackbar.Value = 1000;
            this.Sound_Trackbar.Scroll += new System.EventHandler(this.Sound_Trackbar_Scroll);
            // 
            // Bass_Trackbar
            // 
            this.Bass_Trackbar.Location = new System.Drawing.Point(366, 52);
            this.Bass_Trackbar.Maximum = 1000;
            this.Bass_Trackbar.Name = "Bass_Trackbar";
            this.Bass_Trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Bass_Trackbar.Size = new System.Drawing.Size(45, 187);
            this.Bass_Trackbar.TabIndex = 4;
            this.Bass_Trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Bass_Trackbar.Value = 1000;
            this.Bass_Trackbar.Scroll += new System.EventHandler(this.Bass_Trackbar_Scroll);
            // 
            // music_name_label
            // 
            this.music_name_label.AutoSize = true;
            this.music_name_label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.music_name_label.ForeColor = System.Drawing.Color.Aqua;
            this.music_name_label.Location = new System.Drawing.Point(11, 32);
            this.music_name_label.Name = "music_name_label";
            this.music_name_label.Size = new System.Drawing.Size(28, 17);
            this.music_name_label.TabIndex = 5;
            this.music_name_label.Text = "Sol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sağ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(187, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ana Səs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(275, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(363, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "BASS";
            // 
            // SoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(423, 248);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.music_name_label);
            this.Controls.Add(this.Bass_Trackbar);
            this.Controls.Add(this.Tiz_Trackbar);
            this.Controls.Add(this.Sound_Trackbar);
            this.Controls.Add(this.Right_Trackbar);
            this.Controls.Add(this.Left_Trackbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Səs Tənzimləmələri";
            this.Load += new System.EventHandler(this.SoundForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Left_Trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiz_Trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sound_Trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bass_Trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Left_Trackbar;
        private System.Windows.Forms.TrackBar Right_Trackbar;
        private System.Windows.Forms.TrackBar Tiz_Trackbar;
        private System.Windows.Forms.TrackBar Sound_Trackbar;
        private System.Windows.Forms.TrackBar Bass_Trackbar;
        private System.Windows.Forms.Label music_name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}