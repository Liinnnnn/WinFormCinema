namespace QLRapPhim
{
    partial class frmFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilm));
            this.dgvFilm = new System.Windows.Forms.DataGridView();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDirector = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChange = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbFilmID = new System.Windows.Forms.ComboBox();
            this.lbFilmIDSearch = new System.Windows.Forms.Label();
            this.lbFilmID = new System.Windows.Forms.Label();
            this.txtFilmID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdateDB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddDB = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFilm
            // 
            this.dgvFilm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilm.Location = new System.Drawing.Point(0, 0);
            this.dgvFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFilm.Name = "dgvFilm";
            this.dgvFilm.RowHeadersWidth = 51;
            this.dgvFilm.RowTemplate.Height = 24;
            this.dgvFilm.Size = new System.Drawing.Size(1615, 189);
            this.dgvFilm.TabIndex = 0;
            this.dgvFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilm_CellContentClick);
            this.dgvFilm.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFilm_RowHeaderMouseClick);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbName.Location = new System.Drawing.Point(437, 306);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(83, 28);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên Film";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbPrice.Location = new System.Drawing.Point(1210, 361);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(129, 28);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Giá Mặc Định";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbDate.Location = new System.Drawing.Point(1210, 306);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(154, 28);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "Ngày Phát Hành";
            // 
            // lbDirector
            // 
            this.lbDirector.AutoSize = true;
            this.lbDirector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirector.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbDirector.Location = new System.Drawing.Point(1210, 249);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(93, 28);
            this.lbDirector.TabIndex = 5;
            this.lbDirector.Text = "Đạo Diễn";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbLanguage.Location = new System.Drawing.Point(437, 361);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(106, 28);
            this.lbLanguage.TabIndex = 6;
            this.lbLanguage.Text = "Ngôn Ngữ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(646, 305);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(311, 30);
            this.txtName.TabIndex = 7;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage.Location = new System.Drawing.Point(646, 364);
            this.txtLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(311, 30);
            this.txtLanguage.TabIndex = 8;
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(1464, 250);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(311, 30);
            this.txtDirector.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1464, 359);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(312, 30);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(1464, 302);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(311, 30);
            this.dtpDate.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 922);
            this.panel1.TabIndex = 15;
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
            this.btnCancel.Location = new System.Drawing.Point(-1, 529);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(291, 40);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseTransparentBackground = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(-1, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(291, 40);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
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
            this.btnChange.Location = new System.Drawing.Point(-1, 384);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(291, 40);
            this.btnChange.TabIndex = 91;
            this.btnChange.Text = "SỬA";
            this.btnChange.UseTransparentBackground = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFilm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1615, 189);
            this.panel2.TabIndex = 16;
            // 
            // cmbFilmID
            // 
            this.cmbFilmID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilmID.FormattingEnabled = true;
            this.cmbFilmID.Location = new System.Drawing.Point(971, 538);
            this.cmbFilmID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilmID.Name = "cmbFilmID";
            this.cmbFilmID.Size = new System.Drawing.Size(311, 32);
            this.cmbFilmID.TabIndex = 63;
            // 
            // lbFilmIDSearch
            // 
            this.lbFilmIDSearch.AutoSize = true;
            this.lbFilmIDSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmIDSearch.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbFilmIDSearch.Location = new System.Drawing.Point(863, 542);
            this.lbFilmIDSearch.Name = "lbFilmIDSearch";
            this.lbFilmIDSearch.Size = new System.Drawing.Size(89, 28);
            this.lbFilmIDSearch.TabIndex = 61;
            this.lbFilmIDSearch.Text = "Mã Phim";
            // 
            // lbFilmID
            // 
            this.lbFilmID.AutoSize = true;
            this.lbFilmID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmID.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbFilmID.Location = new System.Drawing.Point(437, 249);
            this.lbFilmID.Name = "lbFilmID";
            this.lbFilmID.Size = new System.Drawing.Size(89, 28);
            this.lbFilmID.TabIndex = 64;
            this.lbFilmID.Text = "Mã Phim";
            // 
            // txtFilmID
            // 
            this.txtFilmID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilmID.Location = new System.Drawing.Point(646, 250);
            this.txtFilmID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilmID.Name = "txtFilmID";
            this.txtFilmID.Size = new System.Drawing.Size(311, 30);
            this.txtFilmID.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(437, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 79;
            this.label1.Text = "Trạng Thái";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Đang chiếu",
            "Ngừng chiếu"});
            this.comboBox1.Location = new System.Drawing.Point(646, 422);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 33);
            this.comboBox1.TabIndex = 80;
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
            this.btnSearch.Location = new System.Drawing.Point(1333, 538);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 32);
            this.btnSearch.TabIndex = 88;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnUpdateDB.Location = new System.Drawing.Point(947, 642);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(125, 40);
            this.btnUpdateDB.TabIndex = 93;
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
            this.btnAddDB.Location = new System.Drawing.Point(1209, 642);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(124, 40);
            this.btnAddDB.TabIndex = 94;
            this.btnAddDB.Text = "THÊM";
            this.btnAddDB.UseTransparentBackground = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1906, 922);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilmID);
            this.Controls.Add(this.lbFilmID);
            this.Controls.Add(this.cmbFilmID);
            this.Controls.Add(this.lbFilmIDSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.lbDirector);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.btnAddDB);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFilm";
            this.Text = "frmFilm";
            this.Load += new System.EventHandler(this.frmFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilm;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFilmID;
        private System.Windows.Forms.Label lbFilmIDSearch;
        private System.Windows.Forms.Label lbFilmID;
        private System.Windows.Forms.TextBox txtFilmID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientButton btnChange;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateDB;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddDB;
    }
}