namespace MediaPlayer
{
    partial class frmMediaPlayer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnBoss = new System.Windows.Forms.Panel();
            this.pnMain = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pnPlayList = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.flowpnPlayList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVolume = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.sliderVolume = new Bunifu.UI.WinForms.BunifuVSlider();
            this.lblDurationRealTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblYear = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDurationTotal = new Bunifu.UI.WinForms.BunifuLabel();
            this.sliderDuration = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.pnPicture = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.ptbImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pnList = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnPlayList = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.pnMore = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnOpenFile = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnMore = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnSetting = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.pnControls = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnRandom = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnLoop = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnPrev = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnNext = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.ptbStatus = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pnBoss.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnPlayList.SuspendLayout();
            this.pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.pnList.SuspendLayout();
            this.pnMore.SuspendLayout();
            this.pnControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.pnBoss;
            this.DragControl.Vertical = true;
            // 
            // pnBoss
            // 
            this.pnBoss.BackColor = System.Drawing.Color.White;
            this.pnBoss.Controls.Add(this.pnMain);
            this.pnBoss.Location = new System.Drawing.Point(105, 16);
            this.pnBoss.Margin = new System.Windows.Forms.Padding(2);
            this.pnBoss.Name = "pnBoss";
            this.pnBoss.Size = new System.Drawing.Size(472, 731);
            this.pnBoss.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.BorderRadius = 80;
            this.pnMain.Controls.Add(this.pnPlayList);
            this.pnMain.Controls.Add(this.lblDurationRealTime);
            this.pnMain.Controls.Add(this.lblTitle);
            this.pnMain.Controls.Add(this.lblYear);
            this.pnMain.Controls.Add(this.lblDurationTotal);
            this.pnMain.Controls.Add(this.sliderDuration);
            this.pnMain.Controls.Add(this.btnExit);
            this.pnMain.Controls.Add(this.pnPicture);
            this.pnMain.Controls.Add(this.pnList);
            this.pnMain.Controls.Add(this.pnMore);
            this.pnMain.Controls.Add(this.pnControls);
            this.pnMain.Controls.Add(this.ptbStatus);
            this.pnMain.GradientBottomLeft = System.Drawing.Color.White;
            this.pnMain.GradientBottomRight = System.Drawing.Color.White;
            this.pnMain.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.pnMain.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.pnMain.Location = new System.Drawing.Point(19, 12);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Quality = 10;
            this.pnMain.Size = new System.Drawing.Size(435, 703);
            this.pnMain.TabIndex = 0;
            // 
            // pnPlayList
            // 
            this.pnPlayList.BackColor = System.Drawing.Color.Transparent;
            this.pnPlayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnPlayList.BackgroundImage")));
            this.pnPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPlayList.BorderRadius = 60;
            this.pnPlayList.Controls.Add(this.flowpnPlayList);
            this.pnPlayList.Controls.Add(this.btnVolume);
            this.pnPlayList.Controls.Add(this.sliderVolume);
            this.pnPlayList.GradientBottomLeft = System.Drawing.Color.White;
            this.pnPlayList.GradientBottomRight = System.Drawing.Color.White;
            this.pnPlayList.GradientTopLeft = System.Drawing.Color.White;
            this.pnPlayList.GradientTopRight = System.Drawing.Color.White;
            this.pnPlayList.Location = new System.Drawing.Point(26, 108);
            this.pnPlayList.Margin = new System.Windows.Forms.Padding(2);
            this.pnPlayList.Name = "pnPlayList";
            this.pnPlayList.Quality = 10;
            this.pnPlayList.Size = new System.Drawing.Size(439, 345);
            this.pnPlayList.TabIndex = 4;
            // 
            // flowpnPlayList
            // 
            this.flowpnPlayList.AutoScroll = true;
            this.flowpnPlayList.Location = new System.Drawing.Point(44, 20);
            this.flowpnPlayList.Margin = new System.Windows.Forms.Padding(2);
            this.flowpnPlayList.Name = "flowpnPlayList";
            this.flowpnPlayList.Size = new System.Drawing.Size(395, 325);
            this.flowpnPlayList.TabIndex = 7;
            // 
            // btnVolume
            // 
            this.btnVolume.AllowAnimations = true;
            this.btnVolume.AllowBorderColorChanges = true;
            this.btnVolume.AllowMouseEffects = true;
            this.btnVolume.AnimationSpeed = 200;
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.BackgroundColor = System.Drawing.Color.White;
            this.btnVolume.BorderColor = System.Drawing.Color.White;
            this.btnVolume.BorderRadius = 1;
            this.btnVolume.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnVolume.BorderThickness = 1;
            this.btnVolume.ColorContrastOnClick = 30;
            this.btnVolume.ColorContrastOnHover = 30;
            this.btnVolume.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnVolume.CustomizableEdges = borderEdges1;
            this.btnVolume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVolume.Image = global::MediaPlayer.Properties.Resources.icon_volume;
            this.btnVolume.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnVolume.Location = new System.Drawing.Point(-1, 268);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.RoundBorders = true;
            this.btnVolume.ShowBorders = true;
            this.btnVolume.Size = new System.Drawing.Size(41, 41);
            this.btnVolume.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnVolume.TabIndex = 6;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // sliderVolume
            // 
            this.sliderVolume.AllowCursorChanges = true;
            this.sliderVolume.AllowHomeEndKeysDetection = false;
            this.sliderVolume.AllowIncrementalClickMoves = true;
            this.sliderVolume.AllowMouseDownEffects = false;
            this.sliderVolume.AllowMouseHoverEffects = false;
            this.sliderVolume.AllowScrollingAnimations = true;
            this.sliderVolume.AllowScrollKeysDetection = true;
            this.sliderVolume.AllowScrollOptionsMenu = true;
            this.sliderVolume.AllowShrinkingOnFocusLost = false;
            this.sliderVolume.BackColor = System.Drawing.Color.Transparent;
            this.sliderVolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderVolume.BackgroundImage")));
            this.sliderVolume.BindingContainer = null;
            this.sliderVolume.BorderRadius = 2;
            this.sliderVolume.BorderThickness = 1;
            this.sliderVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderVolume.DirectionalScroll = Utilities.BunifuSlider.BunifuVScrollBar.DirectionalMovements.BottomUp;
            this.sliderVolume.DrawThickBorder = false;
            this.sliderVolume.DurationBeforeShrink = 2000;
            this.sliderVolume.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.sliderVolume.LargeChange = 10;
            this.sliderVolume.Location = new System.Drawing.Point(5, 80);
            this.sliderVolume.Margin = new System.Windows.Forms.Padding(6);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Minimum = 0;
            this.sliderVolume.MinimumSize = new System.Drawing.Size(34, 0);
            this.sliderVolume.MinimumThumbLength = 18;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sliderVolume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sliderVolume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sliderVolume.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
            this.sliderVolume.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
            this.sliderVolume.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
            this.sliderVolume.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderVolume.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderVolume.ShrinkSizeLimit = 3;
            this.sliderVolume.Size = new System.Drawing.Size(34, 146);
            this.sliderVolume.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderVolume.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thin;
            this.sliderVolume.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
            this.sliderVolume.SmallChange = 1;
            this.sliderVolume.TabIndex = 5;
            this.sliderVolume.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.sliderVolume.ThumbFillColor = System.Drawing.Color.White;
            this.sliderVolume.ThumbLength = 18;
            this.sliderVolume.ThumbMargin = 1;
            this.sliderVolume.ThumbSize = Bunifu.UI.WinForms.BunifuVSlider.ThumbSizes.Medium;
            this.sliderVolume.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
            this.sliderVolume.Value = 50;
            this.sliderVolume.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ValueChangedEventArgs>(this.sliderVolume_ValueChanged);
            // 
            // lblDurationRealTime
            // 
            this.lblDurationRealTime.AllowParentOverrides = false;
            this.lblDurationRealTime.AutoEllipsis = false;
            this.lblDurationRealTime.CursorType = null;
            this.lblDurationRealTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDurationRealTime.Location = new System.Drawing.Point(26, 455);
            this.lblDurationRealTime.Margin = new System.Windows.Forms.Padding(2);
            this.lblDurationRealTime.Name = "lblDurationRealTime";
            this.lblDurationRealTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDurationRealTime.Size = new System.Drawing.Size(39, 21);
            this.lblDurationRealTime.TabIndex = 6;
            this.lblDurationRealTime.Text = "00:00";
            this.lblDurationRealTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDurationRealTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.CursorType = null;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTitle.Location = new System.Drawing.Point(165, 390);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(126, 28);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "See You Again";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblYear
            // 
            this.lblYear.AllowParentOverrides = false;
            this.lblYear.AutoEllipsis = false;
            this.lblYear.CursorType = null;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblYear.Location = new System.Drawing.Point(206, 423);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2);
            this.lblYear.Name = "lblYear";
            this.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYear.Size = new System.Drawing.Size(36, 21);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "2012";
            this.lblYear.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblYear.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblDurationTotal
            // 
            this.lblDurationTotal.AllowParentOverrides = false;
            this.lblDurationTotal.AutoEllipsis = false;
            this.lblDurationTotal.CursorType = null;
            this.lblDurationTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDurationTotal.Location = new System.Drawing.Point(390, 463);
            this.lblDurationTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblDurationTotal.Name = "lblDurationTotal";
            this.lblDurationTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDurationTotal.Size = new System.Drawing.Size(31, 17);
            this.lblDurationTotal.TabIndex = 7;
            this.lblDurationTotal.Text = "00:00";
            this.lblDurationTotal.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDurationTotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // sliderDuration
            // 
            this.sliderDuration.AllowCursorChanges = false;
            this.sliderDuration.AllowHomeEndKeysDetection = false;
            this.sliderDuration.AllowIncrementalClickMoves = true;
            this.sliderDuration.AllowMouseDownEffects = false;
            this.sliderDuration.AllowMouseHoverEffects = false;
            this.sliderDuration.AllowScrollingAnimations = true;
            this.sliderDuration.AllowScrollKeysDetection = true;
            this.sliderDuration.AllowScrollOptionsMenu = true;
            this.sliderDuration.AllowShrinkingOnFocusLost = false;
            this.sliderDuration.BackColor = System.Drawing.Color.Transparent;
            this.sliderDuration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderDuration.BackgroundImage")));
            this.sliderDuration.BindingContainer = null;
            this.sliderDuration.BorderRadius = 2;
            this.sliderDuration.BorderThickness = 1;
            this.sliderDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderDuration.DrawThickBorder = true;
            this.sliderDuration.DurationBeforeShrink = 2000;
            this.sliderDuration.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.sliderDuration.LargeChange = 10;
            this.sliderDuration.Location = new System.Drawing.Point(26, 471);
            this.sliderDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sliderDuration.Maximum = 100;
            this.sliderDuration.Minimum = 0;
            this.sliderDuration.MinimumSize = new System.Drawing.Size(0, 41);
            this.sliderDuration.MinimumThumbLength = 18;
            this.sliderDuration.Name = "sliderDuration";
            this.sliderDuration.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sliderDuration.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sliderDuration.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sliderDuration.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderDuration.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderDuration.ShrinkSizeLimit = 3;
            this.sliderDuration.Size = new System.Drawing.Size(390, 49);
            this.sliderDuration.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderDuration.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thick;
            this.sliderDuration.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sliderDuration.SmallChange = 1;
            this.sliderDuration.TabIndex = 5;
            this.sliderDuration.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.sliderDuration.ThumbFillColor = System.Drawing.Color.White;
            this.sliderDuration.ThumbLength = 38;
            this.sliderDuration.ThumbMargin = 1;
            this.sliderDuration.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Large;
            this.sliderDuration.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.sliderDuration.Value = 50;
            // 
            // btnExit
            // 
            this.btnExit.AllowAnimations = true;
            this.btnExit.AllowBorderColorChanges = true;
            this.btnExit.AllowMouseEffects = true;
            this.btnExit.AnimationSpeed = 200;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 1;
            this.btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnExit.BorderThickness = 1;
            this.btnExit.ColorContrastOnClick = 30;
            this.btnExit.ColorContrastOnHover = 30;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExit.CustomizableEdges = borderEdges2;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.Image = global::MediaPlayer.Properties.Resources.icon_exit;
            this.btnExit.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnExit.Location = new System.Drawing.Point(394, -8);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.RoundBorders = true;
            this.btnExit.ShowBorders = true;
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnPicture
            // 
            this.pnPicture.BackColor = System.Drawing.Color.Transparent;
            this.pnPicture.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnPicture.BorderRadius = 1;
            this.pnPicture.BorderThickness = 1;
            this.pnPicture.Controls.Add(this.ptbImage);
            this.pnPicture.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnPicture.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnPicture.Location = new System.Drawing.Point(94, 118);
            this.pnPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.pnPicture.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnPicture.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnPicture.ShadowDept = 2;
            this.pnPicture.ShadowDepth = 8;
            this.pnPicture.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.pnPicture.ShadowTopLeftVisible = false;
            this.pnPicture.Size = new System.Drawing.Size(248, 268);
            this.pnPicture.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnPicture.TabIndex = 3;
            // 
            // ptbImage
            // 
            this.ptbImage.AllowFocused = false;
            this.ptbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbImage.AutoSizeHeight = true;
            this.ptbImage.BorderRadius = 0;
            this.ptbImage.Image = global::MediaPlayer.Properties.Resources.icon_headphone;
            this.ptbImage.IsCircle = true;
            this.ptbImage.Location = new System.Drawing.Point(44, 43);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(2);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(158, 158);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            this.ptbImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // pnList
            // 
            this.pnList.BackColor = System.Drawing.Color.Transparent;
            this.pnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnList.BackgroundImage")));
            this.pnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnList.BorderRadius = 30;
            this.pnList.Controls.Add(this.btnPlayList);
            this.pnList.GradientBottomLeft = System.Drawing.Color.White;
            this.pnList.GradientBottomRight = System.Drawing.Color.White;
            this.pnList.GradientTopLeft = System.Drawing.Color.White;
            this.pnList.GradientTopRight = System.Drawing.Color.White;
            this.pnList.Location = new System.Drawing.Point(368, 50);
            this.pnList.Margin = new System.Windows.Forms.Padding(2);
            this.pnList.Name = "pnList";
            this.pnList.Quality = 10;
            this.pnList.Size = new System.Drawing.Size(82, 50);
            this.pnList.TabIndex = 2;
            // 
            // btnPlayList
            // 
            this.btnPlayList.AllowAnimations = true;
            this.btnPlayList.AllowBorderColorChanges = true;
            this.btnPlayList.AllowMouseEffects = true;
            this.btnPlayList.AnimationSpeed = 200;
            this.btnPlayList.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayList.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlayList.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlayList.BorderRadius = 1;
            this.btnPlayList.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnPlayList.BorderThickness = 1;
            this.btnPlayList.ColorContrastOnClick = 30;
            this.btnPlayList.ColorContrastOnHover = 30;
            this.btnPlayList.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnPlayList.CustomizableEdges = borderEdges3;
            this.btnPlayList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlayList.Image = global::MediaPlayer.Properties.Resources.icon_playList;
            this.btnPlayList.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnPlayList.Location = new System.Drawing.Point(10, 3);
            this.btnPlayList.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayList.Name = "btnPlayList";
            this.btnPlayList.RoundBorders = true;
            this.btnPlayList.ShowBorders = true;
            this.btnPlayList.Size = new System.Drawing.Size(45, 45);
            this.btnPlayList.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnPlayList.TabIndex = 3;
            this.btnPlayList.Click += new System.EventHandler(this.btnPlayList_Click);
            // 
            // pnMore
            // 
            this.pnMore.BackColor = System.Drawing.Color.Transparent;
            this.pnMore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMore.BackgroundImage")));
            this.pnMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMore.BorderRadius = 30;
            this.pnMore.Controls.Add(this.btnOpenFile);
            this.pnMore.Controls.Add(this.btnMore);
            this.pnMore.Controls.Add(this.btnSetting);
            this.pnMore.GradientBottomLeft = System.Drawing.Color.White;
            this.pnMore.GradientBottomRight = System.Drawing.Color.White;
            this.pnMore.GradientTopLeft = System.Drawing.Color.White;
            this.pnMore.GradientTopRight = System.Drawing.Color.White;
            this.pnMore.Location = new System.Drawing.Point(-15, 50);
            this.pnMore.Margin = new System.Windows.Forms.Padding(2);
            this.pnMore.Name = "pnMore";
            this.pnMore.Quality = 10;
            this.pnMore.Size = new System.Drawing.Size(229, 50);
            this.pnMore.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AllowAnimations = true;
            this.btnOpenFile.AllowBorderColorChanges = true;
            this.btnOpenFile.AllowMouseEffects = true;
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.AnimationSpeed = 200;
            this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.BorderColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.BorderRadius = 1;
            this.btnOpenFile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnOpenFile.BorderThickness = 1;
            this.btnOpenFile.ColorContrastOnClick = 30;
            this.btnOpenFile.ColorContrastOnHover = 30;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnOpenFile.CustomizableEdges = borderEdges4;
            this.btnOpenFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpenFile.Image = global::MediaPlayer.Properties.Resources.icon_file;
            this.btnOpenFile.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnOpenFile.Location = new System.Drawing.Point(90, 5);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.RoundBorders = true;
            this.btnOpenFile.ShowBorders = true;
            this.btnOpenFile.Size = new System.Drawing.Size(41, 41);
            this.btnOpenFile.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnMore
            // 
            this.btnMore.AllowAnimations = true;
            this.btnMore.AllowBorderColorChanges = true;
            this.btnMore.AllowMouseEffects = true;
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.AnimationSpeed = 200;
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMore.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMore.BorderColor = System.Drawing.Color.Transparent;
            this.btnMore.BorderRadius = 1;
            this.btnMore.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnMore.BorderThickness = 1;
            this.btnMore.ColorContrastOnClick = 30;
            this.btnMore.ColorContrastOnHover = 30;
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnMore.CustomizableEdges = borderEdges5;
            this.btnMore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMore.Image = global::MediaPlayer.Properties.Resources.icon_back;
            this.btnMore.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnMore.Location = new System.Drawing.Point(180, 0);
            this.btnMore.Margin = new System.Windows.Forms.Padding(2);
            this.btnMore.Name = "btnMore";
            this.btnMore.RoundBorders = true;
            this.btnMore.ShowBorders = true;
            this.btnMore.Size = new System.Drawing.Size(49, 49);
            this.btnMore.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnMore.TabIndex = 1;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.AllowAnimations = true;
            this.btnSetting.AllowBorderColorChanges = true;
            this.btnSetting.AllowMouseEffects = true;
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.AnimationSpeed = 200;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderRadius = 1;
            this.btnSetting.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnSetting.BorderThickness = 1;
            this.btnSetting.ColorContrastOnClick = 30;
            this.btnSetting.ColorContrastOnHover = 30;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnSetting.CustomizableEdges = borderEdges6;
            this.btnSetting.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSetting.Image = global::MediaPlayer.Properties.Resources.icon_setting;
            this.btnSetting.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Location = new System.Drawing.Point(34, 5);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.RoundBorders = true;
            this.btnSetting.ShowBorders = true;
            this.btnSetting.Size = new System.Drawing.Size(41, 41);
            this.btnSetting.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pnControls
            // 
            this.pnControls.BackColor = System.Drawing.Color.Transparent;
            this.pnControls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnControls.BackgroundImage")));
            this.pnControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnControls.BorderRadius = 80;
            this.pnControls.Controls.Add(this.btnRandom);
            this.pnControls.Controls.Add(this.btnLoop);
            this.pnControls.Controls.Add(this.btnPrev);
            this.pnControls.Controls.Add(this.btnNext);
            this.pnControls.Controls.Add(this.btnPlay);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControls.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.pnControls.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.pnControls.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.pnControls.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.pnControls.Location = new System.Drawing.Point(0, 597);
            this.pnControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnControls.Name = "pnControls";
            this.pnControls.Quality = 10;
            this.pnControls.Size = new System.Drawing.Size(435, 106);
            this.pnControls.TabIndex = 0;
            // 
            // btnRandom
            // 
            this.btnRandom.AllowAnimations = true;
            this.btnRandom.AllowBorderColorChanges = true;
            this.btnRandom.AllowMouseEffects = true;
            this.btnRandom.AnimationSpeed = 200;
            this.btnRandom.BackColor = System.Drawing.Color.Transparent;
            this.btnRandom.BackgroundColor = System.Drawing.Color.White;
            this.btnRandom.BorderColor = System.Drawing.Color.White;
            this.btnRandom.BorderRadius = 1;
            this.btnRandom.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnRandom.BorderThickness = 1;
            this.btnRandom.ColorContrastOnClick = 30;
            this.btnRandom.ColorContrastOnHover = 30;
            this.btnRandom.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnRandom.CustomizableEdges = borderEdges7;
            this.btnRandom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRandom.Image = global::MediaPlayer.Properties.Resources.icon_random;
            this.btnRandom.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnRandom.Location = new System.Drawing.Point(30, 24);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.RoundBorders = true;
            this.btnRandom.ShowBorders = true;
            this.btnRandom.Size = new System.Drawing.Size(38, 38);
            this.btnRandom.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.AllowAnimations = true;
            this.btnLoop.AllowBorderColorChanges = true;
            this.btnLoop.AllowMouseEffects = true;
            this.btnLoop.AnimationSpeed = 200;
            this.btnLoop.BackColor = System.Drawing.Color.Transparent;
            this.btnLoop.BackgroundColor = System.Drawing.Color.White;
            this.btnLoop.BorderColor = System.Drawing.Color.White;
            this.btnLoop.BorderRadius = 1;
            this.btnLoop.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnLoop.BorderThickness = 1;
            this.btnLoop.ColorContrastOnClick = 30;
            this.btnLoop.ColorContrastOnHover = 30;
            this.btnLoop.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnLoop.CustomizableEdges = borderEdges8;
            this.btnLoop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoop.Image = global::MediaPlayer.Properties.Resources.icon_loop;
            this.btnLoop.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnLoop.Location = new System.Drawing.Point(360, 24);
            this.btnLoop.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.RoundBorders = true;
            this.btnLoop.ShowBorders = true;
            this.btnLoop.Size = new System.Drawing.Size(38, 38);
            this.btnLoop.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnLoop.TabIndex = 7;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AllowAnimations = true;
            this.btnPrev.AllowBorderColorChanges = true;
            this.btnPrev.AllowMouseEffects = true;
            this.btnPrev.AnimationSpeed = 200;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundColor = System.Drawing.Color.White;
            this.btnPrev.BorderColor = System.Drawing.Color.White;
            this.btnPrev.BorderRadius = 1;
            this.btnPrev.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnPrev.BorderThickness = 1;
            this.btnPrev.ColorContrastOnClick = 30;
            this.btnPrev.ColorContrastOnHover = 30;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnPrev.CustomizableEdges = borderEdges9;
            this.btnPrev.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrev.Image = global::MediaPlayer.Properties.Resources.icon_prev;
            this.btnPrev.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnPrev.Location = new System.Drawing.Point(120, 24);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.RoundBorders = true;
            this.btnPrev.ShowBorders = true;
            this.btnPrev.Size = new System.Drawing.Size(52, 52);
            this.btnPrev.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.AllowAnimations = true;
            this.btnNext.AllowBorderColorChanges = true;
            this.btnNext.AllowMouseEffects = true;
            this.btnNext.AnimationSpeed = 200;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.White;
            this.btnNext.BorderRadius = 1;
            this.btnNext.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnNext.BorderThickness = 1;
            this.btnNext.ColorContrastOnClick = 30;
            this.btnNext.ColorContrastOnHover = 30;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnNext.CustomizableEdges = borderEdges10;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.Image = global::MediaPlayer.Properties.Resources.icon_next;
            this.btnNext.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnNext.Location = new System.Drawing.Point(266, 24);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.RoundBorders = true;
            this.btnNext.ShowBorders = true;
            this.btnNext.Size = new System.Drawing.Size(52, 52);
            this.btnNext.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnNext.TabIndex = 5;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnPlay.CustomizableEdges = borderEdges11;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.Image = global::MediaPlayer.Properties.Resources.icon_play;
            this.btnPlay.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Location = new System.Drawing.Point(180, 8);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RoundBorders = true;
            this.btnPlay.ShowBorders = true;
            this.btnPlay.Size = new System.Drawing.Size(82, 82);
            this.btnPlay.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // ptbStatus
            // 
            this.ptbStatus.AllowFocused = false;
            this.ptbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbStatus.AutoSizeHeight = true;
            this.ptbStatus.BorderRadius = 75;
            this.ptbStatus.Image = global::MediaPlayer.Properties.Resources.gif_soundWave;
            this.ptbStatus.IsCircle = false;
            this.ptbStatus.Location = new System.Drawing.Point(145, 471);
            this.ptbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.ptbStatus.Name = "ptbStatus";
            this.ptbStatus.Size = new System.Drawing.Size(150, 150);
            this.ptbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbStatus.TabIndex = 11;
            this.ptbStatus.TabStop = false;
            this.ptbStatus.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(255)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(675, 772);
            this.Controls.Add(this.pnBoss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(255)))), ((int)(((byte)(7)))));
            this.Load += new System.EventHandler(this.frmMediaPlayer_Load);
            this.pnBoss.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.pnPlayList.ResumeLayout(false);
            this.pnPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.pnList.ResumeLayout(false);
            this.pnMore.ResumeLayout(false);
            this.pnControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Panel pnBoss;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnMain;
        private Bunifu.UI.WinForms.BunifuLabel lblDurationRealTime;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblYear;
        private Bunifu.UI.WinForms.BunifuLabel lblDurationTotal;
        private Bunifu.UI.WinForms.BunifuHSlider sliderDuration;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnExit;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnPlayList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnVolume;
        private Bunifu.UI.WinForms.BunifuVSlider sliderVolume;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnPicture;
        private Bunifu.UI.WinForms.BunifuPictureBox ptbImage;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnPlayList;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnMore;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnOpenFile;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnMore;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnSetting;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnControls;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnRandom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnLoop;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnPrev;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnNext;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnPlay;
        private Bunifu.UI.WinForms.BunifuPictureBox ptbStatus;
        private System.Windows.Forms.FlowLayoutPanel flowpnPlayList;
    }
}