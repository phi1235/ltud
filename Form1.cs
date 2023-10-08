using System.Windows.Forms;

namespace bt8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ít nhất một phần tử trong ListBox
            if (lbKq.Items.Count > 0)
            {
                // Xóa phần tử đầu tiên
                lbKq.Items.RemoveAt(0);

                // Kiểm tra xem còn ít nhất một phần tử nữa trong ListBox sau khi xóa phần tử đầu tiên
                if (lbKq.Items.Count > 0)
                {
                    // Xóa phần tử cuối cùng (vì ListBox1.Items.Count đã giảm đi 1 sau lệnh xóa đầu tiên)
                    lbKq.Items.RemoveAt(lbKq.Items.Count - 1);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            // Lấy số từ TextBox
            string inputText = txtNhap.Text;

            // Kiểm tra nếu TextBox không trống
            if (!string.IsNullOrEmpty(inputText))
            {
                // Thêm số vào ListBox
                lbKq.Items.Add(inputText);

                // Xóa nội dung trong TextBox và đặt con trỏ vào TextBox
                txtNhap.Clear();
                txtNhap.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dat con tro chuot khi load form
            txtNhap.Focus();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            // Hiển thị số lượng phần tử trong ListBox bằng MessageBox
            MessageBox.Show("Số lượng phần tử trong ListBox: " + lbKq.Items.Count, "Kết quả");
        }

        private void btnXoachon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ít nhất một phần tử đã được chọn
            if (lbKq.SelectedIndex != -1)
            {
                // Xóa phần tử đang được chọn
                lbKq.Items.RemoveAt(lbKq.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả các phần tử trong ListBox
            for (int i = 0; i < lbKq.Items.Count; i++)
            {
                // Lấy giá trị của phần tử hiện tại
                int giaTriHienTai = int.Parse(lbKq.Items[i].ToString());

                // Tăng giá trị lên 2
                giaTriHienTai += 2;

                // Cập nhật lại giá trị của phần tử trong ListBox
                lbKq.Items[i] = giaTriHienTai.ToString();
            }
        }

        private void btnThay_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả các phần tử trong ListBox
            for (int i = 0; i < lbKq.Items.Count; i++)
            {
                // Lấy giá trị của phần tử hiện tại
                int giaTriHienTai = int.Parse(lbKq.Items[i].ToString());

                // Tính bình phương của giá trị
                int binhPhuong = giaTriHienTai * giaTriHienTai;

                // Cập nhật lại giá trị của phần tử trong ListBox với giá trị bình phương
                lbKq.Items[i] = binhPhuong.ToString();
            }
        }

        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            // Tạo một danh sách để lưu trữ các số chẵn đã được chọn
            List<int> soChanDaChon = new List<int>();

            // Duyệt qua tất cả các phần tử trong ListBox
            foreach (var item in lbKq.Items)
            {
                // Lấy giá trị của phần tử hiện tại và chuyển đổi nó thành số nguyên
                if (int.TryParse(item.ToString(), out int giaTri))
                {
                    // Kiểm tra xem số đó có phải là số chẵn hay không
                    if (giaTri % 2 == 0)
                    {
                        // Nếu là số chẵn, thêm vào danh sách số chẵn đã chọn
                        soChanDaChon.Add(giaTri);
                    }
                }
            }

            // Hiển thị các số chẵn đã chọn trong một MessageBox
            if (soChanDaChon.Count > 0)
            {
                MessageBox.Show("Các số chẵn đã chọn: " + string.Join(", ", soChanDaChon), "Số chẵn");
            }
            else
            {
                MessageBox.Show("Không có số chẵn nào được chọn.", "Số chẵn");
            }
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            // Tạo một danh sách để lưu trữ các số le đã được chọn
            List<int> soLeDaChon = new List<int>();

            // Duyệt qua tất cả các phần tử trong ListBox
            foreach (var item in lbKq.Items)
            {
                // Lấy giá trị của phần tử hiện tại và chuyển đổi nó thành số nguyên
                if (int.TryParse(item.ToString(), out int giaTri))
                {
                    // Kiểm tra xem số đó có phải là số le hay không
                    if (giaTri % 2 != 0)
                    {
                        // Nếu là số le, thêm vào danh sách số le đã chọn
                        soLeDaChon.Add(giaTri);
                    }
                }
            }

            // Hiển thị các số le đã chọn trong một MessageBox
            if (soLeDaChon.Count > 0)
            {
                MessageBox.Show("Các số le đã chọn: " + string.Join(", ", soLeDaChon), "Số le");
            }
            else
            {
                MessageBox.Show("Không có số le nào được chọn.", "Số le");
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban chac chan muon thoat khong?","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
           
        }
    }
}