using System.Text.Json;
using System.Text.Json.Serialization;

namespace SongNameGrabber
{
    public partial class Form1 : Form
    {

        SongGrabber grabber;
        bool monitoring_enabled = true;
        SavedData savedata;
        public Form1()
        {
            InitializeComponent();
            savedata = new SavedData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grabber = new SongGrabber(this);

            try
            {
                string jsonstring = File.ReadAllText("settings.json");
                savedata = JsonSerializer.Deserialize<SavedData>(jsonstring)!;

                chkbox_music.Checked       = savedata.chkbox_music;
                chkbox_video.Checked       = savedata.chkbox_video;       
                chkbox_other.Checked       = savedata.chkbox_other;       

                chkbox_genres.Checked      = savedata.chkbox_genres;   
                chkbox_albumname.Checked   = savedata.chkbox_albumname; 
                chkbox_artistname.Checked  = savedata.chkbox_artistname; 
                chkbox_songname.Checked    = savedata.chkbox_songname;

                file_selected_label.Text = savedata.filename;

            }
            catch (Exception)
            {
                MessageBox.Show("Could not load saved data");
                
            }
            
            updateChkBoxes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label2.Text = grabber.manager.IsStarted.ToString();
        }

        public void SetNowPlayingText(string text)
        {
            now_playing_label.Invoke((MethodInvoker)(() =>
            {
                now_playing_label.Text = text;

                try
                {
                    File.WriteAllText(savedata.filepath!, text);
                }
                catch (Exception)
                {
                    
                }
                
            }));
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            savedata.filepath = openFileDialog1.FileName;
            savedata.filename = openFileDialog1.SafeFileName;
            file_selected_label.Text = openFileDialog1.SafeFileName;

        }


        private void enabled_btn_Click(object sender, EventArgs e)
        {
            if (monitoring_enabled)
            {
                grabber.manager.Dispose();
                now_playing_label.Text = "none";
                enabled_btn.Text = "Disabled";
                monitoring_enabled = false;
            }
            else
            {
                grabber.manager.Start();
                enabled_btn.Text = "Enabled";
                grabber.manager.ForceUpdate();
                monitoring_enabled = true;
            }

        }
        private void updateChkBoxes()
        {
            grabber.enablemusic = chkbox_music.Checked;
            grabber.enablevideo = chkbox_video.Checked;
            grabber.enableother = chkbox_other.Checked;

            grabber.showgenres = chkbox_genres.Checked;
            grabber.showalbumname = chkbox_albumname.Checked;
            grabber.showartistname = chkbox_artistname.Checked;
            grabber.showsongname = chkbox_songname.Checked;

            grabber.manager.ForceUpdate();
        }

        private void chkbox_music_CheckedChanged(object sender, EventArgs e)
        {
            updateChkBoxes();
        }

        private void chkbox_video_CheckedChanged(object sender, EventArgs e)
        {
            updateChkBoxes();
        }

        private void chkbox_other_CheckedChanged(object sender, EventArgs e)
        {
            updateChkBoxes();
        }

        private void chkbox_albumname_CheckedChanged(object sender, EventArgs e)
        {
            updateChkBoxes();
        }

        private void chkbox_genres_CheckedChanged(object sender, EventArgs e)
        {
            updateChkBoxes();
        }

        private void chkbox_artistname_CheckedChanged(object sender, EventArgs e)
        {
            updateChkBoxes();
        }

        private void chkbox_songname_CheckedChanged(object sender, EventArgs e)
        {
            updateChkBoxes();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                savedata.chkbox_music = chkbox_music.Checked;
                savedata.chkbox_video = chkbox_video.Checked;
                savedata.chkbox_other = chkbox_other.Checked;

                savedata.chkbox_genres = chkbox_genres.Checked;
                savedata.chkbox_albumname = chkbox_albumname.Checked;
                savedata.chkbox_artistname = chkbox_artistname.Checked;
                savedata.chkbox_songname = chkbox_songname.Checked;

                string jsonstring = JsonSerializer.Serialize(savedata);
                File.WriteAllText("settings.json", jsonstring);
                File.WriteAllText(savedata.filepath!, "Playback Offline");
            }
            catch (Exception)
            {

                MessageBox.Show("Error saving data");
            }
            
        }
    }
}