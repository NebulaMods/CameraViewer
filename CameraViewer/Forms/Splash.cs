using DevExpress.XtraSplashScreen;

namespace CameraViewer.Forms;
public partial class Splash : SplashScreen
{
    public Splash()
    {
        InitializeComponent();
        this.labelCopyright.Text = "Copyright © 2020-" + DateTime.Now.Year.ToString();
    }

    #region Overrides

    public override void ProcessCommand(Enum cmd, object arg)
    {
        base.ProcessCommand(cmd, arg);
    }

    #endregion

    public enum SplashScreenCommand
    {
    }
}