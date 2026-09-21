using System.Windows.Forms;

namespace BaiTapChuong5
{

    public class CanvasPanel : Panel
    {
        public CanvasPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
