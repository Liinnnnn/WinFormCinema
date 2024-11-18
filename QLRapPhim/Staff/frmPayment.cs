using QLRapPhim.Classes;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VietQRHelper;
using QRCodeHelper = VietQRHelper.QRCodeHelper;

namespace QLRapPhim.Staff
{
    public partial class frmPayment : Form
    {
        private string money;
        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(string money)
        {
            this.money = money;
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            string paymentAmount = money; // Số tiền thanh toán
            
            var qrPay = QRPay.InitVietQR(
                  bankBin: BankApp.BanksObject[BankKey.VIETCOMBANK].bin,
                  bankNumber: "0721000584901", // Số tài khoản
                  amount: paymentAmount, // Số tiền
                  purpose: "Thanh toán tiền vé"  // Nội dung chuyển tiền
                );
            var content = qrPay.Build();

            var imageQR = QRCodeHelper.TaoVietQRCodeImage(content);
            pbQR.Image = imageQR;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
