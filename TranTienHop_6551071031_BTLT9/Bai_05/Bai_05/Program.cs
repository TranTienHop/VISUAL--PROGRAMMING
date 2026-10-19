using System.Threading;
using Serilog;

namespace Bai_05;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File(
                path: Path.Combine(AppContext.BaseDirectory, "logs", "app-.log"),
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 14)
            .CreateLogger();

        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        Application.ThreadException += Application_ThreadException;
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        Log.Error(e.Exception, "Unhandled UI exception");
        MessageBox.Show(
            "Đã xảy ra lỗi, thông tin đã được ghi lại.",
            "Lỗi hệ thống",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        if (e.ExceptionObject is Exception ex)
            Log.Error(ex, "Unhandled domain exception");
        else
            Log.Error("Unhandled domain exception: {Error}", e.ExceptionObject);

        MessageBox.Show(
            "Đã xảy ra lỗi, thông tin đã được ghi lại.",
            "Lỗi hệ thống",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}
