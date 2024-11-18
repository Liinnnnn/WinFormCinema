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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            menuStrip1.Font = new Font("Arial", 12);
        }
        private Form currentChilForm;

        private void OpenChilForm(Form chilForm)
        {
            if(currentChilForm!=null)
            {
                currentChilForm.Close();
            }
            currentChilForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(chilForm);
            pnMain.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
        }


        private void danhSáchPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChilForm(new frmFilm());
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChilForm(new frmStaff());
        }


        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Rạp phim Skope", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thôngTinLịchChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChilForm(new frmShowTime());
        }

        private void danhSáchRạpChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChilForm(new frmCinema());
        }


        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChilForm(new frmFRevenue());
        }

        private void doanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChilForm(new frmFRevenue());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Rạp phim Skope", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
