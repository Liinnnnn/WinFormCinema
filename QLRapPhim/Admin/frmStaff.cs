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
    public partial class frmStaff : Form
    {
        private DataProcess process = new DataProcess();
        public frmStaff()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            cmbMNV.Items.Clear();
            DataTable dt = process.ReadDatabase(@"Select StaffID, Name, Gender, BirthDay, NumberPhone, WorkStartDate, Password, CinemaID,Status
                                   From tblStaff
                                   Where Type_Account = '" +"Staff"+"'");
            dgvStaff.DataSource = dt;
            dgvStaff.Columns["StaffID"].HeaderText = "ID";
            dgvStaff.Columns["Name"].HeaderText = "Họ Và Tên";
            dgvStaff.Columns["Gender"].HeaderText = "Giới Tính";
            dgvStaff.Columns["BirthDay"].HeaderText = "Ngày Sinh";
            dgvStaff.Columns["NumberPhone"].HeaderText = "Số Điện Thoại";
            dgvStaff.Columns["WorkStartDate"].HeaderText = "Ngày Vào Làm";
            dgvStaff.Columns["Password"].HeaderText = "Mật Khẩu";
            dgvStaff.Columns["CinemaID"].HeaderText = "Cơ Sở";
            dgvStaff.Columns["Status"].HeaderText = "Trạng Thái";
            foreach (DataGridViewColumn column in dgvStaff.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataTable dtnv = process.ReadDatabase(@"Select StaffID From tblStaff where Type_Account = '"+"Staff"+"'");
            for(int i = 0; i < dtnv.Rows.Count; i++)
            {
                cmbMNV.Items.Add(dtnv.Rows[i]["StaffID"].ToString());
            }

            txtStaffID.Enabled = false;
        }

        private void Cancel()
        {
            txtName.Text = "";
            txtPhoneNB.Text = "";
            txtPassword.Text = "";
            txtStaffID.Text = "";
            cmbBrach.Text = "";
            cmbMNV.Text = "";
            rdoKhac.Checked = false;
            rdoNam.Checked = false;
            rdoNu.Checked = false;

            comboBox1.SelectedIndex = -1;
            
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            btnAddDB.Enabled = false;
            btnSearch.Enabled = true;
            lbMNVSearch.Enabled = true;
            cmbMNV.Enabled = true;
            btnUpdateDB.Enabled = false;
            LoadData();
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dtb = process.ReadDatabase("Select CinemaID From tblCinema");
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                cmbBrach.Items.Add(dtb.Rows[i]["CinemaID"]);
            }
        }
        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStaffID.Enabled = false;
            int i = dgvStaff.CurrentRow.Index;
            txtStaffID.Text = dgvStaff.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvStaff.Rows[i].Cells[1].Value.ToString();
            if(dgvStaff.Rows[i].Cells[2].Value.ToString() == "Khác") rdoKhac.Checked = true;
            if(dgvStaff.Rows[i].Cells[2].Value.ToString() == "Nữ") rdoNu.Checked = true;
            else rdoNam.Checked = true;
            dtpBirthday.Text = dgvStaff.Rows[i].Cells[3].Value.ToString();
            txtPhoneNB.Text = dgvStaff.Rows[i].Cells[4].Value.ToString();
            dtpWSDate.Text = dgvStaff.Rows[i].Cells[5].Value.ToString();
            txtPassword.Text = dgvStaff.Rows[i].Cells[6].Value.ToString();
            cmbBrach.Text = dgvStaff.Rows[i].Cells[7].Value.ToString();

            if (dgvStaff.Rows[i].Cells["Status"].Value.ToString() == "Đang làm") comboBox1.SelectedIndex = 0;
            else comboBox1.SelectedIndex = 1;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            btnAddDB.Enabled = true;
            btnSearch.Enabled = false;
            lbMNVSearch.Enabled = false;
            cmbMNV.Enabled = false;
            btnUpdateDB.Enabled = false;

            DataTable dt = process.ReadDatabase("Select top 1 StaffID from tblStaff order by StaffID Desc");
            if(dt.Rows.Count == 0)
            {
                txtStaffID.Text = "NV001";
            }
            else
            {
                string number = Convert.ToString(int.Parse(dt.Rows[0]["StaffID"].ToString().Substring(2)) + 1);
                txtStaffID.Text = $"NV{number.PadLeft(3,'0')}";
            }
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            btnAddDB.Enabled = false;
            btnSearch.Enabled = true;
            lbMNVSearch.Enabled = true;
            cmbMNV.Enabled = true;
            btnUpdateDB.Enabled = true;
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnAddDB.Enabled = false;
            btnSearch.Enabled = true;
            lbMNVSearch.Enabled = true;
            cmbMNV.Enabled = true;
            btnUpdateDB.Enabled = false;
            Cancel();
            //LoadData();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dgvStaff.ClearSelection();
            if(cmbMNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            DataTable dtnv = process.ReadDatabase("Select * from tblStaff where StaffID = '" + cmbMNV.Text + "'");
            if(dtnv.Rows.Count == 0)
            {
                MessageBox.Show("Mã nhân viên không tôn tại", "Thông báo", MessageBoxButtons.OK);
                cmbMNV.Text = "";
            }
            else
            {
                string query = @"Select StaffID, Name, Gender, BirthDay, NumberPhone, WorkStartDate, Password, CinemaID, Status
                                       From tblStaff
                                       Where Type_Account = '" + "Staff" + "' and StaffID = N'" + cmbMNV.Text + "'";
                DataTable dt = process.ReadDatabase(query);

                foreach (DataGridViewRow row in dgvStaff.Rows)
                {
                    if (row.Cells["StaffID"].Value.ToString() == cmbMNV.Text)
                    {
                        row.Selected = true;
                        dgvStaff.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }

                txtStaffID.Text = cmbMNV.Text;
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtPassword.Text = dt.Rows[0]["Password"].ToString();
                if (dt.Rows[0]["Gender"].ToString() == "Khác") rdoKhac.Checked = true;
                else if(dt.Rows[0]["Gender"].ToString() == "Nữ") rdoNu.Checked = true;
                else rdoNam.Checked = true;
                dtpBirthday.Text = dt.Rows[0]["BirthDay"].ToString();
                txtPhoneNB.Text = dt.Rows[0]["NumberPhone"].ToString();
                cmbBrach.Text = dt.Rows[0]["CinemaID"].ToString();
                dtpWSDate.Text = dt.Rows[0]["WorkStartDate"].ToString();

                if (dt.Rows[0]["Status"].ToString() == "Đang làm") comboBox1.SelectedIndex = 0;
                else comboBox1.SelectedIndex = 1;
            }
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            if (txtStaffID.Text == "" || txtName.Text == "" || txtPhoneNB.Text == "" || txtPassword.Text == "" || cmbBrach.Text == "" || dtpBirthday.Text == "" || dtpWSDate.Text == "" || (rdoKhac.Checked == false && rdoNam.Checked == false && rdoNu.Checked == false)||comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = process.ReadDatabase("Select StaffID From tblStaff where StaffID = '" + txtStaffID.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    string gender = "";
                    if (rdoKhac.Checked == true) gender = "Khác";
                    if (rdoNam.Checked == true) gender = "Nam";
                    if (rdoNu.Checked == true) gender = "Nữ";
                    string query = @"Insert into tblStaff (StaffID, Name, Gender, BirthDay, NumberPhone, WorkStartDate, Password, Type_Account, CinemaID,Status)
                                     Values ('" + txtStaffID.Text + "',N'" + txtName.Text + "',N'" + gender + "','" + dtpBirthday.Value.ToString("yyyy-MM-dd") + "','" + txtPhoneNB.Text + "','" + dtpWSDate.Value.ToString("yyyy-MM-dd") + "','" + txtPassword.Text + "','" + "Staff" + "','" + cmbBrach.Text + "', N'"+comboBox1.Text+"')";
                    process.ChangeDatabase(query);
                    MessageBox.Show("Thêm nhân viên " + txtName.Text + " thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadData();
                    Cancel();
                }
                else
                {
                    MessageBox.Show("Nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhoneNB.Text == "" || txtPassword.Text == "" || cmbBrach.Text == "" || dtpBirthday.Text == "" || dtpWSDate.Text == "" || (rdoKhac.Checked == false && rdoNam.Checked == false && rdoNu.Checked == false) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string gender = "";
                if (rdoKhac.Checked == true) gender = "Khác";
                if (rdoNam.Checked == true) gender = "Nam";
                if (rdoNu.Checked == true) gender = "Nữ";
                string query = @"update tblStaff set Name = N'" + txtName.Text + "', Gender = N'" + gender + "', BirthDay = '" + dtpBirthday.Value.ToString("yyyy-MM-dd") + "', NumberPhone = '" + txtPhoneNB.Text + "', WorkStartDate = '" + dtpWSDate.Value.ToString("yyyy-MM-dd") + "', Password = '" + txtPassword.Text + "', CinemaID = '" + cmbBrach.Text + "' , Status = N'"+comboBox1.Text+"' where StaffID = '" + txtStaffID.Text + "'";

                if (MessageBox.Show("Bạn có muốn thay đổi thông tin nhân viên " + txtStaffID.Text, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    process.ChangeDatabase(query);
                    MessageBox.Show("Sửa thông tin nhân viên " + txtName.Text + " thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadData();
                    Cancel();
                }
            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPhoneNB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
