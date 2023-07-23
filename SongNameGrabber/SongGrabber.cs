using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Control;
using static SongNameGrabber.MediaManager;

namespace SongNameGrabber
{
    internal class SongGrabber
    {

        public MediaManager manager;
        Form1 containingForm;

        public bool showgenres = false;
        public bool showalbumname = false;
        public bool showartistname = false;
        public bool showsongname = false;

        public bool enablemusic = false;
        public bool enablevideo = false;
        public bool enableother = false;

        public string playbackstatus = "";
        public string playbacktype = "";

        

        public SongGrabber(Form1 containingForm)
        {
            this.containingForm = containingForm;
            manager = new MediaManager();
            if (!manager.IsStarted)
            {
                manager.Start();
            }

            manager.OnAnyPlaybackStateChanged += (MediaSession mediaSession, GlobalSystemMediaTransportControlsSessionPlaybackInfo playbackInfo) => {
                playbackstatus = playbackInfo.PlaybackStatus.ToString();
                playbacktype = playbackInfo.PlaybackType.ToString();
            };

            manager.OnAnyMediaPropertyChanged += (MediaSession mediaSession, GlobalSystemMediaTransportControlsSessionMediaProperties mediaProperties) => {
                
                if (!isMonitored(playbacktype))
                {
                    return;
                }
                containingForm.SetNowPlayingText(grabSong(mediaProperties));
            };


            manager.ForceUpdate();
            
        }

        private string grabSong(GlobalSystemMediaTransportControlsSessionMediaProperties mediaProperties)
        {
            
            bool first = true;
            StringBuilder builder = new StringBuilder();
            if (showgenres)
            {
                if (mediaProperties.Genres.Count != 0)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        builder.Append(" - ");
                    }

                    foreach (var genre in mediaProperties.Genres)
                    {
                        builder.Append(genre).Append(" ");
                    }
                }

            }

            if (showalbumname)
            {
                if (mediaProperties.AlbumTitle != "")
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        builder.Append(" - ");
                    }
                    builder.Append(mediaProperties.AlbumTitle);
                }

            }

            if (showartistname)
            {
                if (mediaProperties.Artist != "")
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        builder.Append(" - ");
                    }
                    builder.Append(mediaProperties.Artist);
                }

            }

            if (showsongname)
            {
                if (mediaProperties.Title != "")
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        builder.Append(" - ");
                    }
                    builder.Append(mediaProperties.Title);
                }

            }
            return builder.ToString();
            


        }

        public bool isMonitored(string name)
        {
            if (name == "Music" && enablemusic)
            {
                return true;
            }
            if (name == "Video" && enablevideo)
            {
                return true;
            }
            if (name == "Other" && enableother)
            {
                return true;
            }
            return false;
        }
    }
}
