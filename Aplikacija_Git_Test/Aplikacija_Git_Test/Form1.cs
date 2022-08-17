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
        public Form1(int a, int b)
        {
            InitializeComponent();
        }
        
        int izracunaj()
        {
            return a+b;
        }
    }
}
