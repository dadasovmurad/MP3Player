using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MP3_Player
{
    public class Sound
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdcallback);
        public static int musicCount = 0;
        public static List<string> musiclist = new List<string>();
        public static bool newload = true;
        public void Open(string filename)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias Mediafile";
            string command = string.Format(Format, filename);
            mciSendString(command, null, 0, 0);
        }
        public void Play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void Stop()
        {
            var command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void Close()
        {
            var command = "close MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void Save(List<string> items)
        {
            try
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Mp3 Player Musics";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                foreach (var item in items)
                {
                    File.Copy(item, path + "\\" + NameParse(item));
                }
            }
            catch (Exception) {  }
        }
        public void Remove()
        {
            try
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Mp3 Player Musics";
                if (Directory.Exists(path))
                {
                    var data = Directory.GetFiles(path);
                    foreach (var item in data)
                    {
                        File.Delete(item);
                    }
                }

            }
            catch (Exception) { }
        }
        public List<string> Select()
        {
            try
            {
                List<string> items = new List<string>();
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Mp3 Player Musics";
                if (Directory.Exists(path))
                {
                    var data = Directory.GetFiles(path);
                    foreach (var item in data)
                    {
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception) { return null;}
        }
        public string NameParse(string filename)
        {
			string [] b = filename.Split('\\');
			int index = 0;
            for (int i = 0; i < b.Length; i++)
            {
                index++;
            }
			return b[index-1];
        }
        public void SetVolume(int volume)
        {
            var command = "setaudio MediaFile volume to " + volume.ToString();
            mciSendString(command, null, 0, 0);
        }
        public void GetSongLenght(int volume)
        {
            var command = "setstatus MediaFile length to " + volume.ToString();
            mciSendString(command, null, 0, 0);
        }
        public string mp3_Durum()
        {
            int i = 128;
            StringBuilder str = new StringBuilder(i);
            mciSendString("status MediaFile mode", str, i, 0);
            return str.ToString();
        }
        private TimeSpan _ts_ToplamSure;
        private double _ms_ToplamSure = 0;
        public int _sn_ToplamSure = 0;
        public string _st_ToplamSure = "";
        public void ToplamSure()
        {
            StringBuilder str = new StringBuilder(128);
            var command = " status MediaFile length";
            mciSendString(command, str, 128, 0);
            try
            {
                _ms_ToplamSure = Convert.ToDouble(str.ToString());
            }
            catch (FormatException) { }
            try
            {
                _sn_ToplamSure = Convert.ToInt32(TimeSpan.FromMilliseconds(_ms_ToplamSure).TotalSeconds);

                _ts_ToplamSure = TimeSpan.FromMilliseconds(_ms_ToplamSure);
                _st_ToplamSure = string.Format("{0:D2}:{1:D2}:{2:D2}",
                   _ts_ToplamSure.Hours,
                   _ts_ToplamSure.Minutes,
                   _ts_ToplamSure.Seconds);
            }
            catch (InvalidCastException) { }
        }
        public TimeSpan _ts_Pozisyon;
        private double _ms_Pozisyon = 0;
        public int _sn_Pozisyon = 0;
        public string _st_Pozisyon = "";
        public void Pozisyon()
        {
            StringBuilder str = new StringBuilder(128);
            var command = "status MediaFile position";
            mciSendString(command, str, 128, 0);
            try
            {
                _ms_Pozisyon = Convert.ToDouble(str.ToString());
            }
            catch (FormatException) { }
            try
            {
                _sn_Pozisyon = Convert.ToInt32(TimeSpan.FromMilliseconds(_ms_Pozisyon).TotalSeconds);

                _ts_Pozisyon = TimeSpan.FromMilliseconds(_ms_Pozisyon);
                _st_Pozisyon = string.Format("{0:D2}:{1:D2}:{2:D2}",
                   _ts_Pozisyon.Hours,
                   _ts_Pozisyon.Minutes,
                   _ts_Pozisyon.Seconds);
            }
            catch (InvalidCastException) { }
        }
        public void IleriGeriSar(double ms)
        {
            mciSendString("seek MediaFile to " + ms, null, 0, 0);
        }
        public void mp3_Oynat(bool loop)
        {
            var commmand = "play MediaFile";
            if (loop)
                commmand += " REPEAT";
            mciSendString(commmand, null, 0, 0);
        }
        public int MotherSound
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile volume to ", value), null, 0, 0);
            }
        }
        public int LeftSound
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile left volume to ", value), null, 0, 0);
            }
        }
        public int RightSound
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile right volume to ", value), null, 0, 0);
            }
        }
        public int TizSound
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile treble to ", value), null, 0, 0);
            }
        }
        public int BassSound
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile bass to ", value), null, 0, 0);
            }
        }
    }
}
