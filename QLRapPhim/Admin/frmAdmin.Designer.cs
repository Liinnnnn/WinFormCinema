namespace QLRapPhim
{
    partial class frmAdmin
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinLịchChiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rạpPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchRạpChiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Controls.Add(this.menuStrip1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(812, 52);
            this.pnTop.TabIndex = 11;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.LightGray;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbTitle.Location = new System.Drawing.Point(626, 7);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(98, 34);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Skope";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phimToolStripMenuItem,
            this.lịchToolStripMenuItem,
            this.rạpPhimToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(812, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phimToolStripMenuItem
            // 
            this.phimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchPhimToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.phimToolStripMenuItem.Name = "phimToolStripMenuItem";
            this.phimToolStripMenuItem.Size = new System.Drawing.Size(60, 48);
            this.phimToolStripMenuItem.Text = "Phim";
            // 
            // danhSáchPhimToolStripMenuItem
            // 
            this.danhSáchPhimToolStripMenuItem.Name = "danhSáchPhimToolStripMenuItem";
            this.danhSáchPhimToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.danhSáchPhimToolStripMenuItem.Text = "Danh Sách Phim";
            this.danhSáchPhimToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhimToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // lịchToolStripMenuItem
            // 
            this.lịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinLịchChiếuToolStripMenuItem});
            this.lịchToolStripMenuItem.Name = "lịchToolStripMenuItem";
            this.lịchToolStripMenuItem.Size = new System.Drawing.Size(106, 48);
            this.lịchToolStripMenuItem.Text = "Lịch Chiếu";
            // 
            // thôngTinLịchChiếuToolStripMenuItem
            // 
            this.thôngTinLịchChiếuToolStripMenuItem.Name = "thôngTinLịchChiếuToolStripMenuItem";
            this.thôngTinLịchChiếuToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.thôngTinLịchChiếuToolStripMenuItem.Text = "Thông Tin Lịch Chiếu";
            this.thôngTinLịchChiếuToolStripMenuItem.Click += new System.EventHandler(this.thôngTinLịchChiếuToolStripMenuItem_Click);
            // 
            // rạpPhimToolStripMenuItem
            // 
            this.rạpPhimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchRạpChiếuToolStripMenuItem,
            this.doanhThuToolStripMenuItem1,
            this.phToolStripMenuItem});
            this.rạpPhimToolStripMenuItem.Name = "rạpPhimToolStripMenuItem";
            this.rạpPhimToolStripMenuItem.Size = new System.Drawing.Size(104, 48);
            this.rạpPhimToolStripMenuItem.Text = "Rạp Chiếu";
            // 
            // danhSáchRạpChiếuToolStripMenuItem
            // 
            this.danhSáchRạpChiếuToolStripMenuItem.Name = "danhSáchRạpChiếuToolStripMenuItem";
            this.danhSáchRạpChiếuToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.danhSáchRạpChiếuToolStripMenuItem.Text = "Danh Sách Rạp Chiếu";
            this.danhSáchRạpChiếuToolStripMenuItem.Click += new System.EventHandler(this.danhSáchRạpChiếuToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem1
            // 
            this.doanhThuToolStripMenuItem1.Name = "doanhThuToolStripMenuItem1";
            this.doanhThuToolStripMenuItem1.Size = new System.Drawing.Size(260, 26);
            this.doanhThuToolStripMenuItem1.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem1.Click += new System.EventHandler(this.doanhThuToolStripMenuItem1_Click);
            // 
            // phToolStripMenuItem
            // 
            this.phToolStripMenuItem.Name = "phToolStripMenuItem";
            this.phToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.phToolStripMenuItem.Text = "Phòng Chiếu";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhânViênToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(109, 48);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Danh Sách Nhân Viên";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(70, 48);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thoátToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(188, 26);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Font = new System.Drawing.Font("Calibri", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnMain.Location = new System.Drawing.Point(0, 52);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(812, 397);
            this.pnMain.TabIndex = 12;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(812, 449);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rạpPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchRạpChiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinLịchChiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ToolStripMenuItem phToolStripMenuItem;
    }
}