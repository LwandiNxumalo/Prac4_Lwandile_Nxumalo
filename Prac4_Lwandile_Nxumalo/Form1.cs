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
        double radius, circle_area = 0.0, circle_circumf = 0.0, sphere_volume = 0.0; 
        public frmCalculator()
        {
            InitializeComponent();
            txtRadiusInput.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Using Try / Catch to handle any unexpected errors during ruuntime
            try
            {
                //Getting and handling the user radius input



                //Sphere and Circle Formulars
                circle_area = Math.PI * radius;
                circle_circumf = 2 * Math.PI * radius;
                sphere_volume = (4 / 3) * Math.PI * Math.Pow(radius, 3);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            
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
