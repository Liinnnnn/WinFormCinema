using System;
using System.Collections.Generic;
using System.IO;
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
        string imageName = "";
        private void LoadData()
        {
            cmbFilmID.Items.Clear();
            
            DataTable dt = process.ReadDatabase("Select FilmID, Name, Language, Director, ProductionDate, Price,FilmImg, Status From tblFilm");
            dgvFilm.DataSource = dt;
            dgvFilm.Columns["FilmID"].HeaderText = "Mã Phim";
            dgvFilm.Columns["Name"].HeaderText = "Tên Phim";
            dgvFilm.Columns["Language"].HeaderText = "Ngôn Ngữ";
            dgvFilm.Columns["Director"].HeaderText = "Đạo Diễn";
            dgvFilm.Columns["ProductionDate"].HeaderText = "Ngày Phát Hành";
            dgvFilm.Columns["Price"].HeaderText = "Giá Vé";
            dgvFilm.Columns["FilmImg"].HeaderText = "Ảnh";
            dgvFilm.Columns["Status"].HeaderText = "Trạng Thái";
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
            comboBox1.SelectedIndex = -1;
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

            lbFilmIDSearch.Enabled = true;
            cmbFilmID.Enabled = true;
            btnSearch.Enabled = true;
            btnUpdateDB.Enabled = false;
            btnAddDB.Enabled = false;
            btnAnh.Enabled = false;
            pbFilm.Image = null;

            comboBox1.SelectedIndex = -1;

        }
        public frmFilm()
        {

            InitializeComponent();
        }

        private void frmFilm_Load(object sender, EventArgs e)
        {
            txtFilmID.Enabled = false;
            lbFilmIDSearch.Enabled = true;
            cmbFilmID.Enabled = true;
            btnSearch.Enabled = true;
            btnUpdateDB.Enabled = false;
            btnAddDB.Enabled = false;
            btnAnh.Enabled = false;
            LoadData();
            dgvFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            comboBox1.Items.Add("Đang chiếu");
            comboBox1.Items.Add("Ngừng chiếu");
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
            // Hiển thị ảnh đại diện nếu có ở bin/debug

            string imageFileName = dgvFilm.Rows[i].Cells["FilmImg"].Value.ToString();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\');

            string imageFilePath = currentDirectory + imageFileName;
            
            if (!string.IsNullOrEmpty(imageFilePath))
            {

                if (File.Exists(imageFilePath))
                {
                    pbFilm.Image = Image.FromFile(imageFilePath);
                    
                }
                else
                {
                    pbFilm.Image = null; 
                }
            }
            string status = dgvFilm.Rows[i].Cells["Status"].Value?.ToString();

            if (status == "Đang chiếu" && comboBox1.SelectedIndex != 0)
                comboBox1.SelectedIndex = 0;
            else if (status == "Ngừng chiếu" && comboBox1.SelectedIndex != 1)
                comboBox1.SelectedIndex = 1;
        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Cancel();
            txtFilmID.Enabled = true;
            lbFilmIDSearch.Enabled = false;
            cmbFilmID.Enabled = false;
            btnSearch.Enabled = false;
            btnUpdateDB.Enabled = false;
            btnAddDB.Enabled = true;
            btnAnh.Enabled = true;
            pbFilm.Image = null;
            comboBox1.SelectedIndex = -1;


        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            txtFilmID.Enabled = false;
            lbFilmIDSearch.Enabled = true;
            cmbFilmID.Enabled = true;
            btnSearch.Enabled = true;
            btnUpdateDB.Enabled = true;
            btnAddDB.Enabled = false;
            btnAnh.Enabled = true;
            pbFilm.Image = null;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
             
            Cancel();
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            if(txtFilmID.Text == "" || txtName.Text == "" || txtLanguage.Text == "" || txtDirector.Text == "" || txtPrice.Text == "" || comboBox1.SelectedIndex == -1)
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
                    string imageFilePath = !string.IsNullOrEmpty(imageName) ? "/Resources/" + imageName : "";
                    process.ChangeDatabase("Insert into tblFilm (FilmID, Name, Language, Director, ProductionDate, Price,FilmImg,Status) values ('" + txtFilmID.Text + "', N'" + txtName.Text + "', N'" + txtLanguage.Text + "', N'" + txtDirector.Text + "','" + dtpDate.Value.ToString("yyyy-MM-dd") + "', '" + txtPrice.Text + "', '"+ imageFilePath + "',N'"+comboBox1.Text+"')");
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
                    string imageFileName = dt.Rows[0]["FilmImg"].ToString();
                    string currentDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\');

                    string imageFilePath = currentDirectory + imageFileName;

                    if (!string.IsNullOrEmpty(imageFilePath))
                    {

                        if (File.Exists(imageFilePath))
                        {
                            pbFilm.Image = Image.FromFile(imageFilePath);

                        }
                        else
                        {
                            pbFilm.Image = null;
                        }
                    }
                    if (dt.Rows[0]["Status"].ToString() == "Đang chiếu") comboBox1.SelectedIndex = 0;
                    else comboBox1.SelectedIndex = 1;
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
                   if(MessageBox.Show("Bạn có muốn thay đổi thông tin phim "+txtName.Text+" không","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                   {
                        string imageFilePath = !string.IsNullOrEmpty(imageName) ? "/Resources/" + imageName : "";
                        process.ChangeDatabase("Update tblFilm set Name = N'" + txtName.Text + "', Language = N'" + txtLanguage.Text + "', Director = N'" + txtDirector.Text + "', ProductionDate = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "', Price = '" + txtPrice.Text + "', FilmImg = '" + imageFilePath + "' , Status = N'" +comboBox1.Text+"' Where FilmID = '"+txtFilmID.Text+"'");
                        LoadData();
                   }    
                }
            }
        }



        private void dgvFilm_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvFilm.CurrentRow.Index;
            txtFilmID.Text = dgvFilm.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvFilm.Rows[i].Cells["Name"].Value.ToString();
            txtLanguage.Text = dgvFilm.Rows[i].Cells["Language"].Value.ToString();
            txtDirector.Text = dgvFilm.Rows[i].Cells["Director"].Value.ToString();
            dtpDate.Text = dgvFilm.Rows[i].Cells["ProductionDate"].Value.ToString();
            comboBox1.SelectedIndex = 0;
            txtPrice.Text = dgvFilm.Rows[i].Cells["Price"].Value.ToString();
            string imageFileName = dgvFilm.Rows[i].Cells["FilmImg"].Value.ToString();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\');

            string imageFilePath = currentDirectory + imageFileName;

            if (!string.IsNullOrEmpty(imageFilePath))
            {

                if (File.Exists(imageFilePath))
                {
                    pbFilm.Image = Image.FromFile(imageFilePath);

                }
                else
                {
                    pbFilm.Image = null;
                }
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            string[] image;
            OpenFileDialog imageFile = new OpenFileDialog();
            imageFile.Filter = "Bimap Images|*.bmp|JPEG images|*.jpg|All Files|*.*";
            imageFile.FilterIndex = 3;

            imageFile.InitialDirectory = Application.StartupPath ;
            if (imageFile.ShowDialog() == DialogResult.OK)
            {
                pbFilm.Image = Image.FromFile(imageFile.FileName);
                image = imageFile.FileName.ToString().Split('\\');
                imageName = image[image.Length - 1]; //imageName lưu tên file ảnh               
            }
        }
    }
}
