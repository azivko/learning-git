using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_Git_Test
{
    public partial class Form1 : Form
    {
        int a, b = 0;
        int c = 5;
        public Form1(int prvi, int drugi)
        {
            a = prvi;
            b = drugi;
            InitializeComponent();
        }

        int izracunaj()
        {
            return a + b + c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
