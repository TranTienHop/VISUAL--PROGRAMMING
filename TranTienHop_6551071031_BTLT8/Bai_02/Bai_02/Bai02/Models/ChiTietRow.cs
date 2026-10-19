namespace Bai02.Models;

/// <summary>
/// Dòng hiển thị trên lưới chi tiết hóa đơn.
/// </summary>
public class ChiTietRow
{
    public int MaCT { get; set; }
    public int STT { get; set; }
    public string TenMon { get; set; } = "";
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien => SoLuong * DonGia;
}
