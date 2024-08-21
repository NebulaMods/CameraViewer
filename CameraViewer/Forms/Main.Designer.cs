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
        ((System.ComponentModel.ISupportInitialize)RtspFeed).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ToolBar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ToolBarManager).BeginInit();
        SuspendLayout();
        // 
        // RtspFeed
        // 
        RtspFeed.BackColor = Color.Black;
        RtspFeed.Dock = DockStyle.Fill;
        RtspFeed.Location = new Point(0, 31);
        RtspFeed.MediaPlayer = null;
        RtspFeed.Name = "RtspFeed";
        RtspFeed.Size = new Size(660, 383);
        RtspFeed.TabIndex = 0;
        RtspFeed.Text = "RtspFeed";
        // 
        // ToolBar
        // 
        ToolBar.Location = new Point(0, 0);
        ToolBar.Manager = ToolBarManager;
        ToolBar.Name = "ToolBar";
        ToolBar.Size = new Size(660, 31);
        ToolBar.TabIndex = 1;
        ToolBar.TabStop = false;
        ToolBar.TitleItemLinks.Add(SkinSelectorDropDown);
        ToolBar.TitleItemLinks.Add(SettingsButton);
        ToolBar.ToolbarForm = this;
        // 
        // ToolBarManager
        // 
        ToolBarManager.DockControls.Add(barDockControlTop);
        ToolBarManager.DockControls.Add(barDockControlBottom);
        ToolBarManager.DockControls.Add(barDockControlLeft);
        ToolBarManager.DockControls.Add(barDockControlRight);
        ToolBarManager.Form = this;
        ToolBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { SkinSelectorDropDown, SettingsButton });
        ToolBarManager.MaxItemId = 2;
        // 
        // barDockControlTop
        // 
        barDockControlTop.CausesValidation = false;
        barDockControlTop.Dock = DockStyle.Top;
        barDockControlTop.Location = new Point(0, 31);
        barDockControlTop.Manager = ToolBarManager;
        barDockControlTop.Size = new Size(660, 0);
        // 
        // barDockControlBottom
        // 
        barDockControlBottom.CausesValidation = false;
        barDockControlBottom.Dock = DockStyle.Bottom;
        barDockControlBottom.Location = new Point(0, 414);
        barDockControlBottom.Manager = ToolBarManager;
        barDockControlBottom.Size = new Size(660, 0);
        // 
        // barDockControlLeft
        // 
        barDockControlLeft.CausesValidation = false;
        barDockControlLeft.Dock = DockStyle.Left;
        barDockControlLeft.Location = new Point(0, 31);
        barDockControlLeft.Manager = ToolBarManager;
        barDockControlLeft.Size = new Size(0, 383);
        // 
        // barDockControlRight
        // 
        barDockControlRight.CausesValidation = false;
        barDockControlRight.Dock = DockStyle.Right;
        barDockControlRight.Location = new Point(660, 31);
        barDockControlRight.Manager = ToolBarManager;
        barDockControlRight.Size = new Size(0, 383);
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
        // Main
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(660, 414);
        Controls.Add(RtspFeed);
        Controls.Add(barDockControlLeft);
        Controls.Add(barDockControlRight);
        Controls.Add(barDockControlBottom);
        Controls.Add(barDockControlTop);
        Controls.Add(ToolBar);
        FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
        IconOptions.Icon = (Icon)resources.GetObject("Main.IconOptions.Icon");
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Camera Viewer";
        ToolbarFormControl = ToolBar;
        TopMost = true;
        Load += Main_Load;
        Shown += Main_Shown;
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
}