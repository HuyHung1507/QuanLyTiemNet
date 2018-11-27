using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// gọi thêm namespace
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading;

namespace QLMayTram
{
    public partial class FrmGiaoTiep : Form
    {
        public FrmGiaoTiep()
        {
            InitializeComponent();
            //   Connect();
        }
    }
}
      /* private void btnGui_Click(object sender, EventArgs e)
        {
            send();
        }
        */
        /*ĐK Cần:
         * Socket
         * IP
         */
       /* IPEndPoint IP;
        Socket Client;

        //Kết nối tới server
        void Connect()
        {
            // IP: địa chỉ của server
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.IP);

            try
            {
                Client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("You cannot connect Server !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        // Gửi tin
        void send()
        {
            if(txtGui.Text != string.Empty)
            Client.Send(Serialize(txtGui.Text));
        }


        //Đóng tin
        void Close()
        {
            Client.Close();
        }
       

        //Nhận tin
        void Receive()
        {
            try
            {

                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    Client.Receive(data);

                    string tn = (string)Deserialize(data);

                    themtn(tn);

                }
            }
            catch
            {
                Close();
            }
        }


        //Thêm tn vào khung chat
        void themtn(string s )
        {
            listvtn.Items.Add(new ListViewItem() { Text = s });
        }

        // Phân mảnh để gửi đi
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter Formatter = new BinaryFormatter();

            //Phân mảnh
            Formatter.Serialize(stream, obj);
            

            //ToArray: Chuyển sang mảng
            return stream.ToArray();
        }

        // Gom mảnh để nhận tin gửi tới
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);//thêm data
            BinaryFormatter Formatter = new BinaryFormatter();

            return Formatter.Deserialize(stream);
         
        }

        private void FrmGiaoTiep_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
*/
