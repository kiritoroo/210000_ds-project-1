namespace MediaPlayer.Components
{
    partial class SongComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongComponent));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblYear = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDuration = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnAnim = new System.Windows.Forms.Panel();
            this.borderBottom = new System.Windows.Forms.Panel();
            this.ptbImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnRemove = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.pnAnim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTitle.Location = new System.Drawing.Point(4, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(29, 21);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblTitle.MouseEnter += new System.EventHandler(this.SongItem_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.SongItem_MouseLeave);
            // 
            // lblYear
            // 
            this.lblYear.AllowParentOverrides = false;
            this.lblYear.AutoEllipsis = false;
            this.lblYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblYear.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYear.Location = new System.Drawing.Point(146, 53);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2);
            this.lblYear.Name = "lblYear";
            this.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYear.Size = new System.Drawing.Size(26, 17);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblYear.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblYear.MouseEnter += new System.EventHandler(this.SongItem_MouseEnter);
            this.lblYear.MouseLeave += new System.EventHandler(this.SongItem_MouseLeave);
            // 
            // lblDuration
            // 
            this.lblDuration.AllowParentOverrides = false;
            this.lblDuration.AutoEllipsis = false;
            this.lblDuration.CursorType = null;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDuration.Location = new System.Drawing.Point(300, 32);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDuration.Size = new System.Drawing.Size(50, 17);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration";
            this.lblDuration.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDuration.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblDuration.MouseEnter += new System.EventHandler(this.SongItem_MouseEnter);
            this.lblDuration.MouseLeave += new System.EventHandler(this.SongItem_MouseLeave);
            // 
            // pnAnim
            // 
            this.pnAnim.Controls.Add(this.lblTitle);
            this.pnAnim.Location = new System.Drawing.Point(139, 8);
            this.pnAnim.Margin = new System.Windows.Forms.Padding(2);
            this.pnAnim.Name = "pnAnim";
            this.pnAnim.Size = new System.Drawing.Size(155, 35);
            this.pnAnim.TabIndex = 5;
            this.pnAnim.MouseEnter += new System.EventHandler(this.SongItem_MouseEnter);
            this.pnAnim.MouseLeave += new System.EventHandler(this.SongItem_MouseLeave);
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(127)))), ((int)(((byte)(153)))));
            this.borderBottom.Location = new System.Drawing.Point(0, 78);
            this.borderBottom.Margin = new System.Windows.Forms.Padding(2);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(360, 41);
            this.borderBottom.TabIndex = 6;
            // 
            // ptbImage
            // 
            this.ptbImage.AllowFocused = false;
            this.ptbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbImage.AutoSizeHeight = true;
            this.ptbImage.BorderRadius = 0;
            this.ptbImage.Image = global::MediaPlayer.Properties.Resources.icon_songDefault;
            this.ptbImage.IsCircle = true;
            this.ptbImage.Location = new System.Drawing.Point(64, 4);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(2);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(68, 68);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImage.TabIndex = 1;
            this.ptbImage.TabStop = false;
            this.ptbImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.ptbImage.MouseEnter += new System.EventHandler(this.SongItem_MouseEnter);
            this.ptbImage.MouseLeave += new System.EventHandler(this.SongItem_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.AllowAnimations = true;
            this.btnPlay.AllowBorderColorChanges = true;
            this.btnPlay.AllowMouseEffects = true;
            this.btnPlay.AnimationSpeed = 200;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundColor = System.Drawing.Color.White;
            this.btnPlay.BorderColor = System.Drawing.Color.White;
            this.btnPlay.BorderRadius = 1;
            this.btnPlay.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnPlay.BorderThickness = 1;
            this.btnPlay.ColorContrastOnClick = 30;
            this.btnPlay.ColorContrastOnHover = 30;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPlay.CustomizableEdges = borderEdges1;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.Image = global::MediaPlayer.Properties.Resources.icon_playRed;
            this.btnPlay.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Location = new System.Drawing.Point(12, 17);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RoundBorders = true;
            this.btnPlay.ShowBorders = true;
            this.btnPlay.Size = new System.Drawing.Size(45, 45);
            this.btnPlay.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.SongItem_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.SongItem_MouseLeave);
            // 
            // btnRemove
            // 
            this.btnRemove.AllowAnimations = true;
            this.btnRemove.AllowBorderColorChanges = true;
            this.btnRemove.AllowMouseEffects = true;
            this.btnRemove.AnimationSpeed = 200;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderRadius = 1;
            this.btnRemove.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnRemove.BorderThickness = 1;
            this.btnRemove.ColorContrastOnClick = 30;
            this.btnRemove.ColorContrastOnHover = 30;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRemove.CustomizableEdges = borderEdges2;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.Image = global::MediaPlayer.Properties.Resources.icon_x;
            this.btnRemove.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Location = new System.Drawing.Point(337, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.RoundBorders = true;
            this.btnRemove.ShowBorders = true;
            this.btnRemove.Size = new System.Drawing.Size(20, 20);
            this.btnRemove.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // SongComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.pnAnim);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRemove);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SongComponent";
            this.Size = new System.Drawing.Size(360, 81);
            this.Load += new System.EventHandler(this.SongComponent_Load);
            this.MouseEnter += new System.EventHandler(this.SongItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SongItem_MouseLeave);
            this.pnAnim.ResumeLayout(false);
            this.pnAnim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnPlay;
        private Bunifu.UI.WinForms.BunifuPictureBox ptbImage;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblYear;
        private Bunifu.UI.WinForms.BunifuLabel lblDuration;
        private System.Windows.Forms.Panel pnAnim;
        private System.Windows.Forms.Panel borderBottom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnRemove;
    }
}
