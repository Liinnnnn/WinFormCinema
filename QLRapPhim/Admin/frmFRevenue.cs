using QLRapPhim.Classes;
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
    public partial class frmFRevenue : Form
    {

        private DataProcess process = new DataProcess();
        private string query = @"select SUM(FinalPrice) as Revenue,MONTH(PaymentDate) as Month
                                    from tblTicket t inner join tblShowtime s on t.ShowtimeID = s.ShowtimeID
                                    inner join tblInvoice i on t.InvoiceID = i.InvoiceID
                                    inner join tblFilm f on f.FilmID = s.FilmID
                                    inner join tblCinema c on c.CinemaID = s.CinemaID
                                    group by MONTH(PaymentDate)";


        public frmFRevenue()
        {
            InitializeComponent();
            comboBox1.Items.Add("Tất cả");
            comboBox1.SelectedIndex = 0;

            DataTable dt = process.ReadDatabase(@"select Name from tblFilm");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["Name"].ToString());
            }

            DataTable dtr = process.ReadDatabase(query);
 
            dataGridView1.DataSource = dt;
            chart1.DataSource = dtr;
            chart1.Series["Doanh Thu"].XValueMember = "Month";
            chart1.Series["Doanh Thu"].YValueMembers = "Revenue";

        }

        private void frmFRevenue_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DataTable dtr = process.ReadDatabase(query);
                chart1.DataSource = dtr;
                dataGridView1.DataSource = dtr;
                chart1.Invalidate();
                chart1.Update();
            }else
            {
                DataTable dtf = process.ReadDatabase(@"select SUM(FinalPrice) as Revenue,MONTH(PaymentDate) as Month
                                    from tblTicket t inner join tblShowtime s on t.ShowtimeID = s.ShowtimeID
                                    inner join tblInvoice i on t.InvoiceID = i.InvoiceID
                                    inner join tblFilm f on f.FilmID = s.FilmID
                                    inner join tblCinema c on c.CinemaID = s.CinemaID
                                    where f.Name = N'" +comboBox1.SelectedItem.ToString()+ "' group by MONTH(PaymentDate),f.Name");
                chart1.DataSource = dtf;
                dataGridView1.DataSource= dtf;
                chart1.Invalidate();
                chart1.Update();

            }
        }
    }
}
