namespace Bai04.Models;

public class LichKhamViewModel
{
    public int MaLich { get; set; }
    public string TenBenhNhan { get; set; } = string.Empty;
    public string Sdt { get; set; } = string.Empty;
    public string NgayKhamText { get; set; } = string.Empty;
    public string GioKhamText { get; set; } = string.Empty;
    public string TenBacSi { get; set; } = string.Empty;
    public string ChuyenKhoa { get; set; } = string.Empty;
    public string TrangThai { get; set; } = string.Empty;

    // Các thuộc tính gốc dùng khi ánh xạ lên controls
    public DateOnly NgayKham { get; set; }
    public TimeOnly GioKham { get; set; }
    public int MaBs { get; set; }
}
