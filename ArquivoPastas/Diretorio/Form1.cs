using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            string path = "G:\\AulasC#\\";

            bool res = Directory.Exists(path + "logan");
            //lista.Items.Add(res);

            //if (!res)
            //{
            //    Directory.CreateDirectory(path + "logan");
            //}

            //if (res)
            //{
            //    Directory.Delete(path + "logan");
            //}

            string root = Directory.GetDirectoryRoot(path);
            lista.Items.Add(root);
        }
    }
}
