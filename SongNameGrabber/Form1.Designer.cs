namespace SongNameGrabber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            now_playing_label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            now_playing_label_text = new Label();
            enabled_btn = new Button();
            chkbox_video = new CheckBox();
            chkbox_music = new CheckBox();
            chkbox_other = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            file_info_label = new Label();
            file_selected_label = new Label();
            browse_file_btn = new Button();
            label7 = new Label();
            chkbox_genres = new CheckBox();
            chkbox_albumname = new CheckBox();
            chkbox_artistname = new CheckBox();
            chkbox_songname = new CheckBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // now_playing_label
            // 
            now_playing_label.AutoSize = true;
            now_playing_label.Location = new Point(95, 9);
            now_playing_label.Name = "now_playing_label";
            now_playing_label.Size = new Size(34, 15);
            now_playing_label.TabIndex = 0;
            now_playing_label.Text = "none";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // now_playing_label_text
            // 
            now_playing_label_text.AutoSize = true;
            now_playing_label_text.Location = new Point(12, 9);
            now_playing_label_text.Name = "now_playing_label_text";
            now_playing_label_text.Size = new Size(77, 15);
            now_playing_label_text.TabIndex = 2;
            now_playing_label_text.Text = "Now Playing:";
            now_playing_label_text.Click += label3_Click;
            // 
            // enabled_btn
            // 
            enabled_btn.Enabled = false;
            enabled_btn.Location = new Point(97, 80);
            enabled_btn.Name = "enabled_btn";
            enabled_btn.Size = new Size(75, 23);
            enabled_btn.TabIndex = 3;
            enabled_btn.Text = "Enabled";
            enabled_btn.UseVisualStyleBackColor = true;
            enabled_btn.Click += enabled_btn_Click;
            // 
            // chkbox_video
            // 
            chkbox_video.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkbox_video.AutoSize = true;
            chkbox_video.Location = new Point(272, 88);
            chkbox_video.Name = "chkbox_video";
            chkbox_video.Size = new Size(56, 19);
            chkbox_video.TabIndex = 1;
            chkbox_video.Text = "Video";
            chkbox_video.UseVisualStyleBackColor = true;
            chkbox_video.CheckedChanged += chkbox_video_CheckedChanged;
            // 
            // chkbox_music
            // 
            chkbox_music.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkbox_music.AutoSize = true;
            chkbox_music.Checked = true;
            chkbox_music.CheckState = CheckState.Checked;
            chkbox_music.Location = new Point(272, 63);
            chkbox_music.Name = "chkbox_music";
            chkbox_music.Size = new Size(58, 19);
            chkbox_music.TabIndex = 2;
            chkbox_music.Text = "Music";
            chkbox_music.UseVisualStyleBackColor = true;
            chkbox_music.CheckedChanged += chkbox_music_CheckedChanged;
            // 
            // chkbox_other
            // 
            chkbox_other.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkbox_other.AutoSize = true;
            chkbox_other.Location = new Point(272, 113);
            chkbox_other.Name = "chkbox_other";
            chkbox_other.Size = new Size(56, 19);
            chkbox_other.TabIndex = 3;
            chkbox_other.Text = "Other";
            chkbox_other.UseVisualStyleBackColor = true;
            chkbox_other.CheckedChanged += chkbox_other_CheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(207, 38);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 4;
            label3.Text = "Detected media types:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // file_info_label
            // 
            file_info_label.AutoSize = true;
            file_info_label.Location = new Point(14, 144);
            file_info_label.Name = "file_info_label";
            file_info_label.Size = new Size(28, 15);
            file_info_label.TabIndex = 6;
            file_info_label.Text = "File:";
            // 
            // file_selected_label
            // 
            file_selected_label.AutoSize = true;
            file_selected_label.Location = new Point(48, 144);
            file_selected_label.Name = "file_selected_label";
            file_selected_label.Size = new Size(34, 15);
            file_selected_label.TabIndex = 7;
            file_selected_label.Text = "none";
            // 
            // browse_file_btn
            // 
            browse_file_btn.Location = new Point(14, 162);
            browse_file_btn.Name = "browse_file_btn";
            browse_file_btn.Size = new Size(75, 23);
            browse_file_btn.TabIndex = 8;
            browse_file_btn.Text = "Browse";
            browse_file_btn.UseVisualStyleBackColor = true;
            browse_file_btn.Click += button1_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(207, 154);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 9;
            label7.Text = "Output Format:";
            // 
            // chkbox_genres
            // 
            chkbox_genres.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkbox_genres.AutoSize = true;
            chkbox_genres.Location = new Point(272, 181);
            chkbox_genres.Name = "chkbox_genres";
            chkbox_genres.Size = new Size(62, 19);
            chkbox_genres.TabIndex = 10;
            chkbox_genres.Text = "Genres";
            chkbox_genres.UseVisualStyleBackColor = true;
            chkbox_genres.CheckedChanged += chkbox_genres_CheckedChanged;
            // 
            // chkbox_albumname
            // 
            chkbox_albumname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkbox_albumname.AutoSize = true;
            chkbox_albumname.Location = new Point(272, 206);
            chkbox_albumname.Name = "chkbox_albumname";
            chkbox_albumname.Size = new Size(87, 19);
            chkbox_albumname.TabIndex = 11;
            chkbox_albumname.Text = "Album Title";
            chkbox_albumname.UseVisualStyleBackColor = true;
            chkbox_albumname.CheckedChanged += chkbox_albumname_CheckedChanged;
            // 
            // chkbox_artistname
            // 
            chkbox_artistname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkbox_artistname.AutoSize = true;
            chkbox_artistname.Checked = true;
            chkbox_artistname.CheckState = CheckState.Checked;
            chkbox_artistname.Location = new Point(272, 231);
            chkbox_artistname.Name = "chkbox_artistname";
            chkbox_artistname.Size = new Size(89, 19);
            chkbox_artistname.TabIndex = 12;
            chkbox_artistname.Text = "Artist Name";
            chkbox_artistname.UseVisualStyleBackColor = true;
            chkbox_artistname.CheckedChanged += chkbox_artistname_CheckedChanged;
            // 
            // chkbox_songname
            // 
            chkbox_songname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkbox_songname.AutoSize = true;
            chkbox_songname.Checked = true;
            chkbox_songname.CheckState = CheckState.Checked;
            chkbox_songname.Location = new Point(272, 256);
            chkbox_songname.Name = "chkbox_songname";
            chkbox_songname.Size = new Size(78, 19);
            chkbox_songname.TabIndex = 13;
            chkbox_songname.Text = "Song Title";
            chkbox_songname.UseVisualStyleBackColor = true;
            chkbox_songname.CheckedChanged += chkbox_songname_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 84);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 14;
            label8.Text = "Monitoring:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 283);
            Controls.Add(label8);
            Controls.Add(chkbox_songname);
            Controls.Add(chkbox_artistname);
            Controls.Add(chkbox_albumname);
            Controls.Add(chkbox_genres);
            Controls.Add(label7);
            Controls.Add(browse_file_btn);
            Controls.Add(file_selected_label);
            Controls.Add(file_info_label);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chkbox_other);
            Controls.Add(chkbox_music);
            Controls.Add(enabled_btn);
            Controls.Add(chkbox_video);
            Controls.Add(now_playing_label_text);
            Controls.Add(now_playing_label);
            Name = "Form1";
            Text = "SongNameGrabber";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label now_playing_label;
        private System.Windows.Forms.Timer timer1;
        private Label now_playing_label_text;
        private Button enabled_btn;
        private CheckBox chkbox_music;
        private CheckBox chkbox_video;
        private CheckBox chkbox_other;
        private Label label3;
        private Label label4;
        private Label file_info_label;
        private Label file_selected_label;
        private Button browse_file_btn;
        private Label label7;
        private CheckBox chkbox_genres;
        private CheckBox chkbox_albumname;
        private CheckBox chkbox_artistname;
        private CheckBox chkbox_songname;
        private Label label8;
    }
}