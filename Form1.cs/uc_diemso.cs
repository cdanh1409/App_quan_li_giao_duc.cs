using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class uc_diemso : UserControl
    {
        public uc_diemso()
        {
            InitializeComponent();
        }

        private void uc_diemso_Load(object sender, EventArgs e)
        {
            StyleDataGridView();

            dataGridViewDiem.Columns.Clear();
            dataGridViewDiem.Rows.Clear();

            // Thêm các cột
            dataGridViewDiem.Columns.Add("colName", "NAME");
            dataGridViewDiem.Columns.Add("colTX1", "TX 1");
            dataGridViewDiem.Columns.Add("colT", "T");

            for (int i = 3; i <= 10; i++)
            {
                dataGridViewDiem.Columns.Add("col" + i, i.ToString());
            }

            dataGridViewDiem.Columns.Add("colTB", "TB");
            dataGridViewDiem.Columns.Add("colXepLoai", "Xếp Loại");

            // Thêm dữ liệu mẫu
            dataGridViewDiem.Rows.Add("Bé 7", 1, "", 2, "", 2, "", "", "", "", "", "");
            dataGridViewDiem.Rows.Add("Bé Ku cute", "1", "3", "7", "8", "", "", "", "", "", "", "");

            dataGridViewDiem.Columns["colName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridViewDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDiem.RowHeadersVisible = false;
            dataGridViewDiem.AllowUserToAddRows = false;

            dataGridViewDiem.CellValueChanged += DataGridViewDiem_CellValueChanged;
            dataGridViewDiem.CurrentCellDirtyStateChanged += (s, ev) =>
            {
                if (dataGridViewDiem.IsCurrentCellDirty)
                    dataGridViewDiem.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            // *** CUỘN VỀ CỘT ĐẦU TIÊN ***
            dataGridViewDiem.FirstDisplayedScrollingColumnIndex = 0;
        }
        private void DataGridViewDiem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewDiem.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Đặt màu hồng nhạt nếu ô có giá trị
                if (!string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                {
                    cell.Style.BackColor = Color.FromArgb(255, 192, 192); // Hồng nhạt
                }
                else
                {
                    cell.Style.BackColor = Color.White; // Trống thì nền trắng
                }

                // Tính điểm trung bình & xếp loại
                double sum = 0;
                int count = 0;

                for (int i = 1; i <= 10; i++)
                {
                    if (double.TryParse(dataGridViewDiem.Rows[e.RowIndex].Cells[i].Value?.ToString(), out double val))
                    {
                        sum += val;
                        count++;
                    }
                }

                if (count > 0)
                {
                    double avg = sum / count;
                    dataGridViewDiem.Rows[e.RowIndex].Cells["colTB"].Value = avg.ToString("0.00");

                    string xepLoai = "Yếu";
                    if (avg >= 8) xepLoai = "Giỏi";
                    else if (avg >= 6.5) xepLoai = "Khá";
                    else if (avg >= 5) xepLoai = "Trung Bình";

                    dataGridViewDiem.Rows[e.RowIndex].Cells["colXepLoai"].Value = xepLoai;
                }
            }
        }

        private void StyleDataGridView()
        {
            // Font & màu chữ
            dataGridViewDiem.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridViewDiem.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridViewDiem.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dataGridViewDiem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewDiem.EnableHeadersVisualStyles = false;

            // Kẻ ô & căn giữa
            dataGridViewDiem.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewDiem.GridColor = Color.Black;
            dataGridViewDiem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDiem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Chọn dòng: màu hồng
            dataGridViewDiem.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            dataGridViewDiem.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Hàng cao
            dataGridViewDiem.RowTemplate.Height = 40;

            // Không resize
            dataGridViewDiem.AllowUserToResizeColumns = false;
            dataGridViewDiem.AllowUserToResizeRows = false;

            // Padding
            dataGridViewDiem.DefaultCellStyle.Padding = new Padding(3);
        }

        private void dataGridViewDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_exithoccanhan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
