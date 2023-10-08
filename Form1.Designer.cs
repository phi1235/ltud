namespace bt8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbKq = new ListBox();
            txtNhap = new TextBox();
            btnNhap = new Button();
            btnTong = new Button();
            btnXoa = new Button();
            btnXoachon = new Button();
            button5 = new Button();
            btnThay = new Button();
            btnChonSoChan = new Button();
            btnChonSoLe = new Button();
            btnKetThuc = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbKq
            // 
            lbKq.FormattingEnabled = true;
            lbKq.ItemHeight = 15;
            lbKq.Location = new Point(30, 122);
            lbKq.Name = "lbKq";
            lbKq.Size = new Size(120, 169);
            lbKq.TabIndex = 2;
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(30, 64);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(120, 23);
            txtNhap.TabIndex = 3;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(30, 93);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(120, 23);
            btnNhap.TabIndex = 4;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(189, 63);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(194, 23);
            btnTong.TabIndex = 5;
            btnTong.Text = "Tong cac phan tu trong List";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(189, 95);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(194, 23);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoa cac phan tu dau va cuoi";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button3_Click;
            // 
            // btnXoachon
            // 
            btnXoachon.Location = new Point(189, 128);
            btnXoachon.Name = "btnXoachon";
            btnXoachon.Size = new Size(194, 23);
            btnXoachon.TabIndex = 7;
            btnXoachon.Text = "Xoa phan tu dang chon";
            btnXoachon.UseVisualStyleBackColor = true;
            btnXoachon.Click += btnXoachon_Click;
            // 
            // button5
            // 
            button5.Location = new Point(189, 162);
            button5.Name = "button5";
            button5.Size = new Size(194, 23);
            button5.TabIndex = 8;
            button5.Text = "Tang moi phan tu len 2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnThay
            // 
            btnThay.Location = new Point(189, 196);
            btnThay.Name = "btnThay";
            btnThay.Size = new Size(194, 23);
            btnThay.TabIndex = 9;
            btnThay.Text = "Thay bang binh phuong";
            btnThay.UseVisualStyleBackColor = true;
            btnThay.Click += btnThay_Click;
            // 
            // btnChonSoChan
            // 
            btnChonSoChan.Location = new Point(189, 230);
            btnChonSoChan.Name = "btnChonSoChan";
            btnChonSoChan.Size = new Size(194, 23);
            btnChonSoChan.TabIndex = 10;
            btnChonSoChan.Text = "Chon so chan";
            btnChonSoChan.UseVisualStyleBackColor = true;
            btnChonSoChan.Click += btnChonSoChan_Click;
            // 
            // btnChonSoLe
            // 
            btnChonSoLe.Location = new Point(189, 262);
            btnChonSoLe.Name = "btnChonSoLe";
            btnChonSoLe.Size = new Size(194, 23);
            btnChonSoLe.TabIndex = 11;
            btnChonSoLe.Text = "Chon so le";
            btnChonSoLe.UseVisualStyleBackColor = true;
            btnChonSoLe.Click += btnChonSoLe_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(30, 307);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(353, 23);
            btnKetThuc.TabIndex = 12;
            btnKetThuc.Text = "Ket thuc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 45);
            label1.TabIndex = 13;
            label1.Text = "LISTBOX";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 342);
            Controls.Add(label1);
            Controls.Add(btnKetThuc);
            Controls.Add(btnChonSoLe);
            Controls.Add(btnChonSoChan);
            Controls.Add(btnThay);
            Controls.Add(button5);
            Controls.Add(btnXoachon);
            Controls.Add(btnXoa);
            Controls.Add(btnTong);
            Controls.Add(btnNhap);
            Controls.Add(txtNhap);
            Controls.Add(lbKq);
            MinimumSize = new Size(30, 30);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbKq;
        private TextBox txtNhap;
        private Button btnNhap;
        private Button btnTong;
        private Button btnXoa;
        private Button btnXoachon;
        private Button button5;
        private Button btnThay;
        private Button btnChonSoChan;
        private Button btnChonSoLe;
        private Button btnKetThuc;
        private Label label1;
    }
}