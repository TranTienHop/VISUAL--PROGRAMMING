using System.Drawing.Printing;
using Bai03.Models;

namespace Bai03;

public class PhieuDiemPrinter
{
    public const string TenKhoa = "KHOA CÔNG NGHỆ THÔNG TIN";

    private readonly PrintDocument _document;
    private SinhVien? _sinhVien;
    private List<DiemMon> _diemMons = new();
    private decimal _diemTB;
    private int _tongTinChi;
    private string _xepLoai = "";
    private int _currentRow;
    private int _currentPage;
    private int _totalPages;

    public PhieuDiemPrinter()
    {
        _document = new PrintDocument();
        _document.DocumentName = "PhieuBaoDiem";
        _document.BeginPrint += Document_BeginPrint;
        _document.PrintPage += Document_PrintPage;
    }

    public PrintDocument Document => _document;

    public void SetData(SinhVien sinhVien, List<DiemMon> diemMons, decimal diemTB, int tongTinChi, string xepLoai)
    {
        _sinhVien = sinhVien;
        _diemMons = diemMons.OrderBy(d => d.MaDiem).ToList();
        _diemTB = diemTB;
        _tongTinChi = tongTinChi;
        _xepLoai = xepLoai;
    }

    public void ShowPreview(IWin32Window? owner = null)
    {
        using var dlg = new PrintPreviewDialog
        {
            Document = _document,
            Width = 900,
            Height = 700,
            StartPosition = FormStartPosition.CenterParent
        };
        dlg.ShowDialog(owner);
    }

    public void ShowPrintDialog(IWin32Window? owner = null)
    {
        using var dlg = new PrintDialog { Document = _document, UseEXDialog = true };
        if (dlg.ShowDialog(owner) == DialogResult.OK)
        {
            _document.Print();
        }
    }

    public void ShowPageSetup(IWin32Window? owner = null)
    {
        using var dlg = new PageSetupDialog { Document = _document };
        dlg.ShowDialog(owner);
    }

    private void Document_BeginPrint(object? sender, PrintEventArgs e)
    {
        _currentRow = 0;
        _currentPage = 0;
        _totalPages = EstimateTotalPages();
    }

    private int EstimateTotalPages()
    {
        // ~40 mon/trang (uoc luong theo chieu cao dong bang)
        const int rowsPerPage = 40;
        int n = Math.Max(1, _diemMons.Count);
        return (int)Math.Ceiling(n / (double)rowsPerPage);
    }

