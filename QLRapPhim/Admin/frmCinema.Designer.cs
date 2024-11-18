namespace QLRapPhim
{
    partial class frmCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCinema));
            this.dgvCinema = new System.Windows.Forms.DataGridView();
            this.txtCinemaID = new System.Windows.Forms.TextBox();
            this.txtCinemaName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChange = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbCinemaID = new System.Windows.Forms.Label();
            this.lbCinemaName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.btnDeleteDB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbCinemaID = new System.Windows.Forms.ComboBox();
            this.btnUpdateDB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddDB = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinema)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCinema
            // 
            this.dgvCinema.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinema.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCinema.Location = new System.Drawing.Point(0, 0);
            this.dgvCinema.Name = "dgvCinema";
            this.dgvCinema.RowHeadersWidth = 51;
            this.dgvCinema.RowTemplate.Height = 24;
            this.dgvCinema.Size = new System.Drawing.Size(531, 350);
            this.dgvCinema.TabIndex = 1;
            this.dgvCinema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCinema_CellContentClick);
            // 
            // txtCinemaID
            // 
            this.txtCinemaID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCinemaID.Location = new System.Drawing.Point(761, 20);
            this.txtCinemaID.Name = "txtCinemaID";
            this.txtCinemaID.Size = new System.Drawing.Size(241, 30);
            this.txtCinemaID.TabIndex = 14;
            // 
            // txtCinemaName
            // 
            this.txtCinemaName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCinemaName.Location = new System.Drawing.Point(761, 86);
            this.txtCinemaName.Name = "txtCinemaName";
            this.txtCinemaName.Size = new System.Drawing.Size(241, 30);
            this.txtCinemaName.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(761, 152);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(241, 30);
            this.txtAddress.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 92);
            this.panel1.TabIndex = 17;
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
            this.btnCancel.Location = new System.Drawing.Point(856, 28);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 40);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseTransparentBackground = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
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
            this.btnChange.Location = new System.Drawing.Point(336, 28);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(120, 40);
            this.btnChange.TabIndex = 87;
            this.btnChange.Text = "SỬA";
            this.btnChange.UseTransparentBackground = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
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
            this.btnDelete.Location = new System.Drawing.Point(620, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 40);
            this.btnDelete.TabIndex = 88;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
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
            this.btnAdd.Location = new System.Drawing.Point(103, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 40);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.White;
            this.pnTop.Controls.Add(this.lbCinemaID);
            this.pnTop.Controls.Add(this.lbCinemaName);
            this.pnTop.Controls.Add(this.lbAddress);
            this.pnTop.Controls.Add(this.btnDeleteDB);
            this.pnTop.Controls.Add(this.btnSearch);
            this.pnTop.Controls.Add(this.cmbCinemaID);
            this.pnTop.Controls.Add(this.dgvCinema);
            this.pnTop.Controls.Add(this.txtCinemaID);
            this.pnTop.Controls.Add(this.txtAddress);
            this.pnTop.Controls.Add(this.txtCinemaName);
            this.pnTop.Controls.Add(this.btnUpdateDB);
            this.pnTop.Controls.Add(this.btnAddDB);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTop.Location = new System.Drawing.Point(0, 92);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1064, 350);
            this.pnTop.TabIndex = 18;
            // 
            // lbCinemaID
            // 
            this.lbCinemaID.AutoSize = true;
            this.lbCinemaID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinemaID.ForeColor = System.Drawing.Color.Violet;
            this.lbCinemaID.Location = new System.Drawing.Point(629, 22);
            this.lbCinemaID.Name = "lbCinemaID";
            this.lbCinemaID.Size = new System.Drawing.Size(79, 28);
            this.lbCinemaID.TabIndex = 91;
            this.lbCinemaID.Text = "Mã Rạp";
            // 
            // lbCinemaName
            // 
            this.lbCinemaName.AutoSize = true;
            this.lbCinemaName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinemaName.ForeColor = System.Drawing.Color.Violet;
            this.lbCinemaName.Location = new System.Drawing.Point(629, 88);
            this.lbCinemaName.Name = "lbCinemaName";
            this.lbCinemaName.Size = new System.Drawing.Size(80, 28);
            this.lbCinemaName.TabIndex = 92;
            this.lbCinemaName.Text = "Tên Rạp";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.Violet;
            this.lbAddress.Location = new System.Drawing.Point(629, 154);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(74, 28);
            this.lbAddress.TabIndex = 93;
            this.lbAddress.Text = "Địa Chỉ";
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
            this.btnDeleteDB.Location = new System.Drawing.Point(876, 269);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(126, 40);
            this.btnDeleteDB.TabIndex = 90;
            this.btnDeleteDB.Text = "XÓA";
            this.btnDeleteDB.UseTransparentBackground = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(618, 209);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 40);
            this.btnSearch.TabIndex = 87;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbCinemaID
            // 
            this.cmbCinemaID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCinemaID.FormattingEnabled = true;
            this.cmbCinemaID.Location = new System.Drawing.Point(821, 217);
            this.cmbCinemaID.Name = "cmbCinemaID";
            this.cmbCinemaID.Size = new System.Drawing.Size(181, 32);
            this.cmbCinemaID.TabIndex = 64;
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
            this.btnUpdateDB.Location = new System.Drawing.Point(876, 269);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(123, 40);
            this.btnUpdateDB.TabIndex = 88;
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
            this.btnAddDB.Location = new System.Drawing.Point(876, 269);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(127, 40);
            this.btnAddDB.TabIndex = 89;
            this.btnAddDB.Text = "THÊM";
            this.btnAddDB.UseTransparentBackground = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAdđB_Click);
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 442);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCinema";
            this.Text = "frmCinemacs";
            this.Load += new System.EventHandler(this.frmCinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinema)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCinema;
        private System.Windows.Forms.TextBox txtCinemaID;
        private System.Windows.Forms.TextBox txtCinemaName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.ComboBox cmbCinemaID;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnChange;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private System.Windows.Forms.Label lbCinemaID;
        private System.Windows.Forms.Label lbCinemaName;
        private System.Windows.Forms.Label lbAddress;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteDB;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateDB;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddDB;
    }
}