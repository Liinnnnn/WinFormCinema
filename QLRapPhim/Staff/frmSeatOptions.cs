using QLRapPhim.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRapPhim.Staff
{
    public partial class frmSeatOptions : Form
    {
        DataGridViewRow row;
        string time, date, name, staffID, cinemaID, showtimeID, TenKH = "", GioiTinh = "", NgaySinh = "24/11/2011";
        double tongtien = 0;
        List<string> userInfor = new List<string>();
        List<string> seats = new List<string>();
        DataProcess data = new DataProcess();
        public frmSeatOptions()
        {
            InitializeComponent();
        }

        public frmSeatOptions(DataGridViewRow selectedRow, string showDate, string showTime, string nameFilm, string staff, string cinema, string showtimeID)
        {
            this.staffID = staff;
            this.cinemaID = cinema;
            this.row = selectedRow;
            this.date = showDate;
            this.name = nameFilm;
            this.time = showTime;
            this.showtimeID = showtimeID;
            InitializeComponent();
        }
        public frmSeatOptions(DataGridViewRow selectedRow, string showDate, string showTime, string nameFilm, string staff, string cinema, string showtimeID, string TenKH, string NgaySinh, string GioiTinh)
        {
            this.staffID = staff;
            this.cinemaID = cinema;
            this.row = selectedRow;
            this.date = showDate;
            this.name = nameFilm;
            this.time = showTime;
            this.showtimeID = showtimeID;
            this.TenKH = TenKH;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            InitializeComponent();
        }

        private void SeatOptions_Load(object sender, EventArgs e)
        {
            //Load lai thong tin form khi an huy hoa don
            tbTenKH.Text = TenKH;
            tbGioiTinh.Text = GioiTinh;
            dtpNgaySinh.Text = NgaySinh;

            // Hiển thị thông tin địa điểm và thời gian chiếu
            DataTable tb1 = data.ReadDatabase("select * from tblStaff where StaffID = '" + staffID + "'");
            DataTable tb2 = data.ReadDatabase("select * from tblCinema where CinemaID = '" + cinemaID + "'");
            lblDiaDiem.Text += tb2.Rows[0]["CinemaName"].ToString() + " | " + row.Cells[0].Value.ToString() + " | " + row.Cells[1].Value.ToString();
            lblThoiGian.Text += date + " | " + row.Cells[2].Value.ToString();

            DataTable table = data.ReadDatabase("select tk.Seat from tblShowtime st join tblFilm film on film.FilmID = st.FilmID " +
                "join tblShowRoom sr on sr.RoomID = st.RoomID join tblTicket tk on tk.ShowtimeID = st.ShowtimeID " +
                "where sr.CinemaID = '" + cinemaID + "'and film.Name = N'" + name + "' and cast(st.Showtime as date) = '" + date + "'and st.ShowtimeHour = '" + time + "' and sr.RoomName = '" + row.Cells[0].Value.ToString() + "'");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["Seat"].ToString()){
                    case "A1":
                        btnA1.BackColor = Color.Silver;
                        btnA1.Enabled = false;
                        break;
                    case "A2":
                        btnA2.BackColor = Color.Silver;
                        btnA2.Enabled = false;
                        break;
                    case "A3":
                        btnA3.BackColor = Color.Silver;
                        btnA3.Enabled = false;
                        break;
                    case "A4":
                        btnA4.BackColor = Color.Silver;
                        btnA4.Enabled = false;
                        break;
                    case "A5":
                        btnA5.BackColor = Color.Silver;
                        btnA5.Enabled = false;
                        break;
                    case "A6":
                        btnA6.BackColor = Color.Silver;
                        btnA6.Enabled = false;
                        break;
                    case "A7":
                        btnA7.BackColor = Color.Silver;
                        btnA7.Enabled = false;
                        break;
                    case "A8":
                        btnA8.BackColor = Color.Silver;
                        btnA8.Enabled = false;
                        break;
                    case "B1":
                        btnB1.BackColor = Color.Silver;
                        btnB1.Enabled = false;
                        break;
                    case "B2":
                        btnB2.BackColor = Color.Silver;
                        btnB2.Enabled = false;
                        break;
                    case "B3":
                        btnB3.BackColor = Color.Silver;
                        btnB3.Enabled = false;
                        break;
                    case "B4":
                        btnB4.BackColor = Color.Silver;
                        btnB4.Enabled = false;
                        break;
                    case "B5":
                        btnB5.BackColor = Color.Silver;
                        btnB5.Enabled = false;
                        break;
                    case "B6":
                        btnB6.BackColor = Color.Silver;
                        btnB6.Enabled = false;
                        break;
                    case "B7":
                        btnB7.BackColor = Color.Silver;
                        btnB7.Enabled = false;
                        break;
                    case "B8":
                        btnB8.BackColor = Color.Silver;
                        btnB8.Enabled = false;
                        break;
                    case "C1":
                        btnC1.BackColor = Color.Silver;
                        btnC1.Enabled = false;
                        break;
                    case "C2":
                        btnC2.BackColor = Color.Silver;
                        btnC2.Enabled = false;
                        break;
                    case "C3":
                        btnC3.BackColor = Color.Silver;
                        btnC3.Enabled = false;
                        break;
                    case "C4":
                        btnC4.BackColor = Color.Silver;
                        btnC4.Enabled = false;
                        break;
                    case "C5":
                        btnC5.BackColor = Color.Silver;
                        btnC5.Enabled = false;
                        break;
                    case "C6":
                        btnC6.BackColor = Color.Silver;
                        btnC6.Enabled = false;
                        break;
                    case "C7":
                        btnC7.BackColor = Color.Silver;
                        btnC7.Enabled = false;
                        break;
                    case "C8":
                        btnC8.BackColor = Color.Silver;
                        btnC8.Enabled = false;
                        break;
                    case "D1":
                        btnD1.BackColor = Color.Silver;
                        btnD1.Enabled = false;
                        break;
                    case "D2":
                        btnD2.BackColor = Color.Silver;
                        btnD2.Enabled = false;
                        break;
                    case "D3":
                        btnD3.BackColor = Color.Silver;
                        btnD3.Enabled = false;
                        break;
                    case "D4":
                        btnD4.BackColor = Color.Silver;
                        btnD4.Enabled = false;
                        break;
                    case "D5":
                        btnD5.BackColor = Color.Silver;
                        btnD5.Enabled = false;
                        break;
                    case "D6":
                        btnD6.BackColor = Color.Silver;
                        btnD6.Enabled = false;
                        break;
                    case "D7":
                        btnD7.BackColor = Color.Silver;
                        btnD7.Enabled = false;
                        break;
                    case "D8":
                        btnD8.BackColor = Color.Silver;
                        btnD8.Enabled = false;
                        break;
                }

            }
        }

        //Sự kiện chuyển màu khi nhấn chọn ghế và tự động tính tiền
        private void button16_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            if (clickedBtn != null)
            {
                if (clickedBtn.BackColor == Color.FromArgb(255, 224, 192))
                {
                    clickedBtn.BackColor = Color.Yellow;
                    seats.Add(clickedBtn.Text);
                    if (rbtnNguoiLon.Checked || rbtnSinhVien.Checked)
                    {
                        if (Convert.ToInt32(clickedBtn.Text.Substring(1)) >= 3 && Convert.ToInt32(clickedBtn.Text.Substring(1)) <= 6)
                        {
                                tongtien += 80000;
                        }
                        else tongtien += 60000;
                    }
                    else if (rbtnTreEm.Checked)
                    {
                        if (Convert.ToInt32(clickedBtn.Text.Substring(1)) >= 3 && Convert.ToInt32(clickedBtn.Text.Substring(1)) <= 6)
                        {
                            tongtien += 60000;
                        }
                        else tongtien += 40000;
                    }

                    if (rbtnSinhVien.Checked)
                    {
                        tbTienThu.Text = (tongtien * 0.8).ToString();
                    }
                    else tbTienThu.Text = tongtien.ToString();
                    tbTongTien.Text = tongtien.ToString();
                }
                else if (clickedBtn.BackColor == Color.Yellow)
                {
                    clickedBtn.BackColor = Color.FromArgb(255, 224, 192);

                    if(seats.Count > 0)
                    {
                        if (rbtnNguoiLon.Checked || rbtnSinhVien.Checked)
                        {
                            if (Convert.ToInt32(clickedBtn.Text.Substring(1)) >= 3 && Convert.ToInt32(clickedBtn.Text.Substring(1)) <= 6)
                            {
                                tongtien -= 80000;
                            }
                            else tongtien -= 60000;
                        }
                        else if (rbtnTreEm.Checked)
                        {
                            if (Convert.ToInt32(clickedBtn.Text.Substring(1)) >= 3 && Convert.ToInt32(clickedBtn.Text.Substring(1)) <= 6)
                            {
                                tongtien -= 60000;
                            }
                            else tongtien -= 40000;
                        }

                        if (rbtnSinhVien.Checked)
                        {
                            tbTienThu.Text = (tongtien * 0.8).ToString();
                        }
                        else tbTienThu.Text = tongtien.ToString();
                    }

                    seats.Remove(clickedBtn.Text);

                    tbTongTien.Text = tongtien.ToString();
                }
            }
            this.ActiveControl = null;//Loai bo focus sau khi bam button
        }

        private void rbtnNguoiLon_CheckedChanged(object sender, EventArgs e)
        {
            if (seats.Count > 0)
            {
                tongtien = 0;
                for (int i = 0; i < seats.Count; i++)
                {
                    if (Convert.ToInt32(seats[i].Substring(1)) >= 3 && Convert.ToInt32(seats[i].Substring(1)) <= 6)
                    {
                        tongtien += 80000;
                    }
                    else tongtien += 60000;
                }

                tbTongTien.Text = tongtien.ToString();
                tbTienThu.Text = tongtien.ToString();
            }

            tbGiamGia.Text = "0";
        }

        private void rbtnSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            if (seats.Count > 0)
            {
                tongtien = 0;
                for (int i = 0; i < seats.Count; i++)
                {
                    if (Convert.ToInt32(seats[i].Substring(1)) >= 3 && Convert.ToInt32(seats[i].Substring(1)) <= 6)
                    {
                        tongtien += 80000;
                    }
                    else tongtien += 60000;
                }

                tbTongTien.Text = tongtien.ToString();
            }

            tbGiamGia.Text = "20";
        }

        private void tbTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbtnTreEm_CheckedChanged(object sender, EventArgs e)
        {
            tongtien = 0;
            for (int i = 0; i < seats.Count; i++)
            {
                if (Convert.ToInt32(seats[i].Substring(1)) >= 3 && Convert.ToInt32(seats[i].Substring(1)) <= 6)
                {
                    tongtien += 60000;
                }
                else tongtien += 40000;

                tbTongTien.Text = tongtien.ToString();
                tbTienThu.Text = tongtien.ToString();
            }

            tbGiamGia.Text = "0";
        }

        private void tbGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (tongtien != 0)
            {
                if (tbGiamGia.Text != "")
                {
                    tbTienThu.Text = (tongtien * (1 - Convert.ToDouble(tbGiamGia.Text) / 100)).ToString();
                }
            }
        }

        private void tbGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frmBookTicket(staffID, cinemaID);
            frm.ShowDialog(this);
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(tbTenKH.Text == "" || tbGioiTinh.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin khách hàng");
            }
            else if(rbtnNguoiLon.Enabled == false && rbtnSinhVien.Enabled == false && rbtnTreEm.Enabled == false){
                MessageBox.Show("Chưa chọn loại vé");
            }
            else if(tbTongTien.Text == "0")
            {
                MessageBox.Show("Chưa chọn ghế ngồi");
            }
            else
            {
                List<string> list = new List<string>();
                list.Add(tbTongTien.Text);
                list.Add(tbGiamGia.Text);
                list.Add(tbTienThu.Text);

                if (rbtnNguoiLon.Checked == true)
                {
                    list.Add("Adult");
                }
                else if (rbtnSinhVien.Checked == true)
                {
                    list.Add("Student");
                }
                else if (rbtnTreEm.Checked == true)
                {
                    list.Add("Child");
                }
                userInfor.Add(tbTenKH.Text);
                userInfor.Add(tbGioiTinh.Text);
                userInfor.Add(dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
                this.Hide();
                frmInvoice invoice = new frmInvoice(staffID, cinemaID, date, seats, list, row, userInfor, showtimeID, tbTenKH.Text, dtpNgaySinh.Value.ToString("dd-MM-yyyy"), tbGioiTinh.Text);
                invoice.ShowDialog();
                this.Close();
            }
        }
    }
}
