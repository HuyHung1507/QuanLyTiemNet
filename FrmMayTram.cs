using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace QLMayTram
{
    public partial class FrmMayTram : Form
    {
        public FrmMayTram()
        {
            InitializeComponent();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - this.Width , 0);


            // Time login when open aplication

            txtGioDangNhap.Text = frmLogin.Luugiodangnhap.Thoigiandangnhap;
            

            /* //Get screen resolution
             Rectangle res = Screen.PrimaryScreen.Bounds;

             //376, 777

             // Calculate location (etc. 1366 Width - form size...)
             this.Location = new Point(1920-661,0);
             */
        }
        void tinhtien()
        {
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau f = new FrmDoiMatKhau();
            f.ShowDialog();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            FrmDichVu f = new FrmDichVu();
            f.ShowDialog();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            FrmGiaoTiep f = new FrmGiaoTiep();
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
