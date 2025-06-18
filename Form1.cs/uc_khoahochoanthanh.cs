using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class uc_khoahochoanthanh : UserControl
    {
        // Thêm vào ngay sau dòng public partial class uc_khoahochoanthanh : UserControl
        private PictureBox[] starPics;
        private int _rating = 0;

        public int Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                UpdateStars();
            }
        }
        private void UpdateStars()
        {
            for (int i = 0; i < starPics.Length; i++)
            {
                string imgFile = (i < _rating) ? "star_filled.png" : "star_empty.png";
                string path = Path.Combine(Application.StartupPath, "Images", imgFile);

                if (File.Exists(path))
                {
                    // Cần xóa ảnh cũ trước khi set ảnh mới để tránh lỗi khóa file
                    starPics[i].Image?.Dispose();
                    starPics[i].Image = Image.FromFile(path);
                }
            }
        }
        private int currentRating = 0; // lưu đánh giá hiện tại
        private void picStar_Click(object sender, EventArgs e)
        {
            // Lấy PictureBox được click
            PictureBox clickedStar = sender as PictureBox;

            // Tìm vị trí (chỉ số) của ngôi sao đó trong mảng
            int index = Array.IndexOf(starPics, clickedStar);

            // Nếu tìm thấy -> gán Rating = index + 1
            if (index >= 0)
            {
                Rating = index + 1;
            }
        }
        public uc_khoahochoanthanh()
        {
            InitializeComponent();

            starPics = new PictureBox[] { star1, star2, star3, star4, star5 };

            foreach (var pic in starPics)
            {
                pic.Click += picStar_Click;
            }
            // Khởi tạo mặc định (có thể là 0 hoặc số sao mặc định)
            Rating = 0;
            // Đăng ký sự kiện click cho từng sao, gọi chung hàm xử lý với tham số số sao tương ứng
            star1.Click += (s, e) => Star_Click(1);
            star2.Click += (s, e) => Star_Click(2);
            star3.Click += (s, e) => Star_Click(3);
            star4.Click += (s, e) => Star_Click(4);
            star5.Click += (s, e) => Star_Click(5);
        }
        private void Star_Click(int starNumber)
        {
            currentRating = starNumber;
            UpdateStarsDisplay(currentRating);
            // Nếu muốn bạn có thể thêm sự kiện hoặc gọi hàm lưu đánh giá ở đây

            Rating = starNumber;
            label_diem.Text = $"{Rating:0.0} / 5";
        }
        public void SetRating(int sao)
        {
            currentRating = Math.Max(0, Math.Min(5, sao));
            UpdateStarsDisplay(currentRating);
        }
        private void UpdateStarsDisplay(int rating)
        {
            PictureBox[] stars = new PictureBox[] { star1, star2, star3, star4, star5 };

            string fullStarPath = @"D:\visual\Form1.cs\form1.cs\Images\star_filled.png";   // sao đầy màu
            string emptyStarPath = @"D:\visual\Form1.cs\form1.cs\Images\star_empty.png";     // sao rỗng

            for (int i = 0; i < stars.Length; i++)
            {
                if (i < rating)
                    stars[i].Image = Image.FromFile(fullStarPath);
                else
                    stars[i].Image = Image.FromFile(emptyStarPath);
            }
        }
        public void SetData(string tenKhoaHoc, string trangThai, int tienTrinh, int sao, string hinhAnhPath)
        {
            label_namekhoahoc.Text = tenKhoaHoc;
            label_trangthai.Text = trangThai;
            SetRating(sao);

            string fullPath = Path.Combine(Application.StartupPath, hinhAnhPath);

            if (File.Exists(fullPath))
            {
                try
                {
                    using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        pic_khoahoc.Image = Image.FromStream(stream);
                    }
                    pic_khoahoc.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh: " + fullPath, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Các event handler click cho từng sao bạn có thể xóa đi hoặc giữ, vì mình xử lý bằng lambda rồi
        private void star1_Click(object sender, EventArgs e) { }
        private void star2_Click(object sender, EventArgs e) { }
        private void star3_Click(object sender, EventArgs e) { }
        private void star4_Click(object sender, EventArgs e) { }
        private void star5_Click(object sender, EventArgs e) { }

        private void label_diem_Click(object sender, EventArgs e)
        {

        }
    }
}