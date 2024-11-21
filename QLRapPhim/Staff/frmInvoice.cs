using QLRapPhim.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRapPhim.Staff
{
    public partial class frmInvoice : Form
    {
        DataProcess process = new DataProcess();
        private string cinemaID, staffID, date, showtimeID, TenKH, GioiTinh, NgaySinh;
        private List<string> seatList, ticket, userInfor;
        private DataGridViewRow film;
        private PrintDocument printDocument;
        public frmInvoice()
        {
            InitializeComponent();
        }

        public frmInvoice(string staff, string cinema, string date, List<string> seat, List<string> ticket, DataGridViewRow film, List<string> user, string showtimeID, string TenKH, string NgaySinh, string GioiTinh)
        {
            this.cinemaID = cinema;
            this.staffID = staff;
            this.seatList = seat;
            this.ticket = ticket;
            this.film = film;
            this.date = date;
            this.userInfor = user;
            this.showtimeID = showtimeID;
            this.TenKH = TenKH;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
        }

        public void HienThi()
        {
            lblVietPay.Enabled = true;
            lblCKTC.Enabled = true;
            lblTienVietpay.Enabled = true;
        }


        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataTable table = process.ReadDatabase("select * from tblFilm where Name = N'" + film.Cells[1].Value.ToString() + "'");
            DataTable tb1 = process.ReadDatabase("select * from tblStaff where StaffID = '" + staffID + "'");
            DataTable tb2 = process.ReadDatabase("select * from tblCinema where CinemaID = '" + cinemaID + "'");
            // Đặt khổ giấy A5 (210mm x 148mm)
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A6", 381, 681);

            // Đặt lề (đơn vị tính là 1/100 inch)
            printDocument1.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            Graphics g = e.Graphics;

            // Thiết lập màu nền (màu be như trong hình)
            Color backColor = Color.FromArgb(255, 230, 200);    
            Brush backgroundBrush = new SolidBrush(backColor);

            // Vẽ nền cho toàn bộ hóa đơn
            g.FillRectangle(backgroundBrush, e.PageBounds);

            // Thiết lập font, brush, và các khoảng cách
            Font titleFont = new Font("Arial", 15, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 12);
            Font boldBodyFont = new Font("Arial", 12, FontStyle.Bold);
            Brush brush = Brushes.Black;

            // Vị trí bắt đầu
            float x = 250; // Lề trái
            float z = 50;
            float y = 50; // Lề trên
            float lineSpacing = 30; // Khoảng cách giữa các dòng

            // Tiêu đề
            g.DrawString("VÉ XEM PHIM", titleFont, brush, z + 320, y);
            y += lineSpacing + 10;

            // Thông tin khách hàng
            g.DrawString("Khách hàng", bodyFont, brush, x, y);
            y += lineSpacing;
            g.DrawString("Công ty TNHH Skope Việt Nam - " + tb2.Rows[0]["CinemaName"].ToString().Substring(10), bodyFont, brush, x, y);
            y += lineSpacing;
            g.DrawString("Tầng 3, TTTM IPH, " + tb2.Rows[0]["CinemaName"].ToString(), bodyFont, brush, x, y);
            y += lineSpacing + 10;

            // Thông tin giao dịch
            g.DrawString("SKOPE " + tb2.Rows[0]["CinemaName"].ToString().Substring(6), boldBodyFont, brush, x, y);
            y += lineSpacing;
            g.DrawString("Cinema: " + tb2.Rows[0]["CinemaName"].ToString(), bodyFont, brush, x, y);
            y += lineSpacing;
            g.DrawString("TransDate: " + DateTime.Now, bodyFont, brush, x, y);
            y += lineSpacing;
            g.DrawString("Seller: " + tb1.Rows[0]["Name"].ToString(), bodyFont, brush, x, y);
            y += lineSpacing + 20;

            // Thông tin phim
            g.DrawString(film.Cells[1].Value.ToString(), titleFont, brush, x, y);
            y += lineSpacing;
            g.DrawString("Trên " + table.Rows[0]["AgeAllowed"].ToString() + " tuổi", bodyFont, brush, x, y);
            y += lineSpacing;
            g.DrawString(date + "    " + film.Cells[2].Value.ToString(), bodyFont, brush, x, y);
            y += lineSpacing;
            g.DrawString("Rạp: " + tb2.Rows[0]["CinemaName"].ToString(), bodyFont, brush, x, y);
            y += lineSpacing;
            string s = "Ghế: ";
            for (int i = 0; i < seatList.Count; i++)
            {
                if (i != seatList.Count - 1)
                    s += seatList[i] + " ";
                else
                    s += seatList[i];
            }
            g.DrawString(s, bodyFont, brush, x, y);
            y += lineSpacing + 20;

            // Thông tin thanh toán
            g.DrawString(film.Cells[1].Value.ToString(), bodyFont, brush, x, y);
            g.DrawString(ticket[2], bodyFont, brush, x + 280, y); // Canh phải giá tiền
            y += lineSpacing;
            g.DrawString(ticket[3], bodyFont, brush, x, y);
            g.DrawString(seatList.Count + "       " + (Convert.ToDouble(ticket[0]) / seatList.Count).ToString(), bodyFont, brush, x + 260, y); // Canh phải số lượng và giá
            y += lineSpacing;
            g.DrawString("Discount", bodyFont, brush, x, y);
            g.DrawString(ticket[1], bodyFont, brush, x + 280, y); // Canh phải giá trị giảm giá
            y += lineSpacing + 20;

            // Phương thức thanh toán
            g.DrawString("PayMethods:", boldBodyFont, brush, x, y);
            g.DrawString(cbbThanhToan.Text, bodyFont, brush, x + 150, y);
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbThanhToan.SelectedIndex != -1)
            {
                
                process.ChangeDatabase("insert into tblUser(Name, Gender, BirthDay, TypeUser) values (N'" + userInfor[0] + "',N'" + userInfor[1] + "','" + userInfor[2] + "','" + ticket[3] +"')");
                DataTable table1 = process.ReadDatabase("select * from tblUser order by UserID desc");

                process.ChangeDatabase("insert into tblInvoice(PaymentDate, PaymentMethod, Discount, ToTal, UserID, StaffID) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','" +
                cbbThanhToan.Text + "','" + lblGiamGia.Text + "','" + ticket[2] + "','" + table1.Rows[0]["UserID"] + "','" + staffID + "')");

                DataTable table2 = process.ReadDatabase("select * from tblInvoice order by InvoiceID desc");
                for(int i = 0; i<seatList.Count; i++)
                {
                    process.ChangeDatabase("insert into tblTicket(TypeTicket, ShowtimeID, InvoiceID, Seat, FinalPrice) values ('" + ticket[3] + "','" + showtimeID + "','" + table2.Rows[0]["InvoiceID"] + "','" + seatList[i] + "','" + lblTienVe.Text + "')");
                }
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
                this.Hide();
                var frm = new frmSeatOptions(film, date, film.Cells[2].Value.ToString(), film.Cells[1].Value.ToString(), staffID, cinemaID, showtimeID);
                frm.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Chưa chọn phương thức thanh toán");
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            lblVietPay.Visible = false;
            lblCKTC.Visible = false;
            lblTienVietpay.Visible = false;

            DataTable table = process.ReadDatabase("select * from tblFilm where Name = N'" + film.Cells[1].Value.ToString() + "'");
            DataTable tb1 = process.ReadDatabase("select * from tblStaff where StaffID = '" + staffID + "'");
            DataTable tb2 = process.ReadDatabase("select * from tblCinema where CinemaID = '" + cinemaID + "'");

            cbbThanhToan.Items.Add("Cash");
            cbbThanhToan.Items.Add("VietQR");
            lblCongTy.Text += tb2.Rows[0]["CinemaName"].ToString().Substring(6);
            lblDiaChi.Text += tb2.Rows[0]["CinemaName"].ToString();
            lblCinemaB.Text += tb2.Rows[0]["CinemaName"].ToString().Substring(6);
            lblCinema.Text += tb2.Rows[0]["CinemaName"].ToString();
            lblNgayGD.Text += DateTime.Now;
            lblNhanVien.Text += tb1.Rows[0]["Name"].ToString();
            lblTenPhim1.Text += film.Cells[1].Value.ToString();
            lblGioiHanTuoi.Text += "Trên " + table.Rows[0]["AgeAllowed"].ToString() + " tuổi";
            lblNgayChieu.Text += date;
            lblGioChieu.Text += film.Cells[2].Value.ToString();
            lblTenRap.Text += tb2.Rows[0]["CinemaName"].ToString();

            for(int i = 0; i < seatList.Count; i++)
            {
                if(i != seatList.Count - 1)
                    lblGhe.Text += seatList[i] + " ";
                else
                    lblGhe.Text += seatList[i];
            }

            lblTenPhim2.Text += film.Cells[1].Value.ToString();
            lblLoaiVe.Text += ticket[3];
            lblSoLuongVe.Text += seatList.Count;
            lblTienThu.Text += ticket[2];
            lblTienVe.Text += (Convert.ToDouble(ticket[0]) / seatList.Count).ToString();
            lblGiamGia.Text += ticket[1];
            lblTienVietpay.Text += ticket[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy không", "Hủy hóa đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                var frm = new frmSeatOptions(film, date, film.Cells[2].Value.ToString(), film.Cells[1].Value.ToString(), staffID, cinemaID, showtimeID, TenKH, NgaySinh, GioiTinh);
                frm.ShowDialog();
                this.Close();
            }
        }

        private void cbbThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbThanhToan.SelectedIndex == 1)
            {
                frmPayment frm = new frmPayment(ticket[2]);
                frm.ShowDialog();
                lblVietPay.Visible = true;
                lblCKTC.Visible = true;
                lblTienVietpay.Visible = true;
            }
            else if(cbbThanhToan.SelectedIndex == 0){
                lblVietPay.Visible = false;
                lblCKTC.Visible = false;
                lblTienVietpay.Visible = false;
            }
        }
    }
}
