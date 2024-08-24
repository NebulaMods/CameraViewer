using DevExpress.XtraEditors;

using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace CameraViewer;

public partial class Main : DevExpress.XtraBars.ToolbarForm.ToolbarForm
{
    internal static Loading? loadingScreen;
    internal static Settings? settingsScreen;
    internal static RtspViewer? rtspViewer = null;
    internal static VideoView? videoView = null;

    public Main()
    {
        InitializeComponent();
        RtspFeed.BackColor = this.BackColor;
        videoView = RtspFeed;
        StartRtspStream();
    }

    internal static void StartRtspStream()
    {
        loadingScreen = new Loading();
        loadingScreen.Show();
        var (username, password) = RtspViewer.RetrieveCredentialsFromRegistry();
        var rtspUrl = RtspViewer.RetrieveRtspUrlFromRegistry();
        if (string.IsNullOrEmpty(rtspUrl))
        {
            settingsScreen = new()
            {
                TopMost = true
            };
            settingsScreen.ShowDialog();
            rtspUrl = RtspViewer.RetrieveRtspUrlFromRegistry();
            settingsScreen.Dispose();
            if (string.IsNullOrEmpty(rtspUrl))
            {
                XtraMessageBox.Show("RTSP feed URL cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseLoadingScreen();
                return;
            }
        }
        if (videoView == null)
        {
            XtraMessageBox.Show("Video view is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        rtspViewer = new RtspViewer(rtspUrl, videoView, username, password);
        rtspViewer.MediaPlayerTimeChanged += MediaPlayer_TimeChanged;
        var started = rtspViewer.StartRtspStream();
        if (!started)
        {
            XtraMessageBox.Show("Failed to start RTSP stream", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CloseLoadingScreen();
            return;
        }
    }

    private static void MediaPlayer_TimeChanged(object sender, MediaPlayerTimeChangedEventArgs e)
    {
        if (loadingScreen != null)
        {
            CloseLoadingScreen();
        }
    }

    private static void CloseLoadingScreen()
    {
        if (loadingScreen != null)
        {
            // Make sure to invoke on the UI thread if necessary
            if (loadingScreen.InvokeRequired)
            {
                loadingScreen.Invoke(new Action(CloseLoadingScreen));
            }
            else
            {
                loadingScreen.Close();
            }
        }

        loadingScreen = null;
    }

    private void SettingsButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        settingsScreen = new();
        settingsScreen.TopMost = true;
        var result = settingsScreen.ShowDialog();
        switch (result)
        {
            default:
                settingsScreen.Dispose();
                break;
        }
    }

    private void StartRtspFeedButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        if (rtspViewer == null)
        {
            StartRtspStream();
        }
    }

    private void PauseRtspFeedButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        videoView?.MediaPlayer?.SetPause(true);
    }

    private void StopRtspFeedButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        rtspViewer?.StopRtspStream();
        rtspViewer?.Dispose();
        rtspViewer = null;
    }

    private void RestartRtspFeedButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        rtspViewer?.StopRtspStream();
        rtspViewer?.Dispose();
        rtspViewer = null;
        StartRtspStream();
    }

    private void ResumeRtspFeedButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        videoView?.MediaPlayer?.SetPause(false);
    }
}