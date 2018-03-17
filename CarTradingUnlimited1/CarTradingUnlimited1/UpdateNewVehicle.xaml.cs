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
	public partial class UpdateNewVehicle
	{
        ViewNewVehicles ViewNewCar;
        AddNewVehicles AddNewCar;
        CTUConnection connect;

        public string ID
        {
            get;
            set;
        }

		public UpdateNewVehicle()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
            txt_serial.MaxLength = 13;
		}

		private void Can_AddNewCar_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Visible;		
			elipse_AddNewCar.Opacity = 0.75;
			
			TxtBlk_AddNewCar.Foreground = new SolidColorBrush(Colors.White);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddNewCar.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);			
			
			sb1.Begin();
		}

		private void Can_AddNewCar_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Collapsed;
			elipse_AddNewCar.Opacity = 1;	
			
			TxtBlk_AddNewCar.Foreground = new SolidColorBrush(Colors.Black);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddNewCar.RenderTransform = trans;			
			
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

        private void Can_AddNewCar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ViewNewCar = new ViewNewVehicles();
            AddNewCar = new AddNewVehicles();

            ViewNewCar.NVehicle_page = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && ViewNewCar.NVehicle_page == null)
            {
                ViewNewCar.NVehicle_page = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            if (ViewNewCar.NVehicle_page != null)
            {
                ViewNewCar.NVehicle_page.Source = new Uri("AddNewVehicles.xaml", UriKind.Relative);
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
        }

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            try
            {
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
                    connect.UpdateNewVehicles(txt_Brand.Text, txt_Model.Text, txt_serial.Text, txt_Color.Text, txt_Price.Text, Convert.ToDateTime(DTP_Year.SelectedDate.ToString()), int.Parse(ID));
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please select te date the vehicle was manufactured");
            }
        }
	}
}