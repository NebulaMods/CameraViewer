using DevExpress.XtraSplashScreen;

namespace CameraViewer;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        SplashScreenManager.ShowForm(typeof(Forms.Splash));
        var mainForm = new Main();
        mainForm.Hide();
        Thread.Sleep(TimeSpan.FromSeconds(5));
        SplashScreenManager.CloseForm();
        mainForm.Show();
        Application.Run(mainForm);
    }
}