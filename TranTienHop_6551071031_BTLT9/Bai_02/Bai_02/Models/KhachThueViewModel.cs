namespace Bai_02.Models;

public class KhachThueViewModel
{
    public int MaKhach { get; set; }
    public string HoTen { get; set; } = "";
    public string SoDienThoai { get; set; } = "";
    public string TenPhong { get; set; } = "";
    public decimal GiaThue { get; set; }
    public string GiaThueHienThi => $"{GiaThue:N0} đ";
    public string QueQuan { get; set; } = "";
    public bool DaDangKyTamTru { get; set; }
    public string GioiTinh { get; set; } = "";
    public DateOnly NgaySinh { get; set; }
    public int MaPhong { get; set; }
    public int? MaTinh { get; set; }
    public string? TenTinh { get; set; }
    public int? MaPhuongXa { get; set; }
    public string? TenPhuongXa { get; set; }
}
