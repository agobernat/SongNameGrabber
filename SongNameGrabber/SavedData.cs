using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongNameGrabber
{
    internal class SavedData
    {
        public string? filepath  { get; set; }
        public string? filename  { get; set; }

        public bool chkbox_music { get; set; }
        public bool chkbox_video { get; set; }
        public bool chkbox_other { get; set; }

        public bool chkbox_genres { get; set; }
        public bool chkbox_albumname { get; set; }
        public bool chkbox_artistname { get; set; }
        public bool chkbox_songname { get; set; }


    }

}
