using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCinfoClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ipAddress = tbIpAddress.Text;
            int port;

            if (!int.TryParse(tbPort.Text, out port) || port < 1 || port > 65535)
            {
                MessageBox.Show("Недопустимый номер порта. Введите значение от 1 до 65535.");
                return;
            }

            using (TcpClient client = new TcpClient())
            {
                try
                {
                    client.Connect(ipAddress, port);
                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader(stream);
                    StreamWriter writer = new StreamWriter(stream);

                    writer.WriteLine("get_info");
                    writer.Flush();

                    string response = reader.ReadLine();
                    tbResponse.Text = response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к серверу: " + ex.Message);
                }
            }
        }

        private void btnGetUserInfo_Click(object sender, EventArgs e)
        {
            string ipAddress = tbIpAddress.Text;
            int port;

            if (!int.TryParse(tbPort.Text, out port) || port < 1 || port > 65535)
            {
                MessageBox.Show("Недопустимый номер порта. Введите значение от 1 до 65535.");
                return;
            }

            using (TcpClient client = new TcpClient())
            {
                try
                {
                    client.Connect(ipAddress, port);
                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader(stream);
                    StreamWriter writer = new StreamWriter(stream);

                    writer.WriteLine("user_info");
                    writer.Flush();

                    string response = reader.ReadLine();
                    tbResponse.Text = response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к серверу: " + ex.Message);
                }
            }
        }

        private void btnGetDiskInfo_Click(object sender, EventArgs e)
        {
            string ipAddress = tbIpAddress.Text;
            int port;

            if (!int.TryParse(tbPort.Text, out port) || port < 1 || port > 65535)
            {
                MessageBox.Show("Недопустимый номер порта. Введите значение от 1 до 65535.");
                return;
            }

            using (TcpClient client = new TcpClient())
            {
                try
                {
                    client.Connect(ipAddress, port);
                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader(stream);
                    StreamWriter writer = new StreamWriter(stream);

                    writer.WriteLine("disk_info");
                    writer.Flush();

                    string response = reader.ReadLine();
                    tbResponse.Text = response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к серверу: " + ex.Message);
                }
            }
        }
    }
}

