using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quobject.SocketIoClientDotNet.Client;
using Newtonsoft.Json;



namespace Osolo_dev
{
    public delegate void UpdateTextBoxMethod(string text);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startSocketIO();
        }

        private void startSocketIO()
        {
            //set the ip, gotta make it changeable.
            var socketip = IO.Socket("http://localhost:80");

           

        }
       
    }
}
