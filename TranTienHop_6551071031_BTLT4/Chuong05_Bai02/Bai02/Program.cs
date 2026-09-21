using System;
using System.Windows.Forms;

namespace BaiTapChuong5
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormVeTay());
        }
    }
}
