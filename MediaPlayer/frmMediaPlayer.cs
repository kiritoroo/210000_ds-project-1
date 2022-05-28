using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MediaPlayer.Components;
using MediaPlayer.Structures;
using MediaPlayer.Handlers;
using MediaPlayer.Properties;

namespace MediaPlayer
{
    public partial class frmMediaPlayer : Form
    {
        #region Properties
        private SongHandler songHandler;
        private SongComponentHandler songComponentHandler;

        //Check variables
        private bool isMoreOpen;
        private bool isPlayListOpen;
        private bool isPlaying;
        private bool isMute;
        private bool isNext;
        private bool isLoop;
        private bool isRandom;
        private int timeSleep;
        private int currentSongIndexPlay;
        private Random rand;
        #endregion

        public frmMediaPlayer()
        {
            InitializeComponent();
        }

        private void frmMediaPlayer_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            songHandler = new SongHandler();
            songComponentHandler = new SongComponentHandler(flowpnPlayList, this);

            //Init value
            isMoreOpen = false;
            isPlayListOpen = false;
            isPlaying = false;
            isMute = false;
            isNext = false;
            isLoop = false;
            isRandom = false;
            timeSleep = 0;
            currentSongIndexPlay = default;
            rand = new Random();

            pnMore.Size = new Size(70, pnMore.Size.Height);
            pnPlayList.Size = new Size(70, pnPlayList.Size.Height);
            pnPlayList.Location = new Point(394, 108);

            btnMore.Image = Resources.icon_open;
            btnPlay.Image = Resources.icon_play;
            btnLoop.Image = Resources.icon_notloop;
            btnRandom.Image = Resources.icon_notrandom;

            lblTitle.Text = "";
            lblYear.Text = "";
            lblDurationRealTime.Text = "00:00";
            lblDurationTotal.Text = "00:00";
            ptbStatus.Image = Resources.icon_soundWave;

            sliderDuration.Value = 0;
            sliderVolume.Value = 50;
            songHandler.wmplayer.settings.volume = 50;

            AlignmentAllCenter();

            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        } 

        #region Xử lí
        //----------Xử lí...
        private void _Update()
        {
            //cập nhật thông tin bản nhạc
            string title = songHandler.currentSong.title;
            string year = songHandler.currentSong.year;
            string duration = songHandler.currentSong.duration.ToString("mm':'ss");
            Image image = songHandler.currentSong.image;

            lblTitle.Text = title;
            lblYear.Text = year;
            lblDurationTotal.Text = duration;
            sliderDuration.Maximum = (int)songHandler.currentSong.duration.TotalSeconds;

            //Cập nhật hình ảnh
            int ratio = image.Height / ptbImage.Height;
            image = resizeImage(image, new Size(image.Width / ratio, image.Height / ratio));
            ptbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbImage.Image = image;

            //Căn giữa
            AlignmentAllCenter();
        }

        private void AlignmentAllCenter()
        {
            lblTitle.Location = new Point(pnMain.Width / 2 - lblTitle.Width / 2, lblTitle.Location.Y);
            lblYear.Location = new Point(pnMain.Width / 2 - lblYear.Width / 2, lblYear.Location.Y);
            ptbStatus.Location = new Point(pnMain.Width / 2 - ptbStatus.Width / 2, ptbStatus.Location.Y);
        }

