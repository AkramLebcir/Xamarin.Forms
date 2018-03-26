using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Resistor_Calc
{
	public partial class MainPage : ContentPage
	{
        private string result1 = "0";
        private string result2 = "0";
        private string chiffre = "";
        private string chiffre1 = "";
        private string chiffre2 = "";
        private string Multiplicateur = "";
        private string Tolérance = "";

        public MainPage()
		{
			InitializeComponent();
        }

        private void p1c1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chiffre1 = p1c1.SelectedIndex.ToString();
            result();
        }

        private void p1c2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            chiffre2 = p1c2.SelectedIndex.ToString();
            result();
        }

        private void p1c3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p1c3.SelectedIndex == 0)
            {
                Multiplicateur = "1";
            }
            else if (p1c3.SelectedIndex == 1)
            {
                Multiplicateur = "10";
            }
            else if (p1c3.SelectedIndex == 2)
            {
                Multiplicateur = "100";
            }
            else if (p1c3.SelectedIndex == 3)
            {
                Multiplicateur = "1000";
            }
            else if (p1c3.SelectedIndex == 4)
            {
                Multiplicateur = "10000";
            }
            else if (p1c3.SelectedIndex == 5)
            {
                Multiplicateur = "100000";
            }
            else if (p1c3.SelectedIndex == 6)
            {
                Multiplicateur = "1000000";
            }
            else if (p1c3.SelectedIndex == 7)
            {
                Multiplicateur = "10000000";
            }
            else if (p1c3.SelectedIndex == 8)
            {
                Multiplicateur = "0.1";
            }
            else if (p1c3.SelectedIndex == 9)
            {
                Multiplicateur = "0.01";
            }

            result();
        }

        private void p1c4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p1c4.SelectedIndex == 0)
            {
                Tolérance = "1";
            }
            else if (p1c4.SelectedIndex == 1)
            {
                Tolérance = "2";
            }
            else if (p1c4.SelectedIndex == 2)
            {
                Tolérance = "0.5";
            }
            else if (p1c4.SelectedIndex == 3)
            {
                Tolérance = "0.25";
            }
            else if (p1c4.SelectedIndex == 4)
            {
                Tolérance = "0.10";
            }
            else if (p1c4.SelectedIndex == 5)
            {
                Tolérance = "0.05";
            }
            else if (p1c4.SelectedIndex == 6)
            {
                Tolérance = "5";
            }
            else if (p1c4.SelectedIndex == 7)
            {
                Tolérance = "10";
            }
            result();
        }

        public void result()
        {
            chiffre = chiffre1 + chiffre2;
            try
            {
                result1 = (Convert.ToSingle(chiffre) * Convert.ToSingle(Multiplicateur)).ToString();
            }
            catch (Exception e){}

            result2 = "± " + Tolérance + " %";

            resistor1.Text = result1 + " Ω";

            resistor2.Text = result2;
        }
    }
}
