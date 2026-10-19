using System;
using System.Collections.Generic;

namespace Bai03.Models;

public partial class SinhVien
{
    public string MaSV { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public DateTime NgaySinh { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string MaLop { get; set; } = null!;

    public virtual Lop MaLopNavigation { get; set; } = null!;

    public virtual ICollection<DiemMon> DiemMons { get; set; } = new List<DiemMon>();
}
