using DevExpress.XtraEditors;

using LibVLCSharp.Shared;

namespace CameraViewer;
public partial class MainScreen : DevExpress.XtraBars.ToolbarForm.ToolbarForm
{
    private LibVLC _libVLC;
    private MediaPlayer _mediaPlayer;
    private LoadingScreen? loadingScreen;
    private SettingsScreen? settingsScreen;

    public MainScreen()
    {
        InitializeComponent();

        _libVLC = new LibVLC();
        _mediaPlayer = new MediaPlayer(_libVLC);

        RstpFeed.MediaPlayer = _mediaPlayer;
    }

    private void Main_Load(object sender, EventArgs e)
    {

    }

    private void Main_Shown(object sender, EventArgs e)
    {
        var rtspUrl = "rtsp://192.168.0.249:8554/birdseye";
        _mediaPlayer.EnableHardwareDecoding = true;

        loadingScreen = new LoadingScreen();
        loadingScreen.Show();

        _mediaPlayer.TimeChanged += MediaPlayer_TimeChanged;

        var started = _mediaPlayer.Play(new Media(_libVLC, new Uri(rtspUrl)));

        if (!started)
        {
            XtraMessageBox.Show("Failed to start playing the video.");
            loadingScreen.Close(); // Close the loading screen if playback fails
            return;
        }
    }

    private void MediaPlayer_TimeChanged(object sender, MediaPlayerTimeChangedEventArgs e)
    {
        // Video time has changed, indicating video is being displayed
        if (loadingScreen != null)
        {
            CloseLoadingScreen();
        }
    }

    private void CloseLoadingScreen()
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
        settingsScreen = new SettingsScreen();
        settingsScreen.TopMost = true;
        var result = settingsScreen.ShowDialog();
        switch(result)
        {
            default:
                Console.WriteLine(result);
                settingsScreen.Dispose();
                break;
        }
    }
}