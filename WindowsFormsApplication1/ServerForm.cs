using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;

namespace WindowsFormsApplication1
{
    public partial class ServerForm : Form, IService1
    {
        public ServerForm()
        {
            InitializeComponent();

        }
        //server gets triggered to send message
        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client server = new
        ServiceReference1.Service1Client();

            string messageType = txt_messageTypeIn.ToString();
            string messageBody = txt_messageBodyIn.ToString();

            IService1 sendMessage = new Message

        }
    }
}
