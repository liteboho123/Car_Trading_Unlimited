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
	public partial class AddNewVehicles
	{
        CTUConnection connect;

		public AddNewVehicles()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
            txt_serial.MaxLength = 13;
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
		

        private void NoText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void can_Clear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txt_Brand.Clear();
            txt_Color.Clear();
            txt_Model.Clear();
            txt_Price.Clear();
            txt_serial.Clear();
        }

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            if (txt_serial.MaxLength != 13 || string.IsNullOrEmpty(txt_serial.Text))
            {
                MessageBox.Show("Please enter a serial number for the vehicle");
            }

            else if (string.IsNullOrEmpty(txt_Brand.Text))
            {
                MessageBox.Show("Please enter the serial number of the vehicle");
            }

            else if (string.IsNullOrEmpty(txt_Color.Text))
            {
                MessageBox.Show("Please enter the color of vehicle");
            }

            else if (string.IsNullOrEmpty(txt_Model.Text))
            {
                MessageBox.Show("Please enter the model of the vehicle");
            }

            else if (string.IsNullOrEmpty(txt_Price.Text))
            {
                MessageBox.Show("Please enter a serial number for the vehicle");
            }

            else
            {
                connect.GetNewVehicles(txt_Brand.Text, txt_Model.Text, txt_serial.Text, txt_Color.Text, txt_Price.Text, Convert.ToDateTime(DTP_Year.SelectedDate.ToString()));
            }
        }
	}
}