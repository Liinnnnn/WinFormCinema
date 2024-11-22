using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRapPhim.Classes;

namespace QLRapPhim
{
    public partial class frmShowTime : Form
    {
        DataProcess process = new DataProcess();

        private void LoadData(string query = @"select tblShowtime.ShowTimeID, tblShowtime.Showtime,tblShowtime.ShowtimeHour ,tblShowtime.FilmID, tblFilm.Name, tblShowtime.CinemaID, tblCinema.CinemaName,tblShowRoom.RoomName
                 From tblShowtime
				 inner join tblShowRoom on tblShowtime.RoomID=tblShowRoom.RoomID
                 inner join tblFilm on tblShowtime.FilmID = tblFilm.FilmID
                 inner join tblCinema on tblShowtime.CinemaID = tblCinema.CinemaID
                                            WHERE Showtime >= CAST(GETDATE() AS DATE)")
        {
            DataTable dt = process.ReadDatabase(query);
            dgvShowTime.DataSource = dt;
            dgvShowTime.Columns["Showtime"].DefaultCellStyle.Format = "dd--MM--yyyy"; // hiển thị trên dgv
            dtpShowTime.CustomFormat = "dd-MM-yyyy "; // hiển thị để chọn
        }
        private void Clear()
        {
            txtShowTimeID.Text = "";
            txtFilm.Text = "";
            txtCinema.Text = "";
            cmbCinemaID.Text = "";
            cmbFilmID.Text = "";
            cmbRoomID.Text = "";
            cmbHour.Text = "";
            txtShowTimeID.Enabled = false;
            btnAddDB.Enabled = false;
            btnDeleteDB.Enabled = false;
            btnUpdateDB.Enabled = false;
            lbNote.Enabled = true;
            btnSearch.Enabled = true;


        }
        public frmShowTime()
        {
            InitializeComponent();
        }

        private void frmShowTime_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvShowTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShowTime.Columns["ShowtimeID"].HeaderText = "Mã Chiếu";
            dgvShowTime.Columns["Showtime"].HeaderText = "Ngày Chiếu";
            dgvShowTime.Columns["FilmID"].HeaderText = "Mã Phim";
            dgvShowTime.Columns["Name"].HeaderText = "Tên Phim";
            dgvShowTime.Columns["CinemaID"].HeaderText = "Mã Rạp";
            dgvShowTime.Columns["CinemaName"].HeaderText = "Tên Rạp";
            dgvShowTime.Columns["RoomName"].HeaderText = "Phòng Chiếu";
            dgvShowTime.Columns["ShowtimeHour"].HeaderText = "Giờ Chiếu";

            txtShowTimeID.Enabled = false;
            btnAddDB.Enabled = false;
            btnDeleteDB.Enabled = false;
            btnUpdateDB.Enabled = false;
            lbNote.Enabled = true;
            btnSearch.Enabled = true;

            foreach (DataGridViewColumn column in dgvShowTime.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataTable film = process.ReadDatabase("Select FilmID From tblFilm");
            DataTable cinema = process.ReadDatabase("Select CinemaID From tblCinema");
            DataTable room = process.ReadDatabase("Select RoomName from tblShowRoom");
            for (int i = 0; i < film.Rows.Count; i++)
            {
                cmbFilmID.Items.Add(film.Rows[i]["FilmID"]);
            }

            for (int i = 0; i < cinema.Rows.Count; i++)
            {
                cmbCinemaID.Items.Add(cinema.Rows[i]["CinemaID"]);
            }
            for (int i = 0; i < room.Rows.Count; i++)
            {
                cmbRoomID.Items.Add(room.Rows[i]["RoomName"]);
            }
            dtpShowTime.MinDate = DateTime.Today;
            dtpShowTime.MaxDate = DateTime.Today.AddDays(7);
            cmbHour.Items.Add("13:00");
            cmbHour.Items.Add("18:00");
            cmbHour.Items.Add("15:00");
            cmbHour.Items.Add("21:00");

        }

        private void dgvShowTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvShowTime.CurrentRow.Index;
            txtShowTimeID.Text = dgvShowTime.Rows[i].Cells[0].Value.ToString();
            dtpShowTime.Text = dgvShowTime.Rows[i].Cells[1].Value.ToString();
            cmbHour.Text = dgvShowTime.Rows[i].Cells[2].Value.ToString();
            cmbFilmID.Text = dgvShowTime.Rows[i].Cells[3].Value.ToString();
            txtFilm.Text = dgvShowTime.Rows[i].Cells[4].Value.ToString();
            cmbCinemaID.Text = dgvShowTime.Rows[i].Cells[5].Value.ToString();
            txtCinema.Text = dgvShowTime.Rows[i].Cells[6].Value.ToString();
            cmbRoomID.Text = dgvShowTime.Rows[i].Cells[7].Value.ToString();
            txtShowTimeID.Enabled = false;
        }

