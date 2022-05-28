using MediaPlayer.Components;
using MediaPlayer.Structures;
using MediaPlayer.Objects;
using System.Windows.Forms;
using MediaPlayer.Properties;
using System.Drawing;

namespace MediaPlayer.Handlers
{
    public class SongComponentHandler
    {
        //Controls
        FlowLayoutPanel pnContain;
        frmMediaPlayer frmContain;

        public LinkedList<SongComponent> musicComponentList = new LinkedList<SongComponent>();

        //Check variables
        public Node<SongComponent> currentNodeSongComponent;
        public SongComponent currentSongComponent;
        public int totalSongComponent;


        public SongComponentHandler(FlowLayoutPanel _flowpn, frmMediaPlayer _frm)
        {
            this.pnContain = _flowpn;
            this.frmContain = _frm;

            currentNodeSongComponent = null;
            currentSongComponent = null;
            totalSongComponent = 0;
        }

        public void AddSong(Song song)
        {
            totalSongComponent++;

            SongComponent newComponet = new SongComponent(frmContain)
            {
                Title = song.title,
                Year = song.year,
                Duration = song.duration,
                Image = song.image,
                Index = totalSongComponent - 1,
                Icon = Resources.icon_playRed
            };

            musicComponentList.AddLast(newComponet);

            currentNodeSongComponent = musicComponentList.Node(totalSongComponent - 1);
            currentSongComponent = currentNodeSongComponent.GetItem();

            ResetAll();
            SetPlay(newComponet.Index);

            //Thêm vào flow panel
            pnContain.Controls.Add(currentSongComponent);
        }

        public void RemoveSong(int index)
        {
            musicComponentList.Remove(index);
            totalSongComponent--;

            _Refresh();
        }
        
        public void ResetAll()
        {
            for (int i = 0; i < totalSongComponent; i++)
            {
                musicComponentList.Get(i).Icon = Resources.icon_playRed;
                musicComponentList.Get(i).SetColorPanel(Color.White);
                musicComponentList.Get(i).isCurrent = false;
            }
        }

        public void SetPlay(int index)
        {
            musicComponentList.Get(index).Icon = Resources.icon_play;
            musicComponentList.Get(index).SetColorPanel(Color.FromArgb(243, 251, 254));
            musicComponentList.Get(index).isCurrent = true;
        }

        public void _Refresh()
        {
            pnContain.Controls.Clear();
            pnContain.Refresh();

            for (int i = 0; i < totalSongComponent; i ++)
            {
                musicComponentList.Get(i).Index = i;
                pnContain.Controls.Add(musicComponentList.Get(i));
            }
        }
    }
}
