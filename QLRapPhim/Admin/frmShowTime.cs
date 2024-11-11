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

        private void LoadData(string query = @"Select ShowTimeID, Showtime, tblShowtime.FilmID, tblFilm.Name,tblShowtime.CinemaID, tblCinema.CinemaName
                        From tblShowtime inner join tblFilm on tblShowtime.FilmID = tblFilm.FilmID
                                          inner join tblCinema on tblShowtime.CinemaID = tblCinema.CinemaID
                                            where Showtime >= GetDate()")
        {
            DataTable dt = process.ReadDatabase(query);
            dgvShowTime.DataSource = dt;

        }
        private void Clear()
        {
            txtShowTimeID.Text = "";
            txtFilm.Text = "";
            txtCinema.Text = "";
            cmbCinemaID.Text = "";
            cmbFilmID.Text = "";

            txtShowTimeID.Enabled = false;
            btnAddDB.Visible = false;
            btnDeleteDB.Visible = false;
            btnUpdateDB.Visible = false;
            lbNote.Visible = true;
            btnSearch.Visible = true;


        }
        public frmShowTime()
        {
            InitializeComponent();
        }

        private void frmShowTime_Load(object sender, EventArgs e)
        {
            dtpShowTime.CustomFormat = "MM-dd-yyyy HH:mm:ss";
            LoadData();
            dgvShowTime.Columns["ShowtimeID"].HeaderText = "Mã Chiếu";
            dgvShowTime.Columns["Showtime"].HeaderText = "Thời Gian Chiếu";
            dgvShowTime.Columns["FilmID"].HeaderText = "Mã Phim";
            dgvShowTime.Columns["Name"].HeaderText = "Tên Phim";
            dgvShowTime.Columns["CinemaID"].HeaderText = "Mã Rạp";
            dgvShowTime.Columns["CinemaName"].HeaderText = "Tên Rạp";

            txtShowTimeID.Enabled = false;
            btnAddDB.Visible = false;
            btnDeleteDB.Visible = false;
            btnUpdateDB.Visible = false;
            lbNote.Visible = true;
            btnSearch.Visible = true;

            foreach (DataGridViewColumn column in dgvShowTime.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataTable film = process.ReadDatabase("Select FilmID From tblFilm");
            DataTable cinema = process.ReadDatabase("Select CinemaID From tblCinema");
            for(int i = 0; i < film.Rows.Count; i++)
            {
                cmbFilmID.Items.Add(film.Rows[i]["FilmID"]);
            }

            for(int i = 0; i < cinema.Rows.Count; i++)
            {
                cmbCinemaID.Items.Add(cinema.Rows[i]["CinemaID"]);
            }
            dtpShowTime.MinDate = DateTime.Now;
            dtpShowTime.MaxDate = DateTime.Now.AddDays(7);
           
        }

        private void dgvShowTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvShowTime.CurrentRow.Index;
            txtShowTimeID.Text = dgvShowTime.Rows[i].Cells[0].Value.ToString();
            dtpShowTime.Text = dgvShowTime.Rows[i].Cells[1].Value.ToString();
            cmbFilmID.Text = dgvShowTime.Rows[i].Cells[2].Value.ToString();
            txtFilm.Text = dgvShowTime.Rows[i].Cells[3].Value.ToString();
            cmbCinemaID.Text = dgvShowTime.Rows[i].Cells[4].Value.ToString();
            txtCinema.Text = dgvShowTime.Rows[i].Cells[5].Value.ToString();
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
            btnAddDB.Visible = true;
            btnDeleteDB.Visible = false;
            btnUpdateDB.Visible = false;
            lbNote.Visible = false;
            btnSearch.Visible = false;
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            
            btnAddDB.Visible = false;
            btnDeleteDB.Visible = false;
            btnUpdateDB.Visible = true;
            lbNote.Visible = true;
            btnSearch.Visible = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            btnAddDB.Visible = false;
            btnDeleteDB.Visible = true;
            btnUpdateDB.Visible = false;
            lbNote.Visible = true;
            btnSearch.Visible = true;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpShowTime.Value;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("ShowtimeID", txtShowTimeID.Text);
            dic.Add("convert(date, tblShowtime.Showtime)", selectedDate.Year.ToString() + "-" + selectedDate.Month.ToString("00") + "-" + selectedDate.Day.ToString("00"));
            dic.Add("tblFilm.FilmID", cmbFilmID.Text);
            dic.Add("tblCinema.CinemaID", cmbCinemaID.Text);
            int f = 0;
            string query = @"Select tblShowtime.ShowTimeID, tblShowtime.Showtime, tblShowtime.FilmID, tblFilm.Name,tblShowtime.CinemaID, tblCinema.CinemaName
                        From tblShowtime inner join tblFilm on tblShowtime.FilmID = tblFilm.FilmID
                                          inner join tblCinema on tblShowtime.CinemaID = tblCinema.CinemaID ";
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
            if (txtCinema.Text == "" || txtFilm.Text == "" || txtShowTimeID.Text == "" || cmbCinemaID.Text == "" || cmbFilmID.Text == "" || dtpShowTime.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                string query = "Select ShowtimeID from tblShowtime where ";
                DataTable dt = process.ReadDatabase(query);
                

                process.ChangeDatabase("insert into tblShowtime (ShowtimeID, Showtime, FilmID, CinemaID) values ('" + txtShowTimeID.Text + "','" + dtpShowTime.Text + "','" + cmbFilmID.Text + "','" + cmbCinemaID.Text + "')");
                LoadData();
                Clear();
                
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            if (txtCinema.Text == "" || txtFilm.Text == "" || txtShowTimeID.Text == "" || cmbCinemaID.Text == "" || cmbFilmID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa lịch chiếu " + txtShowTimeID.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    process.ChangeDatabase("Update tblShowtime set Showtime = '" + dtpShowTime.Text + "', FilmID = '" + cmbFilmID.Text + "', CinemaID = '" + cmbCinemaID.Text + "' where ShowtimeID = '" + txtShowTimeID.Text + "'");
                    LoadData();
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
                if (MessageBox.Show("Bạn có muốn xóa lịch chiếu " + txtShowTimeID.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataTable dt = process.ReadDatabase("Select ShowtimeID From tblShowtime where ShowtimeID = '" + txtShowTimeID.Text + "'");
                    process.ChangeDatabase("Delete from tblShowtime where ShowtimeID = '" + txtShowTimeID.Text + "'");
                    LoadData();
                }
            }
        }
    }
}
