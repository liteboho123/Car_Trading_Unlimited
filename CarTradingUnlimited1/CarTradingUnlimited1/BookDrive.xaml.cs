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

namespace CarTradingUnlimited
{
	public partial class BookDrive
	{
        CTUConnection connect;
      
      

        public int BookCount
        {
            get;
            set;
        }

        public int Department
        {
            get;
            set;
        }

        public string RoleType
        {
            get;
            set;
        }        

		public BookDrive()
		{
			this.InitializeComponent();            

			// Insert code required on object creation below this point.          
		}
		
		string Type
		{
			get;
			set;
		}

		private void can_Submit_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 1; //Setting the opacity of the rectangle "glow" to 100%//
		}

		private void can_Submit_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 0; //Setting the opacity of the rectangle "glow" to 0%//
		}		

		private void Rad_New_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Type = "New"; //Set the string "Type" variable Text to "New"//
			GRP_Vehicle.Header = "Select a new vehicle"; //Set the header of the group-box "GRP_Vehicle" to 'Select a new vehicle'//
			
			Rad_New.Foreground = new SolidColorBrush(Colors.Red);
			Rad_Used.Foreground = new SolidColorBrush(Colors.Black);
			Rad_Demo.Foreground = new SolidColorBrush(Colors.Black);

            connect = new CTUConnection();
            connect.SelectTestDrive();
            for (int i = 0; i <= connect.table.Rows.Count; i++)
            {
                this.BookCount = i + 1;
            }


            connect.SelectNewDrive();
            cmbx_Vehicle.ItemsSource = connect.table2.DefaultView;
            cmbx_Vehicle.DisplayMemberPath = "[Name of vehicle]";
            cmbx_Vehicle.SelectedValuePath = "ID";		
			
			
			Dock_Decision.Visibility = Visibility.Visible;
		}

		private void Rad_Used_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Type = "Used"; //Set the string "Type" variable Text to "Used"//
			GRP_Vehicle.Header = "Select a used vehicle"; //Set the header of the group-box "GRP_Vehicle" to 'Select a used vehicle'//
			
			Rad_New.Foreground = new SolidColorBrush(Colors.Black);
			Rad_Used.Foreground = new SolidColorBrush(Colors.Red);
			Rad_Demo.Foreground = new SolidColorBrush(Colors.Black);

            connect = new CTUConnection();
            connect.SelectTestDrive2();
            for (int i = 0; i <= connect.table.Rows.Count; i++)
            {
                this.BookCount = i + 1;
            }

            connect.SelectUsedDrive();
            cmbx_Vehicle.ItemsSource = connect.table2.DefaultView;
            cmbx_Vehicle.DisplayMemberPath = "[Name of vehicle]";
            cmbx_Vehicle.SelectedValuePath = "ID";	
			
			
			Dock_Decision.Visibility = Visibility.Visible;
		}

		private void Rad_Demo_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Type = "Demo"; //Set the string "Type" variable Text to "Demo"//
			GRP_Vehicle.Header = "Select a demo vehicle"; //Set the header of the group-box "GRP_Vehicle" to 'Select a demo vehicle'//
			
			Rad_New.Foreground = new SolidColorBrush(Colors.Black);
			Rad_Used.Foreground = new SolidColorBrush(Colors.Black);
			Rad_Demo.Foreground = new SolidColorBrush(Colors.Red);

            connect = new CTUConnection();
            connect.SelectTestDrive2();
            for (int i = 0; i <= connect.table.Rows.Count; i++)
            {
                this.BookCount = i + 1;
            }

            connect.SelectDemoDrive();
            cmbx_Vehicle.ItemsSource = connect.table2.DefaultView;
            cmbx_Vehicle.DisplayMemberPath = "[Name of vehicle]";
            cmbx_Vehicle.SelectedValuePath = "ID";
			
			
			Dock_Decision.Visibility = Visibility.Visible;
		}

		private void cmbx_Vehicle_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			Dock_AddDrive.Visibility = Visibility.Visible;
		}
       

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            try
            {
                if (Rad_New.IsChecked == true)
                {
                    connect.GetTestDrive(Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), BookCount, int.Parse(cmbx_Vehicle.SelectedValue.ToString()), int.Parse(cmbx_Cust.SelectedValue.ToString()));
                }

                else if (Rad_Used.IsChecked == true || Rad_Demo.IsChecked == true)
                {
                    connect.GetTestDrive2(Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), BookCount, int.Parse(cmbx_Vehicle.SelectedValue.ToString()), int.Parse(cmbx_Cust.SelectedValue.ToString()));
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter the date the vehicle was booked");
            }
        }

        private void Page_Booking_Loaded(object sender, RoutedEventArgs e)
        {
            connect = new CTUConnection();
            connect.SelectCustomerBooking();
            cmbx_Cust.ItemsSource = connect.table.DefaultView;
            cmbx_Cust.DisplayMemberPath = "[Name of the customer]";
            cmbx_Cust.SelectedValuePath = "ID";
        }        
	}
}