using System;
using MediaPlayer.Structures;
using MediaPlayer.Objects;
using System.IO;
using NAudio.Wave;
using System.Drawing;
using MediaPlayer.Properties;
using System.Windows.Forms;

namespace MediaPlayer.Handlers
{
    public class SongHandler
    {
        public LinkedList<Song> muslicList =new LinkedList<Song>();

        //Check Variables
        public Node<Song> currentNodeSong;
        public Song currentSong;
        public double currentPosition; //thời gian phát hiện tại
        public int totalSong; //tổng số bài nhạc

        //Xử lý file media
        public WMPLib.WindowsMediaPlayer wmplayer;
        private TagLib.File tagMedia;
        private MemoryStream ms;
        private Mp3FileReader rmp3;


        public SongHandler()
        {
            wmplayer = new WMPLib.WindowsMediaPlayer();

            currentNodeSong = null;
            currentSong = null;
            currentPosition = default;
            totalSong = 0;

            tagMedia = null;
            ms = null;
            rmp3 = null;
        }

        public void Play()
        {
            if (currentNodeSong == null || currentSong == null || totalSong == 0)
                return;

            wmplayer.URL = currentSong.filePath;
            if (currentPosition != 0)
            {
                wmplayer.controls.currentPosition = currentPosition;
            }

            wmplayer.controls.play();
        }

        public void PlayIndex(int index)
        {
            currentNodeSong = muslicList.Node(index);
            currentSong = currentNodeSong.GetItem();

            currentPosition = 0;
            this.Play();
        }

        public void Pause()
        {
            if (currentNodeSong == null || currentSong == null || totalSong == 0)
                return;
            
            wmplayer.controls.pause();
            currentPosition = wmplayer.controls.currentPosition;
        }

        public void Stop()
        {
            if (currentNodeSong == null || currentSong == null || totalSong == 0)
                return;

            wmplayer.controls.stop();
            currentPosition = 0;
        }
        public void PrevSong()
        {
            if (currentNodeSong == null || currentSong == null || totalSong == 0)
                return;

            currentNodeSong = currentNodeSong.GetNodePrev();
            currentSong = currentNodeSong.GetItem();

            currentPosition = 0;
            this.Play();

        }

        public void NextSong()
        {
            if (currentNodeSong == null || currentSong == null || totalSong == 0)
                return;

            currentNodeSong = currentNodeSong.GetNodeNext();
            currentSong = currentNodeSong.GetItem();

            currentPosition = 0;
            this.Play();
        }


        public bool AddSong(string filePath)
        {
            tagMedia = null;
            ms = null;
            rmp3 = null;

            tagMedia = TagLib.File.Create(filePath);
            try
            {
                ms = new MemoryStream(tagMedia.Tag.Pictures[0].Data.Data);
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                rmp3 = new Mp3FileReader(filePath);
            } catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Bản nhạc này bị sao í, không thể thêm được !", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            string _filePath = filePath;
            string title = tagMedia.Tag.Title;
            string year = tagMedia.Tag.Year.ToString();
            TimeSpan duration = rmp3.TotalTime;
            Image image = Resources.icon_songDefault;

            if (ms != null)
                image = Image.FromStream(ms);
            if (title == null)
                title = Path.GetFileNameWithoutExtension(filePath);
            if (year == "0")
                year = "Unknow";

            Song newSong = new Song(_filePath, title, year, duration, image);
            this.muslicList.AddLast(newSong);
            totalSong++;

            currentNodeSong = this.muslicList.Node(totalSong - 1);
            currentSong = currentNodeSong.GetItem();
            currentPosition = 0;

            this.Play();

            return true;
        }

        public void RemoveSong(int index)
        {
            muslicList.Remove(index);
            totalSong--;
        }


    }
}
