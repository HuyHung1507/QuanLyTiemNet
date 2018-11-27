using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMayTram
{
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void kiemtranhapMK()
        {
            if (txtMatKhauCu.Text != "")
            {
                if (txtMatKhauMoi.Text != "")
                {
                    if (txtNhapLaiMKM.Text != "")
                    {


                        if (txtMatKhauMoi.Text == txtNhapLaiMKM.Text)
                        {
                            MessageBox.Show("Change password successfully! ");
                        }
                        else
                        {
                            MessageBox.Show("Those password did'nt match. \nTry again. ");
                        }
                    }
                    else MessageBox.Show("Confirm new password is empty");
                }
                else MessageBox.Show("The new password is empty");
            }
            else MessageBox.Show("The old password is empty");
            
            
        }

        private void btxXacNhan_Click(object sender, EventArgs e)
        {
            kiemtranhapMK();
        }
    }
}
