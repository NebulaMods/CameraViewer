namespace CameraViewer;

partial class Main
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        RtspFeed = new LibVLCSharp.WinForms.VideoView();
        ToolBar = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
        ToolBarManager = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(components);
        barDockControlTop = new DevExpress.XtraBars.BarDockControl();
        barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
        barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
        barDockControlRight = new DevExpress.XtraBars.BarDockControl();
        SkinSelectorDropDown = new DevExpress.XtraBars.SkinDropDownButtonItem();
        SettingsButton = new DevExpress.XtraBars.BarButtonItem();
        MediaControlsSubMenu = new DevExpress.XtraBars.BarSubItem();
        StartRtspFeedButton = new DevExpress.XtraBars.BarButtonItem();
        ResumeRtspFeedButton = new DevExpress.XtraBars.BarButtonItem();
        PauseRtspFeedButton = new DevExpress.XtraBars.BarButtonItem();
        StopRtspFeedButton = new DevExpress.XtraBars.BarButtonItem();
        RestartRtspFeedButton = new DevExpress.XtraBars.BarButtonItem();
        ((System.ComponentModel.ISupportInitialize)RtspFeed).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ToolBar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ToolBarManager).BeginInit();
        SuspendLayout();
        // 
        // RtspFeed
        // 
        RtspFeed.BackColor = Color.Black;
        RtspFeed.BackgroundImageLayout = ImageLayout.None;
        RtspFeed.Dock = DockStyle.Fill;
        RtspFeed.Location = new Point(0, 31);
        RtspFeed.MediaPlayer = null;
        RtspFeed.Name = "RtspFeed";
        RtspFeed.Size = new Size(698, 418);
        RtspFeed.TabIndex = 0;
        RtspFeed.Text = "RtspFeed";
        // 
        // ToolBar
        // 
        ToolBar.Location = new Point(0, 0);
        ToolBar.Manager = ToolBarManager;
        ToolBar.Name = "ToolBar";
        ToolBar.Size = new Size(698, 31);
        ToolBar.TabIndex = 1;
        ToolBar.TabStop = false;
        ToolBar.TitleItemLinks.Add(SkinSelectorDropDown);
        ToolBar.TitleItemLinks.Add(SettingsButton);
        ToolBar.TitleItemLinks.Add(MediaControlsSubMenu);
        ToolBar.ToolbarForm = this;
        // 
        // ToolBarManager
        // 
        ToolBarManager.DockControls.Add(barDockControlTop);
        ToolBarManager.DockControls.Add(barDockControlBottom);
        ToolBarManager.DockControls.Add(barDockControlLeft);
        ToolBarManager.DockControls.Add(barDockControlRight);
        ToolBarManager.Form = this;
        ToolBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { SkinSelectorDropDown, SettingsButton, MediaControlsSubMenu, RestartRtspFeedButton, StartRtspFeedButton, StopRtspFeedButton, PauseRtspFeedButton, ResumeRtspFeedButton });
        ToolBarManager.MaxItemId = 12;
        // 
        // barDockControlTop
        // 
        barDockControlTop.CausesValidation = false;
        barDockControlTop.Dock = DockStyle.Top;
        barDockControlTop.Location = new Point(0, 31);
        barDockControlTop.Manager = ToolBarManager;
        barDockControlTop.Size = new Size(698, 0);
        // 
        // barDockControlBottom
        // 
        barDockControlBottom.CausesValidation = false;
        barDockControlBottom.Dock = DockStyle.Bottom;
        barDockControlBottom.Location = new Point(0, 449);
        barDockControlBottom.Manager = ToolBarManager;
        barDockControlBottom.Size = new Size(698, 0);
        // 
        // barDockControlLeft
        // 
        barDockControlLeft.CausesValidation = false;
        barDockControlLeft.Dock = DockStyle.Left;
        barDockControlLeft.Location = new Point(0, 31);
        barDockControlLeft.Manager = ToolBarManager;
        barDockControlLeft.Size = new Size(0, 418);
        // 
        // barDockControlRight
        // 
        barDockControlRight.CausesValidation = false;
        barDockControlRight.Dock = DockStyle.Right;
        barDockControlRight.Location = new Point(698, 31);
        barDockControlRight.Manager = ToolBarManager;
        barDockControlRight.Size = new Size(0, 418);
        // 
        // SkinSelectorDropDown
        // 
        SkinSelectorDropDown.ActAsDropDown = true;
        SkinSelectorDropDown.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
        SkinSelectorDropDown.Hint = "Change the theme of the application.";
        SkinSelectorDropDown.Id = 0;
        SkinSelectorDropDown.Name = "SkinSelectorDropDown";
        // 
        // SettingsButton
        // 
        SettingsButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        SettingsButton.Caption = "Settings";
        SettingsButton.Hint = "View and edit the application's settings.";
        SettingsButton.Id = 1;
        SettingsButton.ImageOptions.Image = Properties.Resources.properties_16x16;
        SettingsButton.ImageOptions.LargeImage = Properties.Resources.properties_32x32;
        SettingsButton.Name = "SettingsButton";
        SettingsButton.ItemClick += SettingsButton_ItemClick;
        // 
        // MediaControlsSubMenu
        // 
        MediaControlsSubMenu.Caption = "Media Options";
        MediaControlsSubMenu.Hint = "Media playback options";
        MediaControlsSubMenu.Id = 5;
        MediaControlsSubMenu.ImageOptions.Image = Properties.Resources.video_16x162;
        MediaControlsSubMenu.ImageOptions.LargeImage = Properties.Resources.video_32x322;
        MediaControlsSubMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(StartRtspFeedButton), new DevExpress.XtraBars.LinkPersistInfo(ResumeRtspFeedButton), new DevExpress.XtraBars.LinkPersistInfo(PauseRtspFeedButton), new DevExpress.XtraBars.LinkPersistInfo(StopRtspFeedButton), new DevExpress.XtraBars.LinkPersistInfo(RestartRtspFeedButton) });
        MediaControlsSubMenu.Name = "MediaControlsSubMenu";
        MediaControlsSubMenu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
        // 
        // StartRtspFeedButton
        // 
        StartRtspFeedButton.Caption = "Start RTSP Stream";
        StartRtspFeedButton.Id = 8;
        StartRtspFeedButton.ImageOptions.Image = Properties.Resources.next_16x16;
        StartRtspFeedButton.ImageOptions.LargeImage = Properties.Resources.next_32x32;
        StartRtspFeedButton.Name = "StartRtspFeedButton";
        StartRtspFeedButton.ItemClick += StartRtspFeedButton_ItemClick;
        // 
        // ResumeRtspFeedButton
        // 
        ResumeRtspFeedButton.Caption = "Resume RTSP Stream";
        ResumeRtspFeedButton.Id = 11;
        ResumeRtspFeedButton.ImageOptions.Image = Properties.Resources.play_16x161;
        ResumeRtspFeedButton.ImageOptions.LargeImage = Properties.Resources.play_32x321;
        ResumeRtspFeedButton.Name = "ResumeRtspFeedButton";
        ResumeRtspFeedButton.ItemClick += ResumeRtspFeedButton_ItemClick;
        // 
        // PauseRtspFeedButton
        // 
        PauseRtspFeedButton.Caption = "Pause RTSP Stream";
        PauseRtspFeedButton.Id = 10;
        PauseRtspFeedButton.ImageOptions.Image = Properties.Resources.pause_16x16;
        PauseRtspFeedButton.ImageOptions.LargeImage = Properties.Resources.pause_32x32;
        PauseRtspFeedButton.Name = "PauseRtspFeedButton";
        PauseRtspFeedButton.ItemClick += PauseRtspFeedButton_ItemClick;
        // 
        // StopRtspFeedButton
        // 
        StopRtspFeedButton.Caption = "Stop RTSP Stream";
        StopRtspFeedButton.Id = 9;
        StopRtspFeedButton.ImageOptions.Image = Properties.Resources.stop_16x16;
        StopRtspFeedButton.ImageOptions.LargeImage = Properties.Resources.stop_32x32;
        StopRtspFeedButton.Name = "StopRtspFeedButton";
        StopRtspFeedButton.ItemClick += StopRtspFeedButton_ItemClick;
        // 
        // RestartRtspFeedButton
        // 
        RestartRtspFeedButton.Caption = "Restart RTSP Stream";
        RestartRtspFeedButton.Id = 6;
        RestartRtspFeedButton.ImageOptions.Image = Properties.Resources.refreshallpivottable_16x16;
        RestartRtspFeedButton.ImageOptions.LargeImage = Properties.Resources.refreshallpivottable_32x32;
        RestartRtspFeedButton.Name = "RestartRtspFeedButton";
        RestartRtspFeedButton.ItemClick += RestartRtspFeedButton_ItemClick;
        // 
        // Main
        // 
        ActiveGlowColor = Color.MediumSlateBlue;
        Appearance.Options.UseFont = true;
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(698, 449);
        Controls.Add(RtspFeed);
        Controls.Add(barDockControlLeft);
        Controls.Add(barDockControlRight);
        Controls.Add(barDockControlBottom);
        Controls.Add(barDockControlTop);
        Controls.Add(ToolBar);
        FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
        IconOptions.Icon = (Icon)resources.GetObject("Main.IconOptions.Icon");
        InactiveGlowColor = Color.BlueViolet;
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Camera Viewer";
        ToolbarFormControl = ToolBar;
        TopMost = true;
        ((System.ComponentModel.ISupportInitialize)RtspFeed).EndInit();
        ((System.ComponentModel.ISupportInitialize)ToolBar).EndInit();
        ((System.ComponentModel.ISupportInitialize)ToolBarManager).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private LibVLCSharp.WinForms.VideoView RtspFeed;
    private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl ToolBar;
    private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager ToolBarManager;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.SkinDropDownButtonItem SkinSelectorDropDown;
    private DevExpress.XtraBars.BarButtonItem SettingsButton;
    private DevExpress.XtraBars.BarSubItem MediaControlsSubMenu;
    private DevExpress.XtraBars.BarButtonItem RestartRtspFeedButton;
    private DevExpress.XtraBars.BarButtonItem StartRtspFeedButton;
    private DevExpress.XtraBars.BarButtonItem StopRtspFeedButton;
    private DevExpress.XtraBars.BarButtonItem PauseRtspFeedButton;
    private DevExpress.XtraBars.BarButtonItem ResumeRtspFeedButton;
}