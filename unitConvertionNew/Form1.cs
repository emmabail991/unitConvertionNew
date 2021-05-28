using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unitConvertionNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //calculations inch to cm
        public double InchToCm(double inches)
        {
            double cm = inches * 2.54;
            return cm;
        }

        //calculates feet to cm
        public double FeetToCm(double feet)
        {
            double cm = feet * 30.48;
            return cm;
        }

        // calculations for yards ro meters
        public double YardsToMetres(double yards)
        {
            double metres = yards * 0.91;
            return metres;
        }

        //Calculations for miles to km
        public double MilesToKm(double miles)
        {
            double km = miles * 1.609;
            return km;
        }


        private void convertButton_Click_1(object sender, EventArgs e)
        {
            //figure out what conversion we must do
            double choice = Convert.ToDouble(conversionChoice.Text);

            //get number inputed to convert
            double number = Convert.ToDouble(convertionNumber.Text);

            //choose which equation to used bassed on the choiceNumber
            if (choice == 1)
            {
                double cm = InchToCm(number);
                outputLabel.Text = $"{number} inches is {cm}cms";
            }
            else if (choice == 2)
            {
                double result = FeetToCm(number);
                outputLabel.Text = $"{number} foot is {result}cms";
            }
            else if (choice == 3)
            {
                double metres = YardsToMetres(number);
                outputLabel.Text = $"{number} yards is {metres}metres";
            }
            else if (choice == 4)
            {
                double km = MilesToKm(number);
                outputLabel.Text = $"{number} miles is {km}km";
            }
            else
            {
                outputLabel.Text = "Please use 1-4 to select their corresponding conversions";
            }

        }
    }
}
