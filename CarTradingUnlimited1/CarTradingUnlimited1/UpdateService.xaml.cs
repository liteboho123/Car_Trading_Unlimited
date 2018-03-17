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

namespace CarTradingUnlimited
{
	public partial class UpdateService
	{
        ViewService Viewservice;
        AddService Addservice;
        CTUConnection connect;

        public string ID
        {
            get;
            set;
        }

        public int Department
        {
            get;
            set;
        }

        public int RoleType
        {
            get;
            set;
        }

        public string Progress
        {
            get;
            set;
        }

		public UpdateService()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void Can_AddService_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Visible;		
			elipse_AddService.Opacity = 0.75;
			
			TxtBlk_AddService.Foreground = new SolidColorBrush(Colors.White);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddService.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);			
			
			sb1.Begin();
		}

		private void Can_AddService_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Collapsed;
			elipse_AddService.Opacity = 1;	
			
			TxtBlk_AddService.Foreground = new SolidColorBrush(Colors.Black);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddService.RenderTransform = trans;			
			
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

        private void Can_AddService_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Viewservice = new ViewService();
            Addservice = new AddService();

            Viewservice.Service_page = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && Viewservice.Service_page == null)
            {
                Viewservice.Service_page = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            if (Viewservice.Service_page != null)
            {
                Viewservice.Service_page.Source = new Uri("AddService.xaml", UriKind.Relative);
            }
        }

        private void Page_UpdateService_Loaded(object sender, RoutedEventArgs e)
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
                    connect.UpdateCarService(txt_CustCar.Text, Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), txt_Prob.Text, Progress, int.Parse(cmbx_Mech.SelectedValue.ToString()), int.Parse(cmbx_Cust.SelectedValue.ToString()), int.Parse(ID));
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please select a date");
            }
        }

        private void Rad_Hold_Click(object sender, RoutedEventArgs e)
        {
            Rad_Hold.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Process.Foreground = new SolidColorBrush(Colors.Green);
            Rad_Done.Foreground = new SolidColorBrush(Colors.Green);

            Progress = "On hold";
        }

        private void Rad_Process_Click(object sender, RoutedEventArgs e)
        {
            Rad_Hold.Foreground = new SolidColorBrush(Colors.Green);
            Rad_Process.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Done.Foreground = new SolidColorBrush(Colors.Green);

            Progress = "In process";
        }

        private void Rad_Done_Click(object sender, RoutedEventArgs e)
        {
            Rad_Hold.Foreground = new SolidColorBrush(Colors.Green);
            Rad_Process.Foreground = new SolidColorBrush(Colors.Green);
            Rad_Done.Foreground = new SolidColorBrush(Colors.Red);

            Progress = "Completed";
        }
	}
}