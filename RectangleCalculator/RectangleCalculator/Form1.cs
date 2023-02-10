/*
 * Author: Samuel Greenlee
 * Date  : January 17, 2020
 * Desc  : Calculates the area and perimeter of a rectangle
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int length;
            int width;
            int area;
            int perimeter;

            // get the input
            length = Convert.ToInt16(txtLength.Text); 
            width = Convert.ToInt16(txtWidth.Text);

            // calculates the answer for area
            area = length * width;

            // calculates the answer for perimeter
            perimeter = 2 * (length + width);

            // display the results 
            txtArea.Text = Convert.ToString(area);
            txtPerimeter.Text = Convert.ToString(perimeter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
