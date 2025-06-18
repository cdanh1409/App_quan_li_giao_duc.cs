using System.Drawing;

namespace form1.cs
{
    public class KhoaHoc
    {
        public string TenKhoaHoc { get; set; }
        public decimal HocPhi { get; set; }
        public int DoTuoi { get; set; }
        public string DanhGia { get; set; }
        public Image HinhAnh { get; set; }

        public string TrangThai { get; set; }
        public int TienTrinh { get; set; }

        public string Ten { get; set; }      // nếu bạn cần dùng riêng
        public int Diem { get; set; }
        public string Hinh { get; set; }


        // Constructor mặc định
        public KhoaHoc() { }

        // Constructor 1: dùng các trường cơ bản
        public KhoaHoc(string ten, decimal hocPhi, int doTuoi, string danhGia, Image hinhAnh)
        {
            TenKhoaHoc = ten;
            HocPhi = hocPhi;
            DoTuoi = doTuoi;
            DanhGia = danhGia;
            HinhAnh = hinhAnh;
        }

        // Constructor 2: dùng cho khóa học kiểu hiển thị như trong ảnh
        public KhoaHoc(string tenKhoaHoc, string trangThai, int tienTrinh, int doTuoi, Image hinhAnh)
        {
            TenKhoaHoc = tenKhoaHoc;
            TrangThai = trangThai;
            TienTrinh = tienTrinh;
            DoTuoi = doTuoi;
            HinhAnh = hinhAnh;
        }
    }
}
