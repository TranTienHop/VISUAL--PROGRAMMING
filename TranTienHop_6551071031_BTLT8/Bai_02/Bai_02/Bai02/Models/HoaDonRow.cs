namespace Bai02.Models;

/// <summary>
/// Dòng hiển thị trên lưới hóa đơn (có TongTien tính toán).
/// </summary>
public class HoaDonRow
{
    public int MaHD { get; set; }
    public string MaHDText => $"HD{MaHD:D6}";
    public DateTime NgayLap { get; set; }
    public int SoBan { get; set; }
    public string HinhThucTT { get; set; } = "";
    public decimal TongTien { get; set; }
}
