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
    public partial class frmLogin : Form
    {
        private DataProcess dataProcess = new DataProcess();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đẩy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = dataProcess.ReadDatabase("Select * From tblStaff where StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    
                    DataTable dt1 = dataProcess.ReadDatabase("Select * From tblStaff where StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "' and Status = N'Đang làm' and Type_Account = 'Staff'");
                    DataTable dt2 = dataProcess.ReadDatabase("Select * From tblStaff where StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "' and Type_Account = 'Admin'");
                    if (dt2.Rows.Count == 0 && dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                    }
                    else if (dt2.Rows.Count > 0)
                    {
                        this.Hide();
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.ShowDialog();
                        this.Close();
                    }
                    else if (dt1.Rows.Count > 0)
                    {
                        this.Hide();
                        string staffID = dt1.Rows[0]["StaffID"].ToString();
                        string cinemaID = dt1.Rows[0]["CinemaID"].ToString();
                        frmMain main = new frmMain(staffID, cinemaID);
                        main.ShowDialog();
                        this.Close();
                    }
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Rạp phim Skope", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đẩy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt1 = dataProcess.ReadDatabase("Select * From tblStaff where StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "' and Status = N'Đang làm' and Type_Account = 'Staff'");
                    DataTable dt2 = dataProcess.ReadDatabase("Select * From tblStaff where StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "' and Type_Account = 'Admin'");
                    if (dt2.Rows.Count == 0 && dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                    }
                    else if (dt2.Rows.Count > 0)
                    {
                        this.Hide();
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.ShowDialog();
                        this.Close();
                    }
                    else if (dt1.Rows.Count > 0)
                    {
                        this.Hide();
                        string staffID = dt1.Rows[0]["StaffID"].ToString();
                        string cinemaID = dt1.Rows[0]["CinemaID"].ToString();
                        frmMain main = new frmMain(staffID, cinemaID);
                        main.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đẩy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt1 = dataProcess.ReadDatabase("Select * From tblStaff where StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "' and Status = N'Đang làm' and Type_Account = 'Staff'");
                    DataTable dt2 = dataProcess.ReadDatabase("Select * From tblStaff where StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "' and Type_Account = 'Admin'");
                    if (dt2.Rows.Count == 0 && dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                    }
                    else if (dt2.Rows.Count > 0)
                    {
                        this.Hide();
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.ShowDialog();
                        this.Close();
                    }
                    else if (dt1.Rows.Count > 0)
                    {
                        this.Hide();
                        string staffID = dt1.Rows[0]["StaffID"].ToString();
                        string cinemaID = dt1.Rows[0]["CinemaID"].ToString();
                        frmMain main = new frmMain(staffID, cinemaID);
                        main.ShowDialog();
                        this.Close();
                    }
                   
                }
            }
        }
    }
}
