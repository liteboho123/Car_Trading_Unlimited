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
using System.Windows.Media.Animation;
using System.Text.RegularExpressions;

namespace CarTradingUnlimited
{
	public partial class UpdateOldVehicles
	{
        ViewOldVehicles ViewOldCar;
        AddOldVehicles AddOldCar;
        CTUConnection connect;

        public string ID
        {
            get;
            set;
        }

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

		public UpdateOldVehicles()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
            txt_serial.MaxLength = 13;            
		}

		private void Can_AddOldCar_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Visible;		
			elipse_AddOldCar.Opacity = 0.75;
			
			TxtBlk_AddOldCar.Foreground = new SolidColorBrush(Colors.White);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddOldCar.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);			
			
			sb1.Begin();
		}

		private void Can_AddOldCar_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Collapsed;
			elipse_AddOldCar.Opacity = 1;	
			
			TxtBlk_AddOldCar.Foreground = new SolidColorBrush(Colors.Black);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddOldCar.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1.1, 1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);
			
			sb1.Stop();
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

        private void Can_AddOldCar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ViewOldCar = new ViewOldVehicles();
            AddOldCar = new AddOldVehicles();

            ViewOldCar.OldVehicle_page = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && ViewOldCar.OldVehicle_page == null)
            {
                ViewOldCar.OldVehicle_page = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            if (ViewOldCar.OldVehicle_page != null)
            {
                ViewOldCar.OldVehicle_page.Source = new Uri("AddOldVehicles.xaml", UriKind.Relative);
            }
        }

        private void NoText(object sender, System.Windows.Input.TextCompositionEventArgs e)
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
            txt_serviceHis.Clear();
            txt_Speed.Clear();           
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
                connect.UpdateOldVehicles(txt_Brand.Text, txt_Model.Text, txt_serial.Text, txt_Color.Text, Type, txt_Price.Text, txt_serviceHis.Text, Convert.ToInt64(txt_Speed.Text), Condition, int.Parse(ID));
            }
        }

        private void Rad_Used_Click(object sender, RoutedEventArgs e)
        {
            
        }
        

        private void Rad_Used_Checked(object sender, RoutedEventArgs e)
        {
            Rad_Used.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Demo.Foreground = new SolidColorBrush(Colors.Violet);
            Type = "Used";
        }

        private void Rad_Demo_Checked(object sender, RoutedEventArgs e)
        {
            Rad_Used.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Demo.Foreground = new SolidColorBrush(Colors.Red);
            Type = "Demo";
        }

        private void Rad_Good_Checked(object sender, RoutedEventArgs e)
        {
            Rad_Good.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Average.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Bad.Foreground = new SolidColorBrush(Colors.Violet);

            Condition = "Good";
        }

        private void Rad_Average_Checked(object sender, RoutedEventArgs e)
        {
            Rad_Good.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Average.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Bad.Foreground = new SolidColorBrush(Colors.Violet);

            Condition = "Average";
        }

        private void Rad_Bad_Checked(object sender, RoutedEventArgs e)
        {
            Rad_Good.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Average.Foreground = new SolidColorBrush(Colors.Violet);
            Rad_Bad.Foreground = new SolidColorBrush(Colors.Red);

            Condition = "Bad";
        }		
	}
}