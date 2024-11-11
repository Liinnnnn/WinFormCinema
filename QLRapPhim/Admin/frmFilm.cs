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
    public partial class frmFilm : Form
    {
        private DataProcess process = new DataProcess();
        private void LoadData()
        {
            cmbFilmID.Items.Clear();
            
            DataTable dt = process.ReadDatabase("Select FilmID, Name, Language, Director, ProductionDate, Price From tblFilm");
            dgvFilm.DataSource = dt;
            dgvFilm.Columns["FilmID"].HeaderText = "Mã Phim";
            dgvFilm.Columns["Name"].HeaderText = "Tên Phim";
            dgvFilm.Columns["Language"].HeaderText = "Ngôn Ngữ";
            dgvFilm.Columns["Director"].HeaderText = "Đạo Diễn";
            dgvFilm.Columns["ProductionDate"].HeaderText = "Ngày Phát Hành";
            dgvFilm.Columns["Price"].HeaderText = "Giá Vé";
            foreach (DataGridViewColumn column in dgvFilm.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            DataTable dtf = process.ReadDatabase("Select FilmID From tblFilm");
            foreach (DataRow row in dtf.Rows)
            {
                cmbFilmID.Items.Add(row["FilmID"].ToString());
            }
            txtFilmID.Text = "";
            txtName.Text = "";
            txtDirector.Text = "";
            txtLanguage.Text = "";
            txtName.Text = "";
            cmbFilmID.Text = "";
            txtPrice.Text = "";
            dtpDate.Value = DateTime.Now;
        }

        private void Cancel()
        {
            txtFilmID.Enabled = false;
            txtFilmID.Text = "";
            txtName.Text = "";
            txtLanguage.Text = "";
            txtDirector.Text = "";
            txtPrice.Text = "";
            dtpDate.Value = DateTime.Now;

            lbFilmIDSearch.Visible = true;
            cmbFilmID.Visible = true;
            btnSearch.Visible = true;
            btnDeleteDB.Visible = false;
            btnUpdateDB.Visible = false;
            btnAddDB.Visible = false;
        }
        public frmFilm()
        {

            InitializeComponent();
        }

        private void frmFilm_Load(object sender, EventArgs e)
        {
            txtFilmID.Enabled = false;
            lbFilmIDSearch.Visible = true;
            cmbFilmID.Visible = true;
            btnSearch.Visible = true;
            btnDeleteDB.Visible = false;
            btnUpdateDB.Visible = false;
            btnAddDB.Visible = false;
            LoadData();
        }

        private void dgvFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvFilm.CurrentRow.Index;
            txtFilmID.Text = dgvFilm.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvFilm.Rows[i].Cells["Name"].Value.ToString();
            txtLanguage.Text = dgvFilm.Rows[i].Cells["Language"].Value.ToString();
            txtDirector.Text = dgvFilm.Rows[i].Cells["Director"].Value.ToString();
            dtpDate.Text = dgvFilm.Rows[i].Cells["ProductionDate"].Value.ToString();
            txtPrice.Text = dgvFilm.Rows[i].Cells["Price"].Value.ToString();
        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Cancel();
            txtFilmID.Enabled = true;
            lbFilmIDSearch.Visible = false;
            cmbFilmID.Visible = false;
            btnSearch.Visible = false;
            btnDeleteDB.Visible = false;
            btnUpdateDB.Visible = false;
            btnAddDB.Visible = true;
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            txtFilmID.Enabled = false;
            lbFilmIDSearch.Visible = true;
            cmbFilmID.Visible = true;
            btnSearch.Visible = true;
            btnDeleteDB.Visible = false;
            btnUpdateDB.Visible = true;
            btnAddDB.Visible = false;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            txtFilmID.Enabled = false;
            lbFilmIDSearch.Visible = true;
            cmbFilmID.Visible = true;
            btnSearch.Visible = true;
            btnDeleteDB.Visible = true;
            btnUpdateDB.Visible = false;
            btnAddDB.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            if(txtFilmID.Text == "" || txtName.Text == "" || txtLanguage.Text == "" || txtDirector.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phim", "Thông báo", MessageBoxButtons.OK);
                //if (txtFilmID.Text == "") lbNFilmID.Visible = true;
                //if (txtName.Text == "") lbNName.Visible = true;
                //if (txtLanguage.Text == "") lbNLanguage.Visible = true;
                //if (txtDirector.Text == "") lbNDirector.Visible = true;
                //if (txtPrice.Text == "") lbNPrice.Visible = true;

            }
            else
            {
                DataTable dts = process.ReadDatabase("Select * from tblFilm where FilmID = '" + txtFilmID.Text + "'");
                if(dts.Rows.Count > 0)
                {
                    MessageBox.Show("Mã phim hoặc phim đã tông tại", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    process.ChangeDatabase("Insert into tblFilm (FilmID, Name, Language, Director, ProductionDate, Price) values ('" + txtFilmID.Text + "', N'" + txtName.Text + "', N'" + txtLanguage.Text + "', N'" + txtDirector.Text + "','" + dtpDate.Text + "', '" + txtPrice.Text + "')");
                    LoadData();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvFilm.ClearSelection();
            if(cmbFilmID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một phim", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = process.ReadDatabase("Select * From tblFilm Where FilmID = '" + cmbFilmID.Text + "'");
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Phim không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvFilm.Rows)
                    {
                        if (row.Cells["FilmID"].Value.ToString() == cmbFilmID.Text)
                        {
                            row.Selected = true;
                            dgvFilm.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }

                    txtFilmID.Text = dt.Rows[0]["FilmID"].ToString();
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtLanguage.Text = dt.Rows[0]["Language"].ToString();
                    txtDirector.Text = dt.Rows[0]["Director"].ToString();
                    txtPrice.Text = dt.Rows[0]["Price"].ToString();
                    dtpDate.Text = dt.Rows[0]["ProductionDate"].ToString();
                }
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            if(txtFilmID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một phim", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                if (txtName.Text == "" || txtLanguage.Text == "" || txtPrice.Text == "" || txtDirector.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phim", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                   if(MessageBox.Show("Bạn có muốn thay đổi thông tin phim "+txtFilmID.Text+" không","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                   {
                        process.ChangeDatabase("Update tblFilm set Name = N'" + txtName.Text + "', Language = N'" + txtLanguage.Text + "', Director = N'" + txtDirector.Text + "', ProductionDate = '" + dtpDate.Text + "', Price = '" + txtPrice.Text + "' Where FilmID = '"+txtFilmID.Text+"'");
                        LoadData();
                   }    
                }
            }
        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            if(txtFilmID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một phim", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa phim " + txtFilmID.Text + " không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    process.ChangeDatabase("Delete from tblFilm Where FilmID = '"+txtFilmID.Text+"'");
                    LoadData();
                }
            }
        }

        
    }
}
