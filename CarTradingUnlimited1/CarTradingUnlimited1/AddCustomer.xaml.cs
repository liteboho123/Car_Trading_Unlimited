using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace CarTradingUnlimited
{
	public partial class AddCustomer
	{
        CTUConnection connect;
        ViewCustomer viewCust;
        
		public AddCustomer()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
            txt_IDnumber.MaxLength = 13;
            txt_BankNO.MaxLength = 18;
		}

		private void can_Submit_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 1;
		}

		private void can_Submit_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 0;
		}

		private void can_Clear_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow1.Opacity = 1;
		}

		private void can_Clear_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow1.Opacity = 0;
		}

        private void can_Clear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txt_firstname.Clear();
            txt_Surname.Clear();
            txt_username.Clear();
            txt_Password.Clear();
            txt_IDnumber.Clear();
        }

        private void NoText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();
            viewCust = new ViewCustomer();

            if (txt_BankNO.MaxLength != 18 || string.IsNullOrEmpty(txt_BankNO.Text))
            {
                MessageBox.Show("Make sure the bank account number is correct");
            }

            else if (string.IsNullOrEmpty(txt_firstname.Text))
            {
                MessageBox.Show("Please enter the firstname of the customer");
            }

            else if (txt_IDnumber.MaxLength != 13 || string.IsNullOrEmpty(txt_IDnumber.Text))
            {
                MessageBox.Show("Please enter the ID number of the customer");
            }

            else if (string.IsNullOrEmpty(txt_Surname.Text))
            {
                MessageBox.Show("Please enter the surname of the customer");
            }

            else if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Please enter the password of the customer");
            }

            else
            {
                connect.GetCustomer(txt_username.Text, txt_Password.Text, txt_firstname.Text, txt_Surname.Text, txt_IDnumber.Text, txt_BankNO.Text);
                connect.SelectCustomer();
                viewCust.DGV_Cust.ItemsSource = connect.table.DefaultView;
            }            
        }
	}
}