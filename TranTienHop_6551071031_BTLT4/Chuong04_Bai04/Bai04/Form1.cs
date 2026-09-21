namespace BTCh4_Bai4
{
    public partial class Form1 : Form
    {
        private int countBN = 1;
        private int countLH = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuBenhNhan_Click(object sender, EventArgs e)
        {
            // Luôn tạo đối tượng hoàn toàn mới
            frmBenhNhan frm = new frmBenhNhan();
            frm.MdiParent = this; // Gán form cha
            frm.Text = $"Bệnh nhân #{countBN++}"; // Đặt tiêu đề để hiển thị trên menu Cửa sổ
            frm.Show();
        }

        private void menuLichHen_Click(object sender, EventArgs e)
        {
            // Luôn tạo đối tượng hoàn toàn mới
            frmLichHen frm = new frmLichHen();
            frm.MdiParent = this; // Gán form cha
            frm.Text = $"Lịch hẹn #{countLH++}"; // Đặt tiêu đề để hiển thị trên menu Cửa sổ
            frm.Show();
        }
    }
}
