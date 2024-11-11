using QLRapPhim.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRapPhim
{
    public partial class frmMain : Form
    {
        private string nameStaff;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string name)
        {
            this.nameStaff = name;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Rạp phim Skope", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookTicket frm = new frmBookTicket(nameStaff);
            frm.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }
    }
}
