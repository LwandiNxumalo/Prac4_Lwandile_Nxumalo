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
        double radius, circle_area, circle_circumf, sphere_volume;
        double PIE = Math.PI;
        public frmCalculator()
        {
            InitializeComponent();
            // Evertime the page loads, The Radius input will be the on Focus mode
            /* In general terms, it will be the one flashing showing that it 
               is the part you should enter the value at*/
            txtRadiusInput.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Using Try / Catch to handle any unexpected errors during ruuntime
            try
            {
                // Getting and handling the user radius input
                if (!(double.TryParse(txtRadiusInput.Text, out radius)) || radius <= 0)
                {
                    /* If the user types in the word, character, or anything rather than a number
                     * the Error message box will pop-up, prompting the user to re-enter the radius*/
                    MessageBox.Show("Please enter a valid number for the radius.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // After checking for the radius if it is valid
                // Calculate the Area, Circumference, and a Volume
                
                //Sphere and Circle Formulars
                /* Wrapping the formulars with Math.Round() method to round-off
                   the values to 2 decimal places*/
                circle_area = Math.Round(PIE * Math.Pow(radius, 2), 2); // *OR* circle_area = Math.PI * Math.Pow(radius, 2)

                circle_circumf = Math.Round((2 * PIE * radius), 2); // *OR* circle_circumf =  2 * PIE * radius), 2
               
                sphere_volume = (4.00/3.00) * PIE * Math.Pow(radius, 3); 

                lblAreaOutput.Text = circle_area.ToString(); // *OR* lblAreaOutput.Text = Math.Round(circle_area, 2).ToString()

                lblCircumfOutput.Text = circle_circumf.ToString(); // *OR* lblCircumfOutput.Text = Math.Round(circle_circumf, 2).ToString()

                lblVolumeOutput.Text = Math.Round(sphere_volume, 2).ToString();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRadiusInput.Clear(); // This clears the Textbox Radius
            // This will clear all the output lables for circle, and the sphere volume
            lblAreaOutput.Text = ""; 
            lblVolumeOutput.Text = "";
            lblCircumfOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                "Do you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