        private void ChangeColorPanel()
        {
            //Status Playing: Chuyển sang màu xanh lá
            if (isPlaying == true)
            {
                pnMain.GradientTopLeft = Color.FromArgb(183, 252, 199);
                pnMain.GradientTopRight = Color.FromArgb(183, 252, 199);
            }
            //Status Pase/Stop: Chuyển sang màu xanh dương 
            else
            {
                pnMain.GradientTopLeft = Color.FromArgb(222, 243, 252);
                pnMain.GradientTopRight = Color.FromArgb(222, 243, 252);
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        } 
        #endregion


        #region Event
        //----------Event region
        private void tmr_Tick(object sender, EventArgs e)
        {
            if (songHandler.currentSong == null)
                return;

            //Duration real time và thanh duration
            if (isPlaying == true)
            {
                lblDurationRealTime.Text = TimeSpan.FromSeconds(songHandler.wmplayer.controls.currentPosition).ToString("mm':'ss");
                sliderDuration.Value = (int)songHandler.wmplayer.controls.currentPosition;
            }

            //Check hết bài nhạc, next song
            if (songHandler.wmplayer.controls.currentPosition > songHandler.currentSong.duration.TotalSeconds - 1)
            {
                isNext = true;
                isPlaying = false;
                ptbStatus.Image = Resources.icon_soundWave;
                btnPlay.Image = Resources.icon_play;
                sliderDuration.Value = 0;
                lblDurationRealTime.Text = "00:00";

                songComponentHandler.ResetAll();

                AlignmentAllCenter();
                ChangeColorPanel();

                songHandler.currentPosition = 0;
            }

            if (isNext == true)
            {
                timeSleep++;
                if (timeSleep == 2)
                {
                    if (isLoop == false && isRandom == false)
                        this.NextSong();

                    if (isLoop == false && isRandom == true)
                        this.PlayIndex(rand.Next(songHandler.totalSong - 1));

                    if (isLoop == true && isRandom == false)
                        this.PlaySong();

                    timeSleep = 0;
                    isNext = false;
                }
            }

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "File nhạc (*.mp3)|*.mp3;";

            if (open.ShowDialog() != DialogResult.OK)
                return;
            if (songHandler.AddSong(open.FileName) == false)
                return;

            songComponentHandler.AddSong(songHandler.muslicList.GetLast());

            //cập nhật
            isPlaying = true;
            currentSongIndexPlay = songHandler.totalSong - 1;
            btnPlay.Image = Resources.icon_pause;
            ptbStatus.Image = Resources.gif_soundWave;
            ChangeColorPanel();

            _Update();
        }

        //Mở bài nhạc theo index
        public void PlayIndex(int index)
        {
            btnPlay.Image = Resources.icon_pause;
            ptbStatus.Image = Resources.gif_soundWave;

            isPlaying = true;
            currentSongIndexPlay = index;

            songHandler.PlayIndex(index);
            songComponentHandler.ResetAll();
            songComponentHandler.SetPlay(index);

            ChangeColorPanel();
            _Update();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.PlaySong();
        }

        private void PlaySong()
        {
            if (songHandler.currentSong == null && songHandler.currentNodeSong == null && songHandler.totalSong == 0)
            {
                DialogResult = MessageBox.Show("Bạn chưa thêm bản nhạc nào cả z.z.z", "Thêm nhạc nào !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (isPlaying == false)
            {
                btnPlay.Image = Resources.icon_pause;
                ptbStatus.Image = Resources.gif_soundWave;

                isPlaying = true;
                songHandler.Play();
                songComponentHandler.ResetAll();
                songComponentHandler.SetPlay(currentSongIndexPlay);

                ChangeColorPanel();
                _Update();
            }
            else
            {
                btnPlay.Image = Resources.icon_play;
                ptbStatus.Image = Resources.icon_soundWave;
                songHandler.Pause();
                isPlaying = false;
                ChangeColorPanel();
                _Update();
            }
        }

        public void Remove(int index)
        {
            if (currentSongIndexPlay == index)
            {
                MessageBox.Show("Bài nhạc đang phát, bạn không thể xóa", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            songHandler.RemoveSong(index);
            songComponentHandler.RemoveSong(index);

            //curret < remove -> giữ nguyên
            //remove > current -> giảm 1
            if (currentSongIndexPlay > index)
                currentSongIndexPlay--;

            songComponentHandler.SetPlay(currentSongIndexPlay);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.PrevSong();
        }

        private void PrevSong()
        {
            if (songHandler.currentNodeSong == null || currentSongIndexPlay == 0)
            {
                return;
            }

            if (songHandler.currentNodeSong.GetNodePrev() == null)
            {
                return;
            }

            isPlaying = true;
            btnPlay.Image = Resources.icon_pause;
            ptbStatus.Image = Resources.gif_soundWave;
            currentSongIndexPlay--;

            songHandler.PrevSong();
            songComponentHandler.ResetAll();
            songComponentHandler.SetPlay(currentSongIndexPlay);

            ChangeColorPanel();
            _Update();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.NextSong();
        }

        private void NextSong()
        {
            if (songHandler.currentNodeSong == null || currentSongIndexPlay == songHandler.totalSong - 1)
            {
                return;
            }

            if (songHandler.currentNodeSong.GetNodeNext() == null)
            {
                return;
            }

            isPlaying = true;
            btnPlay.Image = Resources.icon_pause;
            ptbStatus.Image = Resources.gif_soundWave;
            currentSongIndexPlay++;

            songHandler.NextSong();
            songComponentHandler.ResetAll();
            songComponentHandler.SetPlay(currentSongIndexPlay);

            ChangeColorPanel();
            _Update();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            //mode loop
            if (isLoop == false)
            {
                btnLoop.Image = Resources.icon_loop;
                isRandom = false;
                btnRandom.Image = Resources.icon_notrandom;
                isLoop = true;
            }
            //mode not loop
            else
            {
                btnLoop.Image = Resources.icon_notloop;
                isLoop = false;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //mode random
            if (isRandom == false)
            {
                btnRandom.Image = Resources.icon_random;
                isLoop = false;
                btnLoop.Image = Resources.icon_notloop;
                isRandom = true;
            }
            //mode not random
            else
            {
                btnRandom.Image = Resources.icon_notrandom;
                isRandom = false;
            }
        }

        //-----Option

        //Mở mục more
        private void btnMore_Click(object sender, EventArgs e)
        {
            if (isMoreOpen == false)
            {
                pnMore.Size = new Size(230, pnMore.Size.Height);
                btnMore.Image = Resources.icon_back;
                isMoreOpen = true;
            }
            else
            {
                pnMore.Size = new Size(80, pnMore.Size.Height);
                btnMore.Image = Resources.icon_open;
                isMoreOpen = false;
            }
        }

        //mở mục danh sách nhạc
        private void btnPlayList_Click(object sender, EventArgs e)
        {
            //Open Play list
            if (isPlayListOpen == false)
            {
                pnPlayList.Size = new Size(440, pnPlayList.Size.Height);
                pnPlayList.Location = new Point(26, 108);
                isPlayListOpen = true;
            }
            //Close Play List
            else
            {
                pnPlayList.Size = new Size(70, pnPlayList.Size.Height);
                pnPlayList.Location = new Point(394, 108);
                isPlayListOpen = false;
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            if (isMute == true)
            {
                btnVolume.Image = Resources.icon_volume;
                songHandler.wmplayer.settings.mute = false;
                isMute = false;
            }
            else
            {
                btnVolume.Image = Resources.icon_mute;
                songHandler.wmplayer.settings.mute = true;
                isMute = true;
            }
        }

        private void sliderVolume_ValueChanged(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ValueChangedEventArgs e)
        {
            songHandler.wmplayer.settings.volume = sliderVolume.Value;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giảng viên hướng dẫn: Cô Lê Thị Minh Châu \n\nThành viên nhóm: \n20110587 Lê Kiên Trung \n20110568 Nguyễn Hữu Thắng \n18110137 Điều Thị Diễm Kiều ", "Projects cuối kì", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
    #endregion
}
