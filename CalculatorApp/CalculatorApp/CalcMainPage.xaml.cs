using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Xamarin.Forms;
//using Roslyn.Scripting.CSharp;

namespace CalculatorApp
{	
	public partial class CalcMainPage : ContentPage
	{	
		public CalcMainPage ()
		{
			InitializeComponent ();
			this.BackgroundColor = Color.Gray;
			
        }

        private void ButtonEqual_Clicked(object sender, EventArgs e)
        {
            var expression = calculation.Text;
            Evaluate(expression);
        }

        private void Evaluate(string expression)
        {
            double val = Math.Round(Convert.ToDouble(new System.Data.DataTable().Compute(expression, null)),2);
            calculation.Text = val.ToString();
        }

        private void ButtonPoint_Clicked(object sender, EventArgs e)
        {
            calculation.Text += ".";
        }

        private void ButtonZero_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "0";
        }

        private void ButtonPlus_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "+";
        }

        private void ButtonThree_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "3";
        }

        private void ButtonTwo_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "2";
        }

        private void ButtonOne_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "1";
        }

        private void ButtonMinus_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "-";
        }

        private void ButtonMultiply_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "*";
        }

        private void ButtonSix_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "6";
        }

        private void ButtonFive_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "5";
        }

        private void ButtonFour_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "4";
        }

        private void ButtonNine_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "9";
        }

        private void ButtonEight_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "8";
        }

        private void ButtonSeven_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "7";
        }

        private void ButtonPercent_Clicked(object sender, EventArgs e)
        {
            //var x = (Convert.ToInt32(calculation.Text)).ToString();
            //calculation.Text = x;
            calculation.Text  += "%";
        }

        private void ButtonStart_Clicked(object sender, EventArgs e)
        {
            calculation.Text = "";
        }

        private void ButtonX_Clicked(object sender, EventArgs e)
        {
            var num = Convert.ToDouble(calculation.Text) * -1;
            calculation.Text = num.ToString();
        }

        private void ButtonDivide_Clicked(object sender, EventArgs e)
        {
            calculation.Text += "/";
        }

    }
}

