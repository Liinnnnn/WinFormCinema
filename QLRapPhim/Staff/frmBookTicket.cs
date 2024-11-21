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
    public partial class frmBookTicket : Form
    {
        private string staffID, cinemaID;
        DataTable table = new DataTable();
        DataProcess data = new DataProcess();
        public frmBookTicket()
        {
            InitializeComponent();
        }
        public frmBookTicket(string staff, string cinema)
        {
            this.staffID = staff;
            this.cinemaID = cinema;
            InitializeComponent();
        }
        private void frmBookTicket_Load(object sender, EventArgs e)
        {
            DataTable tb1 = data.ReadDatabase("select * from tblStaff where StaffID = '" + staffID + "'");
            DataTable tb2 = data.ReadDatabase("select * from tblCinema where CinemaID = '" + cinemaID + "'");
            DataTable table = new DataTable();
            table.Columns.Add("Tên Phòng Chiếu");
            table.Columns.Add("Tên Phim");
            table.Columns.Add("Giờ Chiếu");
            table.Columns.Add("Số Ghế Trống");
            dgvLichChieu.DataSource = table;
            lblTenRap.Text += tb2.Rows[0]["CinemaName"].ToString();
            lblNhanVien.Text += tb1.Rows[0]["Name"].ToString();
        }

        private void frmBookTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain(staffID, cinemaID);
            frm.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cbbPhim.Items.Clear();
            cbbPhim.SelectedIndex = -1;
            cbbPhim.Text = "";

            DataTable table = data.ReadDatabase("select distinct f.Name from tblShowtime st join tblFilm f on st.FilmID = f.FilmID where CAST(st.Showtime as date) = '" + dtpNgayChieu.Value.ToString("yyyy-MM-dd") + "' and st.CinemaID = '" + cinemaID + "'");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbbPhim.Items.Add(table.Rows[i]["Name"]);
            }
        }

        private void cbbPhim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable table = data.ReadDatabase("select sr.RoomName, film.Name, st.ShowtimeHour, 32-(select count(TicketID) " +
                    "from tblTicket where ShowtimeID = st.ShowtimeID ) as Status from tblShowtime st join tblFilm film on film.FilmID = st.FilmID " +
                    "join tblShowRoom sr on sr.RoomID = st.RoomID where sr.CinemaID = '" + cinemaID + "' and film.Name = N'" + cbbPhim.Text + "' and CAST(st.Showtime as date) = '" + dtpNgayChieu.Value.ToString("yyyy-MM-dd") + "'");
                dgvLichChieu.DataSource = table;
                dgvLichChieu.Columns[0].HeaderText = "Tên Phòng Chiếu";
                dgvLichChieu.Columns[1].HeaderText = "Tên Phim";
                dgvLichChieu.Columns[2].HeaderText = "Giờ Chiếu";
                dgvLichChieu.Columns[3].HeaderText = "Số Ghế Trống";
            }

        }

        private void dgvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvLichChieu.Rows[e.RowIndex];
                string time = selectedRow.Cells["ShowtimeHour"].Value.ToString();
                DataTable tb = data.ReadDatabase("select * from tblShowtime st join tblFilm film on film.FilmID = st.FilmID where st.CinemaID = '" + cinemaID + "' and film.Name = N'" + cbbPhim.Text + "' and CAST(st.Showtime as date) = '" + dtpNgayChieu.Value.ToString("yyyy-MM-dd") + "'");
                frmSeatOptions frm = new frmSeatOptions(selectedRow, dtpNgayChieu.Value.ToString("yyyy-MM-dd"), time, cbbPhim.Text, staffID, cinemaID, tb.Rows[0]["ShowtimeID"].ToString());
                frm.ShowDialog();
            }
        }
    }
}
