using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinErstes
{
    public partial class Form1 : Form
    {

            
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdHallo_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "Hallo von Hermann";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}