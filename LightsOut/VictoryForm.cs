using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class VictoryForm : Form
    {
        public VictoryForm()
        {
            InitializeComponent();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterForm start = new MasterForm();
            start.Show();
            start.FormClosing += delegate { this.Close(); };
            start.Location = this.Location;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
