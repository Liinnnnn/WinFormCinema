namespace QLRapPhim.Staff
{
    partial class frmBookTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookTicket));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.lblTenRap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbPhim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH CHIẾU PHIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayChieu);
            this.groupBox1.Controls.Add(this.lblTenRap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbPhim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(16, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(364, 409);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(25, 313);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(120, 28);
            this.lblNhanVien.TabIndex = 6;
            this.lblNhanVien.Text = "Nhân viên: ";
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChieu.Location = new System.Drawing.Point(29, 73);
            this.dtpNgayChieu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(309, 23);
            this.dtpNgayChieu.TabIndex = 4;
            this.dtpNgayChieu.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblTenRap
            // 
            this.lblTenRap.AutoSize = true;
            this.lblTenRap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenRap.Location = new System.Drawing.Point(25, 251);
            this.lblTenRap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenRap.Name = "lblTenRap";
            this.lblTenRap.Size = new System.Drawing.Size(59, 28);
            this.lblTenRap.TabIndex = 5;
            this.lblTenRap.Text = "Rạp: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn phim";
            // 
            // cbbPhim
            // 
            this.cbbPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhim.FormattingEnabled = true;
            this.cbbPhim.Location = new System.Drawing.Point(27, 158);
            this.cbbPhim.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPhim.Name = "cbbPhim";
            this.cbbPhim.Size = new System.Drawing.Size(312, 25);
            this.cbbPhim.TabIndex = 2;
            this.cbbPhim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbPhim_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn ngày chiếu";
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichChieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichChieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichChieu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichChieu.Location = new System.Drawing.Point(388, 75);
            this.dgvLichChieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.RowHeadersWidth = 51;
            this.dgvLichChieu.Size = new System.Drawing.Size(737, 458);
            this.dgvLichChieu.TabIndex = 2;
            this.dgvLichChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichChieu_CellClick);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::QLRapPhim.Properties.Resources.boobookitty;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(16, 14);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(327, 41);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // frmBookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 560);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.dgvLichChieu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBookTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookTicket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBookTicket_FormClosed);
            this.Load += new System.EventHandler(this.frmBookTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLichChieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbPhim;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTenRap;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}