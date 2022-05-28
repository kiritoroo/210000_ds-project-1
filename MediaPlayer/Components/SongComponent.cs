using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Components
{
    public partial class SongComponent : UserControl
    {
        private frmMediaPlayer frm;

        public SongComponent(frmMediaPlayer _frm)
        {
            InitializeComponent();

            isCurrent = false;

            this.frm = _frm;
            Timer tmr = new Timer();
            tmr.Interval = 10;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        public bool isCurrent;

        private void SongComponent_Load(object sender, EventArgs e)
        {
            if (lblTitle.Size.Width > 150)
                lblTitle.Text = lblTitle.Text.Substring(0, 20) + "...";
        }

        #region Properties
        private string _title;
        private string _year;
        private TimeSpan _duration;
        private Image _image;
        private Image _icon;
        private int _index;


        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Year
        {
            get { return _year; }
            set { _year = value; lblYear.Text = value; }
        }

        [Category("Custom Props")]
        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; lblDuration.Text = value.ToString("mm':'ss"); }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; ptbImage.Image = value; }
        }

        [Category("Custom Props")]
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; btnPlay.Image = value; }
        }

        #endregion

        public void SetColorPanel(Color color)
        {
            this.BackColor = color;
            borderBottom.BackColor = color;
        }

        //-----Event region
        #region Event
        private void SongItem_MouseEnter(object sender, EventArgs e)
        {
            if (isCurrent == false)
                borderBottom.BackColor = Color.FromArgb(205, 236, 250);
        }

        private void SongItem_MouseLeave(object sender, EventArgs e)
        {
            if (isCurrent == false)
                borderBottom.BackColor = Color.White;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            isCurrent = true;
            frm.PlayIndex(this.Index);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            isCurrent = false;
            frm.Remove(this.Index);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {

        } 
        #endregion
    }
}
