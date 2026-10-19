namespace Bai01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "--check-utf8")
            {
                using var db = new Bai01.Data.TiemTapHoaContext();
                foreach (var h in db.HangHoas.Take(3))
                {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    Console.WriteLine($"{h.MaHang}: {h.TenHang} | {h.LoaiHang} | {h.DonVi}");
                }
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}