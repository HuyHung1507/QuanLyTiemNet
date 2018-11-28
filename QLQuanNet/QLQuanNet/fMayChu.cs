using QLQuanNet.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanNet
{
    public partial class fMayChu : Form
    {
        public fMayChu()
        {
            InitializeComponent();
            May();
        }

        void May()
        {
            string query = "SELECT * FROM dbo.May";
            dataGridView3.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void butmay1_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void butmay2_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void butmay3_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void butmay4_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void butmay5_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void butmay6_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void butmay7_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void butmay8_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void butmay9_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void butmay10_Click(object sender, EventArgs e)
        {
            FrmThaoTac f = new FrmThaoTac();
            f.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
