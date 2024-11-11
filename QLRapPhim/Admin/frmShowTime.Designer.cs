namespace QLRapPhim
{
    partial class frmShowTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowTime));
            this.dgvShowTime = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lbShowTimeID = new System.Windows.Forms.Label();
            this.lbShowTime = new System.Windows.Forms.Label();
            this.lbFilmID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShowTimeID = new System.Windows.Forms.TextBox();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.txtCinema = new System.Windows.Forms.TextBox();
            this.dtpShowTime = new System.Windows.Forms.DateTimePicker();
            this.cmbFilmID = new System.Windows.Forms.ComboBox();
            this.cmbCinemaID = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNote = new System.Windows.Forms.Label();
            this.btnAddDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteDB = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowTime
            // 
            this.dgvShowTime.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvShowTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowTime.Location = new System.Drawing.Point(0, 0);
            this.dgvShowTime.Name = "dgvShowTime";
            this.dgvShowTime.RowHeadersWidth = 51;
            this.dgvShowTime.RowTemplate.Height = 24;
            this.dgvShowTime.Size = new System.Drawing.Size(884, 133);
            this.dgvShowTime.TabIndex = 0;
            this.dgvShowTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowTime_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 442);
            this.panel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 22;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnCancel.Location = new System.Drawing.Point(0, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 22;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(0, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 40);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnChange
            // 
            this.btnChange.BorderRadius = 22;
            this.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnChange.Location = new System.Drawing.Point(0, 175);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(175, 40);
            this.btnChange.TabIndex = 21;
            this.btnChange.Text = "Sửa";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 22;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(2, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 40);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(581, 359);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 30);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lbShowTimeID
            // 
            this.lbShowTimeID.AutoSize = true;
            this.lbShowTimeID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTimeID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbShowTimeID.Location = new System.Drawing.Point(220, 201);
            this.lbShowTimeID.Name = "lbShowTimeID";
            this.lbShowTimeID.Size = new System.Drawing.Size(80, 24);
            this.lbShowTimeID.TabIndex = 7;
            this.lbShowTimeID.Text = "Mã Chiếu";
            // 
            // lbShowTime
            // 
            this.lbShowTime.AutoSize = true;
            this.lbShowTime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbShowTime.Location = new System.Drawing.Point(614, 201);
            this.lbShowTime.Name = "lbShowTime";
            this.lbShowTime.Size = new System.Drawing.Size(126, 24);
            this.lbShowTime.TabIndex = 8;
            this.lbShowTime.Text = "Thời Gian Chiếu";
            // 
            // lbFilmID
            // 
            this.lbFilmID.AutoSize = true;
            this.lbFilmID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFilmID.Location = new System.Drawing.Point(220, 252);
            this.lbFilmID.Name = "lbFilmID";
            this.lbFilmID.Size = new System.Drawing.Size(77, 24);
            this.lbFilmID.TabIndex = 9;
            this.lbFilmID.Text = "Mã Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(614, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(220, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Rạp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(614, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên Rạp";
            // 
            // txtShowTimeID
            // 
            this.txtShowTimeID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTimeID.Location = new System.Drawing.Point(334, 198);
            this.txtShowTimeID.Name = "txtShowTimeID";
            this.txtShowTimeID.Size = new System.Drawing.Size(220, 30);
            this.txtShowTimeID.TabIndex = 13;
            // 
            // txtFilm
            // 
            this.txtFilm.Enabled = false;
            this.txtFilm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilm.Location = new System.Drawing.Point(783, 250);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(220, 30);
            this.txtFilm.TabIndex = 14;
            // 
            // txtCinema
            // 
            this.txtCinema.Enabled = false;
            this.txtCinema.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCinema.Location = new System.Drawing.Point(783, 299);
            this.txtCinema.Name = "txtCinema";
            this.txtCinema.Size = new System.Drawing.Size(220, 30);
            this.txtCinema.TabIndex = 15;
            // 
            // dtpShowTime
            // 
            this.dtpShowTime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShowTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShowTime.Location = new System.Drawing.Point(783, 201);
            this.dtpShowTime.Name = "dtpShowTime";
            this.dtpShowTime.Size = new System.Drawing.Size(220, 30);
            this.dtpShowTime.TabIndex = 16;
            // 
            // cmbFilmID
            // 
            this.cmbFilmID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilmID.FormattingEnabled = true;
            this.cmbFilmID.Location = new System.Drawing.Point(334, 248);
            this.cmbFilmID.Name = "cmbFilmID";
            this.cmbFilmID.Size = new System.Drawing.Size(220, 32);
            this.cmbFilmID.TabIndex = 17;
            this.cmbFilmID.SelectedIndexChanged += new System.EventHandler(this.cmbFilmID_SelectedIndexChanged);
            // 
            // cmbCinemaID
            // 
            this.cmbCinemaID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCinemaID.FormattingEnabled = true;
            this.cmbCinemaID.Location = new System.Drawing.Point(334, 300);
            this.cmbCinemaID.Name = "cmbCinemaID";
            this.cmbCinemaID.Size = new System.Drawing.Size(220, 32);
            this.cmbCinemaID.TabIndex = 18;
            this.cmbCinemaID.SelectedIndexChanged += new System.EventHandler(this.cmbCinemaID_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvShowTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 133);
            this.panel2.TabIndex = 19;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNote.Location = new System.Drawing.Point(383, 373);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(176, 16);
            this.lbNote.TabIndex = 24;
            this.lbNote.Text = "Nhập các trường để tìm kiếm";
            // 
            // btnAddDB
            // 
            this.btnAddDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAddDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDB.ForeColor = System.Drawing.Color.White;
            this.btnAddDB.Location = new System.Drawing.Point(830, 357);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(122, 32);
            this.btnAddDB.TabIndex = 79;
            this.btnAddDB.Text = "Thêm";
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnUpdateDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateDB.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDB.Location = new System.Drawing.Point(830, 357);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(122, 32);
            this.btnUpdateDB.TabIndex = 80;
            this.btnUpdateDB.Text = "Sửa";
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteDB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnDeleteDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteDB.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDB.Location = new System.Drawing.Point(830, 357);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(122, 32);
            this.btnDeleteDB.TabIndex = 81;
            this.btnDeleteDB.Text = "Xóa";
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // frmShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1064, 442);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbCinemaID);
            this.Controls.Add(this.cmbFilmID);
            this.Controls.Add(this.dtpShowTime);
            this.Controls.Add(this.txtCinema);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.txtShowTimeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFilmID);
            this.Controls.Add(this.lbShowTime);
            this.Controls.Add(this.lbShowTimeID);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmShowTime";
            this.Text = "frmShowTime";
            this.Load += new System.EventHandler(this.frmShowTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbShowTimeID;
        private System.Windows.Forms.Label lbShowTime;
        private System.Windows.Forms.Label lbFilmID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShowTimeID;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.TextBox txtCinema;
        private System.Windows.Forms.DateTimePicker dtpShowTime;
        private System.Windows.Forms.ComboBox cmbFilmID;
        private System.Windows.Forms.ComboBox cmbCinemaID;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnChange;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lbNote;
        private Guna.UI2.WinForms.Guna2Button btnAddDB;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDB;
        private Guna.UI2.WinForms.Guna2Button btnDeleteDB;
    }
}