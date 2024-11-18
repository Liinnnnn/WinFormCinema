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
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChange = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbShowTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShowTimeID = new System.Windows.Forms.TextBox();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.txtCinema = new System.Windows.Forms.TextBox();
            this.dtpShowTime = new System.Windows.Forms.DateTimePicker();
            this.cmbFilmID = new System.Windows.Forms.ComboBox();
            this.cmbCinemaID = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeleteDB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdateDB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddDB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbShowTimeID = new System.Windows.Forms.Label();
            this.lbFilmID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dgvShowTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowTime.Name = "dgvShowTime";
            this.dgvShowTime.RowHeadersWidth = 51;
            this.dgvShowTime.RowTemplate.Height = 24;
            this.dgvShowTime.Size = new System.Drawing.Size(884, 133);
            this.dgvShowTime.TabIndex = 0;
            this.dgvShowTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowTime_CellContentClick);
            this.dgvShowTime.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShowTime_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 442);
            this.panel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.Violet;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.FillColor2 = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Violet;
            this.btnCancel.Image = global::QLRapPhim.Properties.Resources.icons8_close_64;
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(32, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 40);
            this.btnCancel.TabIndex = 97;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseTransparentBackground = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Violet;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.FillColor2 = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Violet;
            this.btnAdd.Image = global::QLRapPhim.Properties.Resources.icons8_add_64;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(32, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 40);
            this.btnAdd.TabIndex = 94;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Violet;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.FillColor2 = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Violet;
            this.btnDelete.Image = global::QLRapPhim.Properties.Resources.icons8_delete_64;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(32, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 40);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.BorderColor = System.Drawing.Color.Violet;
            this.btnChange.BorderRadius = 10;
            this.btnChange.BorderThickness = 1;
            this.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChange.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChange.FillColor = System.Drawing.Color.White;
            this.btnChange.FillColor2 = System.Drawing.Color.White;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChange.ForeColor = System.Drawing.Color.Violet;
            this.btnChange.Image = global::QLRapPhim.Properties.Resources.icons8_fix_64;
            this.btnChange.ImageSize = new System.Drawing.Size(30, 30);
            this.btnChange.Location = new System.Drawing.Point(31, 214);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(119, 40);
            this.btnChange.TabIndex = 95;
            this.btnChange.Text = "SỬA";
            this.btnChange.UseTransparentBackground = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // lbShowTime
            // 
            this.lbShowTime.AutoSize = true;
            this.lbShowTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTime.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbShowTime.Location = new System.Drawing.Point(633, 178);
            this.lbShowTime.Name = "lbShowTime";
            this.lbShowTime.Size = new System.Drawing.Size(110, 28);
            this.lbShowTime.TabIndex = 8;
            this.lbShowTime.Text = "Ngày chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(633, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(633, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên Rạp";
            // 
            // txtShowTimeID
            // 
            this.txtShowTimeID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTimeID.Location = new System.Drawing.Point(356, 172);
            this.txtShowTimeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShowTimeID.Name = "txtShowTimeID";
            this.txtShowTimeID.Size = new System.Drawing.Size(220, 30);
            this.txtShowTimeID.TabIndex = 13;
            // 
            // txtFilm
            // 
            this.txtFilm.Enabled = false;
            this.txtFilm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilm.Location = new System.Drawing.Point(783, 224);
            this.txtFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(220, 30);
            this.txtFilm.TabIndex = 14;
            // 
            // txtCinema
            // 
            this.txtCinema.Enabled = false;
            this.txtCinema.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCinema.Location = new System.Drawing.Point(783, 267);
            this.txtCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCinema.Name = "txtCinema";
            this.txtCinema.Size = new System.Drawing.Size(220, 30);
            this.txtCinema.TabIndex = 15;
            // 
            // dtpShowTime
            // 
            this.dtpShowTime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShowTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShowTime.Location = new System.Drawing.Point(783, 175);
            this.dtpShowTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpShowTime.Name = "dtpShowTime";
            this.dtpShowTime.Size = new System.Drawing.Size(220, 30);
            this.dtpShowTime.TabIndex = 16;
            // 
            // cmbFilmID
            // 
            this.cmbFilmID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilmID.FormattingEnabled = true;
            this.cmbFilmID.Location = new System.Drawing.Point(356, 224);
            this.cmbFilmID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilmID.Name = "cmbFilmID";
            this.cmbFilmID.Size = new System.Drawing.Size(220, 32);
            this.cmbFilmID.TabIndex = 17;
            this.cmbFilmID.SelectedIndexChanged += new System.EventHandler(this.cmbFilmID_SelectedIndexChanged);
            // 
            // cmbCinemaID
            // 
            this.cmbCinemaID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCinemaID.FormattingEnabled = true;
            this.cmbCinemaID.Location = new System.Drawing.Point(356, 267);
            this.cmbCinemaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 133);
            this.panel2.TabIndex = 19;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbNote.Location = new System.Drawing.Point(362, 382);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(179, 17);
            this.lbNote.TabIndex = 24;
            this.lbNote.Text = "Nhập các trường để tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(210, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 82;
            this.label1.Text = "Phòng chiếu";
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(356, 313);
            this.cmbRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(220, 32);
            this.cmbRoomID.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(633, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 84;
            this.label5.Text = "Giờ chiếu";
            // 
            // cmbHour
            // 
            this.cmbHour.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(783, 316);
            this.cmbHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(220, 32);
            this.cmbHour.TabIndex = 85;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Violet;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.FillColor2 = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Violet;
            this.btnSearch.Image = global::QLRapPhim.Properties.Resources.icons8_search_64;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(597, 373);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 40);
            this.btnSearch.TabIndex = 92;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteDB.BorderColor = System.Drawing.Color.Violet;
            this.btnDeleteDB.BorderRadius = 10;
            this.btnDeleteDB.BorderThickness = 1;
            this.btnDeleteDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteDB.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteDB.FillColor = System.Drawing.Color.White;
            this.btnDeleteDB.FillColor2 = System.Drawing.Color.White;
            this.btnDeleteDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteDB.ForeColor = System.Drawing.Color.Violet;
            this.btnDeleteDB.Image = global::QLRapPhim.Properties.Resources.icons8_delete_64;
            this.btnDeleteDB.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteDB.Location = new System.Drawing.Point(828, 373);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(135, 40);
            this.btnDeleteDB.TabIndex = 96;
            this.btnDeleteDB.Text = "XÓA";
            this.btnDeleteDB.UseTransparentBackground = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateDB.BorderColor = System.Drawing.Color.Violet;
            this.btnUpdateDB.BorderRadius = 10;
            this.btnUpdateDB.BorderThickness = 1;
            this.btnUpdateDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDB.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDB.FillColor = System.Drawing.Color.White;
            this.btnUpdateDB.FillColor2 = System.Drawing.Color.White;
            this.btnUpdateDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateDB.ForeColor = System.Drawing.Color.Violet;
            this.btnUpdateDB.Image = global::QLRapPhim.Properties.Resources.icons8_fix_64;
            this.btnUpdateDB.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateDB.Location = new System.Drawing.Point(829, 373);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(132, 40);
            this.btnUpdateDB.TabIndex = 97;
            this.btnUpdateDB.Text = "SỬA";
            this.btnUpdateDB.UseTransparentBackground = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnAddDB
            // 
            this.btnAddDB.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDB.BorderColor = System.Drawing.Color.Violet;
            this.btnAddDB.BorderRadius = 10;
            this.btnAddDB.BorderThickness = 1;
            this.btnAddDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDB.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDB.FillColor = System.Drawing.Color.White;
            this.btnAddDB.FillColor2 = System.Drawing.Color.White;
            this.btnAddDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDB.ForeColor = System.Drawing.Color.Violet;
            this.btnAddDB.Image = global::QLRapPhim.Properties.Resources.icons8_add_64;
            this.btnAddDB.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddDB.Location = new System.Drawing.Point(828, 373);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(133, 40);
            this.btnAddDB.TabIndex = 98;
            this.btnAddDB.Text = "THÊM";
            this.btnAddDB.UseTransparentBackground = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // lbShowTimeID
            // 
            this.lbShowTimeID.AutoSize = true;
            this.lbShowTimeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTimeID.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbShowTimeID.Location = new System.Drawing.Point(210, 175);
            this.lbShowTimeID.Name = "lbShowTimeID";
            this.lbShowTimeID.Size = new System.Drawing.Size(94, 28);
            this.lbShowTimeID.TabIndex = 7;
            this.lbShowTimeID.Text = "Mã Chiếu";
            // 
            // lbFilmID
            // 
            this.lbFilmID.AutoSize = true;
            this.lbFilmID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmID.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbFilmID.Location = new System.Drawing.Point(210, 226);
            this.lbFilmID.Name = "lbFilmID";
            this.lbFilmID.Size = new System.Drawing.Size(89, 28);
            this.lbFilmID.TabIndex = 9;
            this.lbFilmID.Text = "Mã Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(210, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Rạp";
            // 
            // frmShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 442);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRoomID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.panel2);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lbShowTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShowTimeID;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.TextBox txtCinema;
        private System.Windows.Forms.DateTimePicker dtpShowTime;
        private System.Windows.Forms.ComboBox cmbFilmID;
        private System.Windows.Forms.ComboBox cmbCinemaID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHour;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnChange;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteDB;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateDB;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddDB;
        private System.Windows.Forms.Label lbShowTimeID;
        private System.Windows.Forms.Label lbFilmID;
        private System.Windows.Forms.Label label3;
    }
}