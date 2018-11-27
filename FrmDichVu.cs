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
    public partial class FrmDichVu : Form
    {
        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            txtSoLuong.Focus();
            if (txtTenDV.Text == "" || txtSoLuong.Text == "")
                {
                    MessageBox.Show("Please Order");
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("The items you call include: \n +" + txtTenDV.Text + "\n +" + txtSoLuong.Text + "\nAre you sure you want to order ?",
                    "Notification !!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        MessageBox.Show("You finished ordering. \nThank you ");
                        //Thêm cái báo cho máy chủ biết
                    }
                    else
                    {

                    txtTenDV.Text = "";
                    txtSoLuong.Text ="";
                        
                    }
                }
            

        }  
    }
}
