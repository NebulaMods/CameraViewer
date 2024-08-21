namespace CameraViewer;

partial class Settings
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
        RtspStreamUrlTextEdit = new DevExpress.XtraEditors.TextEdit();
        RtspStreamUrlLabel = new DevExpress.XtraEditors.LabelControl();
        ClearCredentialsButton = new DevExpress.XtraEditors.SimpleButton();
        PasswordLabel = new DevExpress.XtraEditors.LabelControl();
        PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
        UsernameLabel = new DevExpress.XtraEditors.LabelControl();
        UsernameTextEdit = new DevExpress.XtraEditors.TextEdit();
        SaveCredentialsButton = new DevExpress.XtraEditors.SimpleButton();
        SaveRtspFeedUrlButton = new DevExpress.XtraEditors.SimpleButton();
        TestRtspConnectionButton = new DevExpress.XtraEditors.SimpleButton();
        ClearRtspStreamUrlButton = new DevExpress.XtraEditors.SimpleButton();
        ((System.ComponentModel.ISupportInitialize)RtspStreamUrlTextEdit.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PasswordTextEdit.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)UsernameTextEdit.Properties).BeginInit();
        SuspendLayout();
        // 
        // RtspStreamUrlTextEdit
        // 
        RtspStreamUrlTextEdit.Location = new Point(107, 12);
        RtspStreamUrlTextEdit.Name = "RtspStreamUrlTextEdit";
        RtspStreamUrlTextEdit.Size = new Size(179, 20);
        RtspStreamUrlTextEdit.TabIndex = 0;
        // 
        // RtspStreamUrlLabel
        // 
        RtspStreamUrlLabel.Location = new Point(12, 15);
        RtspStreamUrlLabel.Name = "RtspStreamUrlLabel";
        RtspStreamUrlLabel.Size = new Size(89, 13);
        RtspStreamUrlLabel.TabIndex = 7;
        RtspStreamUrlLabel.Text = "RTSP Stream URL:";
        // 
        // ClearCredentialsButton
        // 
        ClearCredentialsButton.Location = new Point(12, 119);
        ClearCredentialsButton.Name = "ClearCredentialsButton";
        ClearCredentialsButton.Size = new Size(135, 23);
        ClearCredentialsButton.TabIndex = 5;
        ClearCredentialsButton.Text = "Clear Credentials";
        ClearCredentialsButton.Click += ClearCredentialsButton_Click;
        // 
        // PasswordLabel
        // 
        PasswordLabel.Location = new Point(12, 96);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(52, 13);
        PasswordLabel.TabIndex = 9;
        PasswordLabel.Text = "Password:";
        // 
        // PasswordTextEdit
        // 
        PasswordTextEdit.Location = new Point(107, 93);
        PasswordTextEdit.Name = "PasswordTextEdit";
        PasswordTextEdit.Properties.PasswordChar = '*';
        PasswordTextEdit.Properties.UseSystemPasswordChar = true;
        PasswordTextEdit.Size = new Size(179, 20);
        PasswordTextEdit.TabIndex = 3;
        // 
        // UsernameLabel
        // 
        UsernameLabel.Location = new Point(12, 70);
        UsernameLabel.Name = "UsernameLabel";
        UsernameLabel.Size = new Size(54, 13);
        UsernameLabel.TabIndex = 8;
        UsernameLabel.Text = "Username:";
        // 
        // UsernameTextEdit
        // 
        UsernameTextEdit.Location = new Point(107, 67);
        UsernameTextEdit.Name = "UsernameTextEdit";
        UsernameTextEdit.Size = new Size(179, 20);
        UsernameTextEdit.TabIndex = 2;
        // 
        // SaveCredentialsButton
        // 
        SaveCredentialsButton.Location = new Point(151, 119);
        SaveCredentialsButton.Name = "SaveCredentialsButton";
        SaveCredentialsButton.Size = new Size(135, 23);
        SaveCredentialsButton.TabIndex = 6;
        SaveCredentialsButton.Text = "Save Credentials";
        SaveCredentialsButton.Click += SaveCredentialsButton_Click;
        // 
        // SaveRtspFeedUrlButton
        // 
        SaveRtspFeedUrlButton.Location = new Point(151, 38);
        SaveRtspFeedUrlButton.Name = "SaveRtspFeedUrlButton";
        SaveRtspFeedUrlButton.Size = new Size(135, 23);
        SaveRtspFeedUrlButton.TabIndex = 1;
        SaveRtspFeedUrlButton.Text = "Save RTSP Stream URL";
        SaveRtspFeedUrlButton.Click += SaveRtspFeedUrlButton_Click;
        // 
        // TestRtspConnectionButton
        // 
        TestRtspConnectionButton.Location = new Point(12, 148);
        TestRtspConnectionButton.Name = "TestRtspConnectionButton";
        TestRtspConnectionButton.Size = new Size(274, 23);
        TestRtspConnectionButton.TabIndex = 4;
        TestRtspConnectionButton.Text = "Test RTSP Connection";
        TestRtspConnectionButton.Click += TestRtspConnectionButton_Click;
        // 
        // ClearRtspStreamUrlButton
        // 
        ClearRtspStreamUrlButton.Location = new Point(12, 38);
        ClearRtspStreamUrlButton.Name = "ClearRtspStreamUrlButton";
        ClearRtspStreamUrlButton.Size = new Size(135, 23);
        ClearRtspStreamUrlButton.TabIndex = 10;
        ClearRtspStreamUrlButton.Text = "Clear RTSP Stream URL";
        ClearRtspStreamUrlButton.Click += ClearRtspStreamUrlButton_Click;
        // 
        // SettingsScreen
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(298, 183);
        Controls.Add(ClearRtspStreamUrlButton);
        Controls.Add(TestRtspConnectionButton);
        Controls.Add(SaveRtspFeedUrlButton);
        Controls.Add(SaveCredentialsButton);
        Controls.Add(UsernameLabel);
        Controls.Add(UsernameTextEdit);
        Controls.Add(PasswordLabel);
        Controls.Add(PasswordTextEdit);
        Controls.Add(ClearCredentialsButton);
        Controls.Add(RtspStreamUrlLabel);
        Controls.Add(RtspStreamUrlTextEdit);
        IconOptions.Icon = (Icon)resources.GetObject("SettingsScreen.IconOptions.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(300, 215);
        MinimumSize = new Size(300, 215);
        Name = "SettingsScreen";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Camera Viewer | Settings";
        ((System.ComponentModel.ISupportInitialize)RtspStreamUrlTextEdit.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)PasswordTextEdit.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)UsernameTextEdit.Properties).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraEditors.TextEdit RtspStreamUrlTextEdit;
    private DevExpress.XtraEditors.LabelControl RtspStreamUrlLabel;
    private DevExpress.XtraEditors.SimpleButton ClearCredentialsButton;
    private DevExpress.XtraEditors.LabelControl PasswordLabel;
    private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
    private DevExpress.XtraEditors.LabelControl UsernameLabel;
    private DevExpress.XtraEditors.TextEdit UsernameTextEdit;
    private DevExpress.XtraEditors.SimpleButton SaveCredentialsButton;
    private DevExpress.XtraEditors.SimpleButton SaveRtspFeedUrlButton;
    private DevExpress.XtraEditors.SimpleButton TestRtspConnectionButton;
    private DevExpress.XtraEditors.SimpleButton ClearRtspStreamUrlButton;
}