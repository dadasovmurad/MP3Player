namespace MP3_Player
{
    partial class MusicListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicListForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Add_BTN = new System.Windows.Forms.Button();
            this.Selected_Rmv_BTN = new System.Windows.Forms.Button();
            this.Remove_BTN = new System.Windows.Forms.Button();
            this.music_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.Aqua;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 220);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.ListBox1_DoubleClick);
            // 
            // Add_BTN
            // 
            this.Add_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Add_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_BTN.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Add_BTN.Image")));
            this.Add_BTN.Location = new System.Drawing.Point(143, 254);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(92, 36);
            this.Add_BTN.TabIndex = 2;
            this.Add_BTN.UseVisualStyleBackColor = false;
            this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
            // 
            // Selected_Rmv_BTN
            // 
            this.Selected_Rmv_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Selected_Rmv_BTN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Selected_Rmv_BTN.Location = new System.Drawing.Point(12, 254);
            this.Selected_Rmv_BTN.Name = "Selected_Rmv_BTN";
            this.Selected_Rmv_BTN.Size = new System.Drawing.Size(104, 23);
            this.Selected_Rmv_BTN.TabIndex = 3;
            this.Selected_Rmv_BTN.Text = "Seçilmiş Sətri Sil";
            this.Selected_Rmv_BTN.UseVisualStyleBackColor = true;
            this.Selected_Rmv_BTN.Click += new System.EventHandler(this.Selected_Rmv_BTN_Click);
            // 
            // Remove_BTN
            // 
            this.Remove_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove_BTN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Remove_BTN.Location = new System.Drawing.Point(267, 254);
            this.Remove_BTN.Name = "Remove_BTN";
            this.Remove_BTN.Size = new System.Drawing.Size(100, 23);
            this.Remove_BTN.TabIndex = 4;
            this.Remove_BTN.Text = "Hamısını Sil";
            this.Remove_BTN.UseVisualStyleBackColor = true;
            this.Remove_BTN.Click += new System.EventHandler(this.Remove_BTN_Click);
            // 
            // music_name_label
            // 
            this.music_name_label.AutoSize = true;
            this.music_name_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.music_name_label.ForeColor = System.Drawing.Color.Yellow;
            this.music_name_label.Location = new System.Drawing.Point(12, 9);
            this.music_name_label.Name = "music_name_label";
            this.music_name_label.Size = new System.Drawing.Size(270, 18);
            this.music_name_label.TabIndex = 5;
            this.music_name_label.Text = "Seçili Mahnıya 2 dəfə klik edin oynadılsın.\r\n";
            // 
            // MusicListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(379, 295);
            this.Controls.Add(this.music_name_label);
            this.Controls.Add(this.Remove_BTN);
            this.Controls.Add(this.Selected_Rmv_BTN);
            this.Controls.Add(this.Add_BTN);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MusicListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "      Mahnı Listi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MusicListForm_FormClosed);
            this.Load += new System.EventHandler(this.MusicListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.Button Selected_Rmv_BTN;
        private System.Windows.Forms.Button Remove_BTN;
        private System.Windows.Forms.Label music_name_label;
    }
}