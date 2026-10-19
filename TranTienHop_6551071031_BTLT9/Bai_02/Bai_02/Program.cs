using System.Threading;
using Serilog;

namespace Bai_02;

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
        Application.ThreadException += (_, e) =>
        {
            Log.Error(e.Exception, "Unhandled UI exception");
            MessageBox.Show("Đã xảy ra lỗi, thông tin đã được ghi lại.", "Lỗi hệ thống",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        };
        AppDomain.CurrentDomain.UnhandledException += (_, e) =>
        {
            if (e.ExceptionObject is Exception ex)
                Log.Error(ex, "Unhandled domain exception");
            else
                Log.Error("Unhandled domain exception: {Error}", e.ExceptionObject);

            MessageBox.Show("Đã xảy ra lỗi, thông tin đã được ghi lại.", "Lỗi hệ thống",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        };

        ApplicationConfiguration.Initialize();
        Application.Run(new FormKhachThue());
    }
}