    private void Document_PrintPage(object? sender, PrintPageEventArgs e)
    {
        if (_sinhVien == null || e.Graphics == null)
        {
            e.HasMorePages = false;
            return;
        }

        _currentPage++;
        var g = e.Graphics;
        var bounds = e.MarginBounds;
        float x = bounds.Left;
        float y = bounds.Top;
        float width = bounds.Width;

        using var fontTitle = new Font("Times New Roman", 14, FontStyle.Bold);
        using var fontHeader = new Font("Times New Roman", 12, FontStyle.Bold);
        using var fontNormal = new Font("Times New Roman", 11);
        using var fontSmall = new Font("Times New Roman", 10);
        Brush brush = Brushes.Black;
        using var pen = new Pen(Color.Black, 1f);

        StringFormat center = new() { Alignment = StringAlignment.Center };

        // Header khoa + tieu de (moi trang)
        g.DrawString(TenKhoa, fontHeader, brush, new RectangleF(x, y, width, 22), center);
        y += 26;
        g.DrawString("PHIẾU BÁO ĐIỂM", fontTitle, brush, new RectangleF(x, y, width, 26), center);
        y += 32;

        string tenLop = _sinhVien.MaLopNavigation?.TenLop ?? _sinhVien.MaLop;
        g.DrawString($"MSSV: {_sinhVien.MaSV}", fontNormal, brush, x, y);
        g.DrawString($"Họ tên: {_sinhVien.HoTen}", fontNormal, brush, x + width * 0.35f, y);
        y += 22;
        g.DrawString($"Ngày sinh: {_sinhVien.NgaySinh:dd/MM/yyyy}", fontNormal, brush, x, y);
        g.DrawString($"Giới tính: {_sinhVien.GioiTinh}", fontNormal, brush, x + width * 0.35f, y);
        g.DrawString($"Lớp: {tenLop}", fontNormal, brush, x + width * 0.62f, y);
        y += 28;

        // Bang diem
        float[] colW = { width * 0.10f, width * 0.48f, width * 0.18f, width * 0.24f };
        string[] headers = { "STT", "Môn học", "Số TC", "Điểm" };
        float rowH = 22f;

        DrawTableRow(g, pen, fontHeader, brush, x, y, colW, headers, true);
        y += rowH;

        // Chan trang: so trang + (neu trang cuoi) GPA/chu ky can chieu cao
        float footerReserve = 28f;
        float gpaBlockH = 110f;

        while (_currentRow < _diemMons.Count)
        {
            float needed = rowH;
            bool remainingAfterThis = _currentRow + 1 < _diemMons.Count;
            float bottomLimit = bounds.Bottom - footerReserve;
            if (!remainingAfterThis)
                bottomLimit = bounds.Bottom - footerReserve - gpaBlockH;

            if (y + needed > bottomLimit)
            {
                e.HasMorePages = true;
                DrawPageNumber(g, fontSmall, brush, bounds, _currentPage, _totalPages);
                return;
            }

            var d = _diemMons[_currentRow];
            string[] cells =
            {
                (_currentRow + 1).ToString(),
                d.TenMon,
                d.SoTinChi.ToString(),
                d.Diem.ToString("0.00")
            };
            DrawTableRow(g, pen, fontNormal, brush, x, y, colW, cells, false);
            y += rowH;
            _currentRow++;
        }

        // Trang cuoi: GPA + chu ky
        y += 12;
        g.DrawString($"Tổng số tín chỉ: {_tongTinChi}", fontNormal, brush, x, y);
        y += 22;
        g.DrawString($"Điểm trung bình: {_diemTB:0.00}", fontNormal, brush, x, y);
        y += 22;
        g.DrawString($"Xếp loại: {_xepLoai}", fontHeader, brush, x, y);
        y += 40;

        float sigY = Math.Max(y, bounds.Bottom - 90);
        float mid = x + width / 2f;
        g.DrawString("Giáo vụ khoa", fontNormal, brush, new RectangleF(x, sigY, width / 2f - 10, 20), center);
        g.DrawString("Sinh viên", fontNormal, brush, new RectangleF(mid + 10, sigY, width / 2f - 10, 20), center);
        g.DrawString("(Ký và ghi rõ họ tên)", fontSmall, brush, new RectangleF(x, sigY + 22, width / 2f - 10, 18), center);
        g.DrawString("(Ký và ghi rõ họ tên)", fontSmall, brush, new RectangleF(mid + 10, sigY + 22, width / 2f - 10, 18), center);

        DrawPageNumber(g, fontSmall, brush, bounds, _currentPage, Math.Max(_currentPage, _totalPages));
        e.HasMorePages = false;
    }

    private static void DrawPageNumber(Graphics g, Font font, Brush brush, Rectangle bounds, int page, int total)
    {
        string text = $"Trang {page}/{Math.Max(page, total)}";
        var size = g.MeasureString(text, font);
        g.DrawString(text, font, brush, bounds.Right - size.Width, bounds.Bottom - size.Height);
    }

    private static void DrawTableRow(
        Graphics g, Pen pen, Font font, Brush brush,
        float x, float y, float[] colW, string[] cells, bool header)
    {
        float cx = x;
        float h = 22f;
        for (int i = 0; i < cells.Length; i++)
        {
            var rect = new RectangleF(cx, y, colW[i], h);
            g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
            if (header)
            {
                using var brushBg = new SolidBrush(Color.FromArgb(230, 230, 230));
                g.FillRectangle(brushBg, rect.X + 0.5f, rect.Y + 0.5f, rect.Width - 1f, rect.Height - 1f);
                g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
            }

            StringFormat fmt = new()
            {
                Alignment = (i == 1 && !header) ? StringAlignment.Near : StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };
            var pad = new RectangleF(rect.X + 3, rect.Y, rect.Width - 6, rect.Height);
            g.DrawString(cells[i], font, brush, pad, fmt);
            cx += colW[i];
        }
    }
}
