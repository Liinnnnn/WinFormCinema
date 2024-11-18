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
            {
                DataTable dt = dataProcess.ReadDatabase("Select * From tblStaff where StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    this.Hide();
                    if (dt.Rows[0]["Type_Account"].ToString() == "Staff")
                    {
                        string staffID = dt.Rows[0]["StaffID"].ToString();
                        string cinemaID = dt.Rows[0]["CinemaID"].ToString();
                        frmMain main = new frmMain(staffID, cinemaID);
                        main.ShowDialog();
                    }
                    else
                    {
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.ShowDialog();
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
            if (e.KeyCode == Keys.Enter) {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đẩy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                }
                {
                    DataTable dt = dataProcess.ReadDatabase("Select * From tblStaff where StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'");
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        this.Hide();
                        if (dt.Rows[0]["Type_Account"].ToString() == "Staff")
                        {
                            string staffID = dt.Rows[0]["StaffID"].ToString();
                            string cinemaID = dt.Rows[0]["CinemaID"].ToString();
                            frmMain main = new frmMain(staffID, cinemaID);
                            main.ShowDialog();
                        }
                        else
                        {
                            frmAdmin frmAdmin = new frmAdmin();
                            frmAdmin.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
