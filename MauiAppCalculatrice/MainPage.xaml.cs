using System.Data;

namespace MauiAppCalculatrice
{
    public partial class MainPage : ContentPage
    {

        public MainPage() 
        { 
            InitializeComponent(); 
        }
        private void Button_Clicked_Supp(object sender, EventArgs e) 
        { expLabel.Text = ""; }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            expLabel.Text += "1";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            expLabel.Text += "2";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            expLabel.Text += "3";
        }

        private void Button_Cliked_multi(object sender, EventArgs e)
        {
            expLabel.Text += "*";
        }

        private void Button_Cliked_4(object sender, EventArgs e)
        {
            expLabel.Text += "4";
        }

        private void Button_Cliked_5(object sender, EventArgs e)
        {
            expLabel.Text += "5";
        }

        private void Button_Cliked_6(object sender, EventArgs e)
        {
            expLabel.Text += "6";
        }

        private void Button_Cliked_division(object sender, EventArgs e)
        {
            expLabel.Text += "/";
        }

        private void Button_Cliked_7(object sender, EventArgs e)
        {
            expLabel.Text += "7";
        }

        private void Button_Cliked_8(object sender, EventArgs e)
        {
            expLabel.Text += "8";
        }

        private void Button_Cliked_9(object sender, EventArgs e)
        {
            expLabel.Text += "9";
        }

        private void Button_Cliked_add(object sender, EventArgs e)
        {
            expLabel.Text += "+";
        }

        private void Button_Cliked_0(object sender, EventArgs e)
        {
            expLabel.Text += "0";
        }

        private void Button_Cliked_moins(object sender, EventArgs e)
        {
            expLabel.Text += "-";
        }

        private void Button_Cliked_Egale(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(expLabel.Text))
            {
                DataTable dt = new DataTable();
                var r = dt.Compute(expLabel.Text, "");
                expLabel.Text = $"{r}";
            }
        }
    }

}
