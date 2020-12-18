using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urutkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string reverse(string reverse)
        {
            char[] balik = reverse.ToArray();
            Array.Reverse(balik);
            return new string(balik);
        }
        private void buttonreverse_Click(object sender, EventArgs e)
        {
            string a = textBoxinput.Text;
            labeloutput.Text = reverse(a);
            if (textBoxinput.Text == "")
            {
                MessageBox.Show("Eror, Silakan input textbox terlebih dahulu");
            }
        }
        static string urutkan(string urutkan)
        {
            char[] urut = urutkan.ToArray();
            Array.Sort(urut);
            return new string(urut);
        }
        private void buttonurutkan_Click(object sender, EventArgs e)
        {
            string a = textBoxinput.Text;
            labeloutput.Text = urutkan(a);
            if (textBoxinput.Text == "")
            {
                MessageBox.Show("Eror, Silakan input textbox terlebih dahulu");
            }
        }
    }
}
