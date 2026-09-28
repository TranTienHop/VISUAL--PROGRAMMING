using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapChuong5
{
    public partial class FormDatPhong : Form
    {
        private const string DinhDang = "dd/MM/yyyy";

        public FormDatPhong()
        {
            InitializeComponent();
        }

        private void BaoLoi(TextBox txt, CancelEventArgs e, string thongBao)
        {
            e.Cancel = true;                   
            errorProvider1.SetError(txt, thongBao);
            txt.BackColor = Color.MistyRose;
        }

        private void BaoDung(TextBox txt)
        {
            errorProvider1.SetError(txt, "");
            txt.BackColor = Color.Honeydew;
        }

        private static bool TryParseNgay(string s, out DateTime ngay)
        {
            return DateTime.TryParseExact(s.Trim(), DinhDang, CultureInfo.InvariantCulture,
                                          DateTimeStyles.None, out ngay);
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                BaoLoi(txtHoTen, e, "Họ tên không được để trống");
            else
                BaoDung(txtHoTen);
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string s = txtCCCD.Text.Trim();
            if (s.Length != 12 || !s.All(char.IsDigit))
                BaoLoi(txtCCCD, e, "Số CCCD phải gồm đúng 12 chữ số");
            else
                BaoDung(txtCCCD);
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime nhan;
            if (!TryParseNgay(txtNgayNhan.Text, out nhan))
                BaoLoi(txtNgayNhan, e, "Ngày nhận phải đúng định dạng dd/MM/yyyy");
            else if (nhan.Date < DateTime.Today)
                BaoLoi(txtNgayNhan, e, "Ngày nhận phải từ hôm nay trở đi");
            else
                BaoDung(txtNgayNhan);
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime tra, nhan;
            if (!TryParseNgay(txtNgayTra.Text, out tra))
            {
                BaoLoi(txtNgayTra, e, "Ngày trả phải đúng định dạng dd/MM/yyyy");
                return;
            }
            if (!TryParseNgay(txtNgayNhan.Text, out nhan))
            {
                BaoLoi(txtNgayTra, e, "Vui lòng nhập ngày nhận hợp lệ trước");
                return;
            }
            if (tra.Date <= nhan.Date)
                BaoLoi(txtNgayTra, e, "Ngày trả phải sau ngày nhận");
            else
                BaoDung(txtNgayTra);
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int so;
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out so) || so < 1 || so > 4)
                BaoLoi(txtSoNguoiLon, e, "Số người lớn phải là số nguyên từ 1 đến 4");
            else
                BaoDung(txtSoNguoiLon);
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int so;
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out so) || so < 0 || so > 3)
                BaoLoi(txtSoTreEm, e, "Số trẻ em phải là số nguyên từ 0 đến 3");
            else
                BaoDung(txtSoTreEm);
        }

        private void TextBox_Validated(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Honeydew;
        }

        // ---------- Yêu cầu 4 ----------
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            DateTime nhan, tra;
            TryParseNgay(txtNgayNhan.Text, out nhan);
            TryParseNgay(txtNgayTra.Text, out tra);
            int soDem = (tra - nhan).Days;

            MessageBox.Show(
                "Đặt phòng thành công!\n\n" +
                "Khách hàng: " + txtHoTen.Text.Trim() + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Người lớn: " + txtSoNguoiLon.Text.Trim() +
                " | Trẻ em: " + txtSoTreEm.Text.Trim(),
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