        private void cmbFilmID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbFilmID.SelectedItem.ToString();
            DataTable dt = process.ReadDatabase("Select Name From tblFilm where FilmID = '" + selected + "'");
            txtFilm.Text = dt.Rows[0]["Name"].ToString();
        }

        private void cmbCinemaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectd = cmbCinemaID.SelectedItem.ToString();
            DataTable dt = process.ReadDatabase("Select CinemaName From tblCinema where CinemaID = '" + selectd + "'");
            txtCinema.Text = dt.Rows[0]["CinemaName"].ToString();
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            btnAddDB.Enabled = true;
            btnDeleteDB.Enabled = false;
            btnUpdateDB.Enabled = false;
            lbNote.Enabled = false;
            btnSearch.Enabled = false;
            txtFilm.Text = "";
            txtCinema.Text = "";
            cmbCinemaID.Text = "";
            cmbFilmID.Text = "";
            cmbRoomID.Text = "";
            DataTable dt = process.ReadDatabase("Select top 1 ShowTimeID from tblShowtime order by ShowTimeID Desc");
            if (dt.Rows.Count == 0)
            {
                txtShowTimeID.Text = "ST1";
            }
            else
            {
                string number = Convert.ToString(int.Parse(dt.Rows[0]["ShowTimeID"].ToString().Substring(2)) + 1);
                txtShowTimeID.Text = $"ST{number}";
            }
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {

            btnAddDB.Enabled = false;
            btnDeleteDB.Enabled = false;
            btnUpdateDB.Enabled = true;
            lbNote.Enabled = true;
            btnSearch.Enabled = true;

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            btnAddDB.Enabled = false;
            btnDeleteDB.Enabled = true;
            btnUpdateDB.Enabled = false;
            lbNote.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpShowTime.Value.Date;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("ShowtimeID", txtShowTimeID.Text);
            dic.Add("tblShowtime.Showtime", selectedDate.ToString("yyyy-MM-dd"));
            dic.Add("tblFilm.FilmID", cmbFilmID.Text);
            dic.Add("tblCinema.CinemaID", cmbCinemaID.Text);
            dic.Add("tblShowtime.ShowtimeHour", cmbHour.Text);
            dic.Add("tblShowRoom.RoomName", cmbRoomID.Text);
            int f = 0;
            string query = @"select tblShowtime.ShowTimeID, tblShowtime.Showtime,tblShowtime.ShowtimeHour ,tblShowtime.FilmID, tblFilm.Name, tblShowtime.CinemaID, tblCinema.CinemaName,tblShowRoom.RoomName
                 From tblShowtime
				 inner join tblShowRoom on tblShowtime.RoomID=tblShowRoom.RoomID
                 inner join tblFilm on tblShowtime.FilmID = tblFilm.FilmID
                 inner join tblCinema on tblShowtime.CinemaID = tblCinema.CinemaID";
            foreach (var item in dic)
            {
                if (!string.IsNullOrEmpty(item.Value))
                {
                    if (f == 0)
                    {
                        query += " where " + item.Key + " = '" + item.Value + "'";
                        f++;
                    }
                    else
                    {
                        query += " and " + item.Key + " = '" + item.Value + "'";
                    }
                }
            }
            LoadData(query);

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            if (txtCinema.Text == "" || txtFilm.Text == "" || cmbFilmID.Text == "" || dtpShowTime.Text == "" || cmbRoomID.Text == "" || cmbHour.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                string roomName = cmbRoomID.Text;
                string queryRoomID = "SELECT RoomID FROM tblShowroom WHERE RoomName = '" + roomName + "'";
                DataTable dtRoom = process.ReadDatabase(queryRoomID);
                string room = dtRoom.Rows[0]["RoomID"].ToString();
                int roomID=Convert.ToInt32(room);
                string showtimeFormatted = dtpShowTime.Value.ToString("yyyy-MM-dd ");
                //string query = "Select ShowtimeID from tblShowtime where S ";
                //DataTable dt = process.ReadDatabase(query);
                process.ChangeDatabase("insert into tblShowtime (ShowtimeID, Showtime, FilmID, CinemaID,RoomID,ShowtimeHour) values ('" + txtShowTimeID.Text + "','" + showtimeFormatted + "','" + cmbFilmID.Text + "','" + cmbCinemaID.Text + "','" + roomID + "','" + cmbHour.Text + "')");
                LoadData();
                Clear();
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            string showtimeFormatted = dtpShowTime.Value.ToString("yyyy-MM-dd");
            if (txtCinema.Text == "" || txtFilm.Text == "" || txtShowTimeID.Text == "" || cmbCinemaID.Text == "" || cmbFilmID.Text == "" || cmbRoomID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                DataTable dt = process.ReadDatabase("select count(*) as Count from tblTicket t join tblInvoice i on t.InvoiceID = i.InvoiceID  WHERE ShowtimeID = '" + txtShowTimeID.Text + "'");

                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["Count"]) > 0)
                {

                    MessageBox.Show("Không thể sửa vì đã có người đặt lịch này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    string roomName = cmbRoomID.Text;
                    string queryRoomID = "SELECT RoomID FROM tblShowroom WHERE RoomName = '" + roomName + "'";
                    DataTable dtRoom = process.ReadDatabase(queryRoomID);
                    string room = dtRoom.Rows[0]["RoomID"].ToString();
                    int roomID = Convert.ToInt32(room);
                    if (MessageBox.Show("Bạn có muốn sửa lịch chiếu " + txtShowTimeID.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        process.ChangeDatabase("Update tblShowtime set Showtime = '" + showtimeFormatted + "', FilmID = '" + cmbFilmID.Text + "', CinemaID = '" + cmbCinemaID.Text + "', RoomID = '" + roomID + "',ShowtimeHour='" + cmbHour.Text + "' where ShowtimeID = '" + txtShowTimeID.Text + "'");
                        LoadData();
                    }
                }
            }
        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            if (txtShowTimeID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một lịch chiếu để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = process.ReadDatabase("select count(*) as Count from tblTicket t join tblInvoice i on t.InvoiceID = i.InvoiceID  WHERE ShowtimeID = '" + txtShowTimeID.Text + "'");

                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["Count"]) > 0)
                {

                    MessageBox.Show("Không thể xóa vì đã có người đặt lịch này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (MessageBox.Show("Bạn có muốn xóa lịch chiếu " + txtShowTimeID.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        process.ChangeDatabase("delete from tblShowtime where ShowtimeID = '" + txtShowTimeID.Text + "'");
                        MessageBox.Show("Lịch chiếu đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK);
                        LoadData();
                    }
                }
            }
        }

        private void dgvShowTime_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvShowTime.CurrentRow.Index;
            txtShowTimeID.Text = dgvShowTime.Rows[i].Cells[0].Value.ToString();
            dtpShowTime.Text = dgvShowTime.Rows[i].Cells[1].Value.ToString();
            cmbHour.Text = dgvShowTime.Rows[i].Cells[2].Value.ToString();
            cmbFilmID.Text = dgvShowTime.Rows[i].Cells[3].Value.ToString();
            txtFilm.Text = dgvShowTime.Rows[i].Cells[4].Value.ToString();
            cmbCinemaID.Text = dgvShowTime.Rows[i].Cells[5].Value.ToString();
            txtCinema.Text = dgvShowTime.Rows[i].Cells[6].Value.ToString();
            cmbRoomID.Text = dgvShowTime.Rows[i].Cells[7].Value.ToString();
            txtShowTimeID.Enabled = false;
        }
    }
}
