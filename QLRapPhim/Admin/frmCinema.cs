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
    public partial class frmCinema : Form
    {

        DataProcess process = new DataProcess();

        private void LoadData()
        {
            cmbCinemaID.Items.Clear();

            txtCinemaID.Text = "";
            txtCinemaName.Text = "";
            txtAddress.Text = "";
            cmbCinemaID.Text = "";

            DataTable dt = process.ReadDatabase("Select CinemaID, CinemaName, Address,Status From tblCinema");
            dgvCinema.DataSource = dt;
            dgvCinema.Columns["CinemaID"].HeaderText = "Mã Rạp";
            dgvCinema.Columns["CinemaName"].HeaderText = "Tên Rạp";
            dgvCinema.Columns["Address"].HeaderText = "Địa Chỉ";
            dgvCinema.Columns["Status"].HeaderText = "Trạng Thái";
            foreach (DataGridViewColumn column in dgvCinema.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            DataTable dtc = process.ReadDatabase("Select CinemaID From tblCinema");

            foreach (DataRow row in dtc.Rows)
            {
                cmbCinemaID.Items.Add(row["CinemaID"].ToString());
            }
        }

        private void Cancel()
        {
            txtCinemaID.Text = "";
            txtCinemaName.Text = "";
            txtAddress.Text = "";
            cmbCinemaID.SelectedIndex = -1;
        }
        public frmCinema()
        {
            InitializeComponent();
        }

        private void frmCinema_Load(object sender, EventArgs e)
        {
            txtCinemaID.Enabled = false;
            btnAddDB.Enabled = false;
            btnUpdateDB.Enabled = false;
            btnSearch.Enabled = true;
            cmbCinemaID.Enabled = true;
            LoadData();

            cmbStatus.Items.Add("Hoạt Động");
            cmbStatus.Items.Add("Dừng Hoạt Động");
            dgvCinema.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dgvCinema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCinema.CurrentRow.Index;
            txtCinemaID.Text = dgvCinema.Rows[i].Cells["CinemaID"].Value.ToString();
            txtCinemaName.Text = dgvCinema.Rows[i].Cells["CinemaName"].Value.ToString();
            txtAddress.Text = dgvCinema.Rows[i].Cells["Address"].Value.ToString();
            if (dgvCinema.Rows[i].Cells["Status"].Value.ToString() == "Hoạt Động") cmbStatus.SelectedIndex = 0;
            else cmbStatus.SelectedIndex = 1;
            txtCinemaID.Enabled = false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtCinemaID.Enabled = true;
            btnAddDB.Enabled = true;
            btnUpdateDB.Enabled = false;
            btnSearch.Enabled = false;
            cmbCinemaID.Enabled = false;
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            txtCinemaID.Enabled = false;
            btnAddDB.Enabled = false;
            btnUpdateDB.Enabled = true;
            btnSearch.Enabled = true;
            cmbCinemaID.Enabled = true;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCinema.ClearSelection();
            if(cmbCinemaID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một rạp chiếu phim", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = process.ReadDatabase("Select * From tblCinema Where CinemaID = '" + cmbCinemaID.Text + "'");
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Rạp phim không tồn tại", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    foreach (DataGridViewRow row in dgvCinema.Rows)
                    {
                        if (row.Cells["CinemaID"].Value.ToString() == cmbCinemaID.Text)
                        {
                            row.Selected = true;
                            dgvCinema.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }

                    txtCinemaID.Text = dt.Rows[0]["CinemaID"].ToString();
                    txtCinemaName.Text = dt.Rows[0]["CinemaName"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    if (dt.Rows[0]["Status"].ToString() == "Hoạt Động") cmbStatus.SelectedIndex = 0;
                    else cmbStatus.SelectedIndex = 1;
                }
            }    
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtCinemaID.Enabled = false;
            btnAddDB.Enabled = false;
            btnUpdateDB.Enabled = false;
            btnSearch.Enabled = true;
            cmbCinemaID.Enabled = true;
            Cancel();

        }


        private void btnAdđB_Click(object sender, EventArgs e)
        {
            if (txtCinemaID.Text == "" || txtCinemaName.Text == "" || txtAddress.Text == "" || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = process.ReadDatabase("Select CinemaID From tblCinema Where CinemaID = '" + txtCinemaID.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    process.ChangeDatabase("insert into tblCinema (CinemaID,CinemaName,Address,Status) values ('" + txtCinemaID.Text + "',N'" + txtCinemaName.Text + "',N'" + txtAddress.Text + "',N'"+cmbStatus.Text+"')");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Rạp chiếu phim đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            if (txtCinemaID.Text == "" || txtCinemaName.Text == "" || txtAddress.Text == "" || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thay đổi thông tin rạp " + txtCinemaID.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    process.ChangeDatabase("update tblCinema set CinemaName = N'" + txtCinemaName.Text + "', Address = N'" + txtAddress.Text + "', Status = N'"+cmbStatus.Text+"' where CinemaID = '" + txtCinemaID.Text + "'");
                    LoadData();
                }
            }
        }
    }
}
