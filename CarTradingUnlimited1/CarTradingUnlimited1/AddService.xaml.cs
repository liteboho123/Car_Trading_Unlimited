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
	public partial class AddService
	{
        CTUConnection connect;        

		public AddService()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
			
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

		private void Rad_Yes_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Rad_Yes.Foreground = new SolidColorBrush(Colors.Red);
			Rad_No.Foreground = new SolidColorBrush(Colors.Black);
			
			GRP_Cust.Visibility = Visibility.Visible;
			Stck_Notice.Visibility = Visibility.Collapsed;
			
			Dock_Decision.Visibility = Visibility.Visible;
			Dock_AddService.Visibility = Visibility.Collapsed;
		}

		private void Rad_No_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Rad_No.Foreground = new SolidColorBrush(Colors.Red);
			Rad_Yes.Foreground = new SolidColorBrush(Colors.Black);
			
			Stck_Notice.Visibility = Visibility.Visible;
			GRP_Cust.Visibility = Visibility.Collapsed;			
			Dock_Decision.Visibility = Visibility.Visible;
			Dock_AddService.Visibility = Visibility.Collapsed;
		}

		private void cmbx_Cust_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			Dock_AddService.Visibility = Visibility.Visible;
		}

        private void NoText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Page_Service_Loaded(object sender, RoutedEventArgs e)
        {
            connect = new CTUConnection();
            connect.SelectcertainCustomerService();
            cmbx_Cust.ItemsSource = connect.table.DefaultView;
            cmbx_Cust.DisplayMemberPath = "[Name of the customer]";
            cmbx_Cust.SelectedValuePath = "ID";

            connect.SelectcertainMechanicService();
            cmbx_Mech.ItemsSource = connect.table2.DefaultView;
            cmbx_Mech.DisplayMemberPath = "[Name of Mechanic]";
            cmbx_Mech.SelectedValuePath = "[employ ID]";

        }        

        private void can_Clear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txt_CustCar.Clear();
            txt_Prob.Clear();
        }

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            try
            {
                if (string.IsNullOrEmpty(txt_CustCar.Text))
                {
                    MessageBox.Show("Please enter the name of the vehicle");
                }

                else if (string.IsNullOrEmpty(txt_Prob.Text))
                {
                    MessageBox.Show("Please enter the problem of the vehicle");
                }

                else
                {
                    connect.GetCarServices(txt_CustCar.Text, Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), txt_Prob.Text, int.Parse(cmbx_Mech.SelectedValue.ToString()), int.Parse(cmbx_Cust.SelectedValue.ToString()));
                }
            }

            catch(FormatException)
            {
                MessageBox.Show("Please select a date");
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a Mechanic");
            }
        }
		
	}
}