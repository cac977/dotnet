using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public void ShowPage(UserControl uc)
        {
            if (panel1 == null) return;

            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ShowPage(new ucTourList(this));
        }
    }
}
