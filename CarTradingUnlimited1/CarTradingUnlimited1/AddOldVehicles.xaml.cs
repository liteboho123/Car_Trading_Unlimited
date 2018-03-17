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
	public partial class AddOldVehicles
	{
        CTUConnection connect;

        public string Type
        {
            get;
            set;
        }

        public string Condition
        {
            get;
            set;
        }

		public AddOldVehicles()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
            txt_Serial.MaxLength = 13;
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

        private void Rad_Used_Click(object sender, RoutedEventArgs e)
        {
            Rad_Used.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Demo.Foreground = new SolidColorBrush(Colors.Violet);
            Type = "Used";
        }

        private void Rad_Demo_Click(object sender, RoutedEventArgs e)
        {
            Rad_Used.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Demo.Foreground = new SolidColorBrush(Colors.Red);
            Type = "Demo";
        }

        private void can_Clear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txt_Brand.Clear();
            txt_Color.Clear();
            txt_Model.Clear();
            txt_Price.Clear();
            txt_Serial.Clear();
            txt_Speed.Clear();
        }

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            try
            {
                if (txt_Serial.MaxLength != 13 || string.IsNullOrEmpty(txt_Serial.Text))
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
                    MessageBox.Show("Please enter the price of the vehicle");
                }

                else if (string.IsNullOrEmpty(txt_Speed.Text))
                {
                    MessageBox.Show("Please enter the current speed of the vehicle");
                }

                else if (Rad_Good.IsChecked == false && Rad_Bad.IsChecked == false && Rad_Average.IsChecked == false)
                {
                    MessageBox.Show("Please select the condition of the vehicle");
                }

                else if (Rad_Used.IsChecked == false && Rad_Demo.IsChecked == false)
                {
                    MessageBox.Show("Please select the type of vehicle");
                }

                else
                {
                    connect.GetOldVehicles(txt_Brand.Text, txt_Model.Text, txt_Serial.Text, txt_Color.Text, Type, txt_Price.Text, txt_ServiceHis.Text, Convert.ToInt64(txt_Speed.Text), Condition);
                }
            }

            catch (FormatException)
            { 

            }
        }

        private void Rad_Good_Click(object sender, RoutedEventArgs e)
        {
            Rad_Good.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Average.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Bad.Foreground = new SolidColorBrush(Colors.Violet);

            Condition = "Good";
        }

        private void Rad_Average_Click(object sender, RoutedEventArgs e)
        {
            Rad_Good.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Average.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Bad.Foreground = new SolidColorBrush(Colors.Violet);

            Condition = "Average";
        }

        private void Rad_Bad_Click(object sender, RoutedEventArgs e)
        {
            Rad_Good.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Average.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Bad.Foreground = new SolidColorBrush(Colors.Red);

            Condition = "Bad";
        }
		
	}
}