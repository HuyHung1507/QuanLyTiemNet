using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTram_H
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public class Luugiodangnhap
        {
             public static string Thoigiandangnhap;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Luugiodangnhap.Thoigiandangnhap = DateTime.Now.ToString("hh:mm:ss");
            FrmMayTram f = new FrmMayTram();
            this.Hide();
            f.ShowDialog();
            this.Show();
         
        }

            
    }
}
