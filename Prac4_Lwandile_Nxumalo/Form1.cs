using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac4_Lwandile_Nxumalo
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
            txtRadiusInput.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRadiusInput.Clear();
            lblAreaOutput.Text = "";
            lblVolumeOutput.Text = "";
            lblCircumfOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
