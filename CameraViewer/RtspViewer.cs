using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

using Microsoft.Win32;

namespace CameraViewer;
internal class RtspViewer : IDisposable
{
    private LibVLC _libVLC;
    private MediaPlayer _mediaPlayer;
    private string _rtspUrl = "rtsp://192.168.0.249:8554/birdseye";
    private string? _username;
    private string? _password;

    public event EventHandler<MediaPlayerTimeChangedEventArgs>? MediaPlayerTimeChanged;

    public RtspViewer(string rtspUrl, VideoView rtspFeed, string? username = null, string? password = null)
    {
        _rtspUrl = rtspUrl;
        _libVLC = new LibVLC();
        _mediaPlayer = new MediaPlayer(_libVLC)
        {
            EnableHardwareDecoding = true
        };
        _mediaPlayer.TimeChanged += MediaPlayerTimeChanged;

        rtspFeed.MediaPlayer = _mediaPlayer;

        _username = username;
        _password = password;
    }

    public static bool IsRtspConnectionValid(string rtspUrl)
    {
        if (string.IsNullOrEmpty(rtspUrl))
        {
            throw new ArgumentException("RTSP feed URL cannot be empty", nameof(rtspUrl));
        }

        // Check if URL is a valid RTSP URL
        if (!rtspUrl.StartsWith("rtsp://", StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException("Invalid RTSP URL", nameof(rtspUrl));
        }

        // Test RTSP connection
        
        return true;
    }

    public void Dispose()
    {
        _libVLC?.Dispose();
        _mediaPlayer?.Dispose();
    }

    public bool StartRtspStream()
    {
        _mediaPlayer.TimeChanged += MediaPlayerTimeChanged;

        if (!(string.IsNullOrWhiteSpace(_username) || string.IsNullOrWhiteSpace(_password)))
        {
            // Split the URL right after the protocol
            var splitUrl = _rtspUrl.Split("://");
            if (splitUrl.Length == 2)
            {
                // Insert the username and password into the URL
                _rtspUrl = $"{splitUrl[0]}://{_username}:{_password}@{splitUrl[1]}";
            }
        }

        var started = _mediaPlayer.Play(new Media(_libVLC, new Uri(_rtspUrl)));

        return started;
    }

    public void StopRtspStream()
    {
        _mediaPlayer.Stop();
    }

    public static void StoreCredentialsInRegistry(string username, string password)
    {
        var key = Registry.CurrentUser.CreateSubKey("Software\\CameraViewer");
        key.SetValue("Username", username);
        key.SetValue("Password", password);
        key.Close();
    }

    public static (string? username, string? password) RetrieveCredentialsFromRegistry()
    {
        var key = Registry.CurrentUser.OpenSubKey("Software\\CameraViewer");
        if (key != null)
        {
            var username = key.GetValue("Username")?.ToString();
            var password = key.GetValue("Password")?.ToString();
            key.Close();
            return (username, password);
        }
        return (null, null);
    }

    public static void ClearCredentialsFromRegistry()
    {
        var key = Registry.CurrentUser.OpenSubKey("Software", true);
        key?.DeleteSubKeyTree("CameraViewer");
        key?.Close();
    }

    public static void StoreRtspFeedUrlInRegistry(string url)
    {
        var key = Registry.CurrentUser.CreateSubKey("Software\\CameraViewer");
        key.SetValue("RtspFeedUrl", url);
        key.Close();
    }

    public static string? RetrieveRtspUrlFromRegistry()
    {
        var key = Registry.CurrentUser.OpenSubKey("Software\\CameraViewer");
        if (key != null)
        {
            var url = key.GetValue("RtspFeedUrl")?.ToString();
            key.Close();
            return url;
        }
        return null;
    }

    public static void ClearRtspUrlFromRegistry()
    {
        var key = Registry.CurrentUser.OpenSubKey("Software", true);
        key?.DeleteSubKeyTree("CameraViewer");
        key?.Close();
    }

    public void ChangeRtspVideoFeed(string url)
    {
        _mediaPlayer.Stop();
        _mediaPlayer.Play(new Media(_libVLC, new Uri(url)));
    }
}
