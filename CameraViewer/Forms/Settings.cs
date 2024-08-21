using DevExpress.XtraEditors;

namespace CameraViewer;

public partial class Settings : XtraForm
{
    public Settings()
    {
        InitializeComponent();

        var (username, password) = RtspViewer.RetrieveCredentialsFromRegistry();
        if (username != null && password != null)
        {
            UsernameTextEdit.Text = username;
            PasswordTextEdit.Text = password;
        }
        RtspStreamUrlTextEdit.Text = RtspViewer.RetrieveRtspUrlFromRegistry();
    }

    private void SaveRtspFeedUrlButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(RtspStreamUrlTextEdit.Text))
        {
            XtraMessageBox.Show("RTSP feed URL cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if URL is a valid RTSP URL
        if (!RtspStreamUrlTextEdit.Text.StartsWith("rtsp://", StringComparison.OrdinalIgnoreCase))
        {
            XtraMessageBox.Show("Invalid RTSP URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        RtspViewer.StoreRtspFeedUrlInRegistry(RtspStreamUrlTextEdit.Text);

        if (Main.rtspViewer != null)
        {
            var dialogResult = XtraMessageBox.Show("Would you like to restart the RTSP stream?", "Restart RTSP Stream", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Main.rtspViewer?.ChangeRtspVideoFeed(RtspStreamUrlTextEdit.Text);

                Close();
            }
            return;
        }

        Main.StartRtspStream();

        Close();
    }

    private void ClearCredentialsButton_Click(object sender, EventArgs e)
    {
        UsernameTextEdit.Text = string.Empty;
        PasswordTextEdit.Text = string.Empty;
        RtspViewer.ClearCredentialsFromRegistry();
    }

    private void SaveCredentialsButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(UsernameTextEdit.Text) || string.IsNullOrEmpty(PasswordTextEdit.Text))
        {
            XtraMessageBox.Show("Username and password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        RtspViewer.StoreCredentialsInRegistry(UsernameTextEdit.Text, PasswordTextEdit.Text);
    }

    private void TestRtspConnectionButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(RtspStreamUrlTextEdit.Text))
        {
            XtraMessageBox.Show("RTSP feed URL cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if URL is a valid RTSP URL
        if (!RtspStreamUrlTextEdit.Text.StartsWith("rtsp://", StringComparison.OrdinalIgnoreCase))
        {
            XtraMessageBox.Show("Invalid RTSP URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var result = RtspViewer.IsRtspConnectionValid(RtspStreamUrlTextEdit.Text);
        if (result is false)
        {
            XtraMessageBox.Show("RTSP connection is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        XtraMessageBox.Show("RTSP connection is valid", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        if (string.IsNullOrWhiteSpace(UsernameTextEdit.Text) || string.IsNullOrWhiteSpace(PasswordTextEdit.Text))
        {
            var dialogSaveRtspUrlResult = XtraMessageBox.Show("Would you like to save this RTSP URL?", "Save URL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogSaveRtspUrlResult == DialogResult.Yes)
            {
                RtspViewer.StoreRtspFeedUrlInRegistry(RtspStreamUrlTextEdit.Text);
            }
        }
        else
        {
            var dialogSaveRtspDetailsResult = XtraMessageBox.Show("Would you like to save this RTSP URL & the credentials?", "Save RTSP Details", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogSaveRtspDetailsResult == DialogResult.Yes)
            {
                RtspViewer.StoreRtspFeedUrlInRegistry(RtspStreamUrlTextEdit.Text);
                RtspViewer.StoreCredentialsInRegistry(UsernameTextEdit.Text, PasswordTextEdit.Text);
            }
        }

        if (Main.rtspViewer != null)
        {
            var dialogRestartRtspStreamResult = XtraMessageBox.Show("Would you like to restart the RTSP stream?", "Restart RTSP Stream", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogRestartRtspStreamResult == DialogResult.Yes)
            {
                Main.rtspViewer?.ChangeRtspVideoFeed(RtspStreamUrlTextEdit.Text);

                Close();
            }
            return;
        }

        Main.StartRtspStream();

        Close();
    }

    private void ClearRtspStreamUrlButton_Click(object sender, EventArgs e)
    {
        RtspStreamUrlTextEdit.Text = string.Empty;
        RtspViewer.ClearRtspUrlFromRegistry();

        var dialogStopRtspResult = XtraMessageBox.Show("Would you like to stop the RTSP stream?", "Stop RTSP Stream", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dialogStopRtspResult == DialogResult.Yes)
        {
            Main.rtspViewer?.StopRtspStream();
        }
    }
}