using QLRapPhim.Classes;
using System;
using System.Collections;
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
    public partial class frmCRevenue : Form
    {

        private DataProcess process = new DataProcess();
        private string query =@"select MONTH(PaymentDate) as Month, SUM(Total) as Revenue
                            from tblInvoice i join tblStaff s on i.StaffID = s.StaffID 
                            join tblCinema c on s.CinemaID =  c.CinemaID 
                            group by MONTH(PaymentDate)";
        public frmCRevenue()
        {
            InitializeComponent();
            
            comboBox1.Items.Add("Tất cả");
            comboBox1.SelectedIndex = 0; 

            DataTable dt = process.ReadDatabase(@"select CinemaName from tblCinema");
            for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            comboBox1.Items.Add(dt.Rows[i]["CinemaName"].ToString());
                        }
            DataTable dtr = process.ReadDatabase(query);
           

            dataGridView1.DataSource = dtr;
            chart1.DataSource = dtr;
            chart1.Series["Doanh Thu"].XValueMember = "Month";
            chart1.Series["Doanh Thu"].YValueMembers = "Revenue";
            chart1.Series["Doanh Thu"].Color = Color.FromArgb(255, 0, 118, 212);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) { 
                DataTable dt1 = process.ReadDatabase(query);
                chart1.DataSource = dt1;
                dataGridView1.DataSource = dt1;
                chart1.Invalidate();
                chart1.Update();

            }
            else
            {
                DataTable dt2 = process.ReadDatabase(@"select SUM(Total) as Revenue,MONTH(PaymentDate) as Month from tblInvoice i join tblStaff s on i.StaffID = s.StaffID join tblCinema c on s.CinemaID =  c.CinemaID where CinemaName = N'" + comboBox1.SelectedItem.ToString() + "' group by CinemaName,MONTH(PaymentDate)");
                chart1.DataSource = dt2;
                dataGridView1.DataSource = dt2;
                chart1.Invalidate();
                chart1.Update();
            }

        }
    }
}
