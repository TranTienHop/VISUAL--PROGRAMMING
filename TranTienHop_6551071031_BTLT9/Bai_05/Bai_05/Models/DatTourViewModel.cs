namespace Bai_05.Models;

public class DatTourViewModel
{
    public int MaDat { get; set; }
    public string MaDatHienThi => $"DT{MaDat:D3}";
    public string HoTenKhach { get; set; } = "";
    public string TenTour { get; set; } = "";
    public int SoNguoi { get; set; }
    public string TyGiaHienThi { get; set; } = "";
    public decimal TongTienVnd { get; set; }
    public string TongTienHienThi => $"{TongTienVnd:N0} đ";
    public string NgayDatHienThi { get; set; } = "";
    public DateTime NgayDat { get; set; }
    public DateOnly? NgayKhoiHanh { get; set; }
}
