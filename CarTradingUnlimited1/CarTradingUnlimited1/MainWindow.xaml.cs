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
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        LoginWindow login;
        ViewCustomer viewCust;
        ViewEmployee viewEm;
        ViewMotorCycle viewMoto;
        ViewNewVehicles viewNVcar;
        ViewOldVehicles viewOldcar;
        ViewParts viewParts;
        ViewBooking Vbookdrive;
        ViewService Vservice;
        ViewInvoice viewIn;

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

        

		public MainWindow()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.            
		}

		private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			 if (e.ChangedButton == MouseButton.Left)
                DragMove();
		}

		private void can_btn_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = .8;
						
			
			TranslateTransform trans2 = new TranslateTransform();			
			
			TxtBlk_LogOut.RenderTransform = trans2;			
			
			DoubleAnimation anim2 = new DoubleAnimation(0, -9, TimeSpan.FromSeconds(0.2));			
			
			trans2.BeginAnimation(TranslateTransform.YProperty, anim2);
			
		}

		private void can_btn_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 0;
			
			TranslateTransform trans2 = new TranslateTransform();			
			
			TxtBlk_LogOut.RenderTransform = trans2;			
			
			DoubleAnimation anim2 = new DoubleAnimation(-9, 0, TimeSpan.FromSeconds(0.2));			
			
			trans2.BeginAnimation(TranslateTransform.YProperty, anim2);
		}	

		private void Btn_Close_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.Close();
		}

		private void Btn_Minimize_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.WindowState = WindowState.Minimized;
		}

		private void Btn_Customer_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Customer.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.2, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Customer.Opacity = 0.7;
			
			TxtBlK_TaskName.Text = "Customer details";
		}

		private void Btn_Customer_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Customer.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1.2, 1, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Customer.Opacity = 1;		
			
		}

		private void Btn_Close_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Btn_Close.Opacity = 0.7;
		}

		private void Btn_Close_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Btn_Close.Opacity = 1;
		}

		private void Btn_Employee_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Employee.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.2, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Employee.Opacity = 0.7;
			
			TxtBlK_TaskName.Text = "Employee details";
		}

		private void Btn_Employee_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Employee.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1.2, 1, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Employee.Opacity = 1;
		}

		private void Btn_NewVehicles_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_NewVehicles.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.2, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_NewVehicles.Opacity = 0.7;
			
			TxtBlK_TaskName.Text = "New vehicles details";
		}

		private void Btn_NewVehicles_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_NewVehicles.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1.2, 1, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_NewVehicles.Opacity = 1;
		}

		private void Btn_OldVehicles_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_OldVehicles.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.2, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_OldVehicles.Opacity = 0.7;
			
			TxtBlK_TaskName.Text = "Old vehicles details";
		}

		private void Btn_OldVehicles_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_OldVehicles.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1.2, 1, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_OldVehicles.Opacity = 1;
		}

		private void Btn_Minimize_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Btn_Minimize.Opacity = 0.7;
		}

		private void Btn_Minimize_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Btn_Minimize.Opacity = 1;
		}

		private void Btn_TestDrive_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_TestDrive.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.2, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_TestDrive.Opacity = 0.7;
			  
			TxtBlK_TaskName.Text = "Book for test drive";
		}

		private void Btn_TestDrive_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_TestDrive.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1.2, 1, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_TestDrive.Opacity = 1;
		}

		private void Btn_Service_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Service.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.2, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Service.Opacity = 0.7;
			
			TxtBlK_TaskName.Text = "Service details";
		}

		private void Btn_Service_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Service.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1.2, 1, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Service.Opacity = 1;
		}

		private void Btn_Motorcycle_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Motorcycle.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.2, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Motorcycle.Opacity = 0.7;
			
			TxtBlK_TaskName.Text = "Motor-cycle details";
		}

		private void Btn_Motorcycle_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Motorcycle.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1.2, 1, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Motorcycle.Opacity = 1;
		}

		private void Btn_Parts_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Parts.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.2, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Parts.Opacity = 0.7;
			
			TxtBlK_TaskName.Text = "Parts details";
		}

		private void Btn_Parts_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			ScaleTransform trans = new ScaleTransform();
			
			Btn_Parts.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1.2, 1, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Parts.Opacity = 1;
		}

		private void Btn_Customer_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            viewCust = new ViewCustomer();           
            _mainFrame.Navigate(viewCust);           
		}

		private void Btn_Employee_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            viewEm = new ViewEmployee();
            viewEm.Department = Department;
            viewEm.RoleType = RoleType;

            if (RoleType == "SalesMan" || RoleType == "Mechanic" || RoleType == "Surbordinate")
            {
                viewEm.can_Delete.Visibility = Visibility.Collapsed;
                _mainFrame.Navigate(viewEm);
            }

            else
            {
                _mainFrame.Navigate(viewEm);
            }
			
		}

		private void Btn_NewVehicles_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            viewNVcar = new ViewNewVehicles();
            viewNVcar.RoleType = RoleType;
            viewNVcar.Department = Department;

            if (RoleType == "SalesMan" || RoleType == "Mechanic" || RoleType == "Surbordinate")
            {
                viewNVcar.can_Delete.Visibility = Visibility.Collapsed;
                _mainFrame.Navigate(viewNVcar);
            }

            else
            {
                _mainFrame.Navigate(viewNVcar);
            }
			
		}

		private void Btn_OldVehicles_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            viewOldcar = new ViewOldVehicles();
            viewOldcar.RoleType = RoleType;
            viewOldcar.Department = Department;

            if (RoleType == "SalesMan" || RoleType == "Mechanic" || RoleType == "Surbordinate")
            {
                viewOldcar.can_Delete.Visibility = Visibility.Collapsed;
                _mainFrame.Navigate(viewOldcar);
            }

            else
            {
                _mainFrame.Navigate(viewOldcar);
            }
			
		}

		private void Btn_TestDrive_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Vbookdrive = new ViewBooking();
            Vbookdrive.RoleType = RoleType;
            Vbookdrive.Department = Department;

            if (RoleType == "SalesMan" || RoleType == "Mechanic" || RoleType == "Surbordinate")
            {
                Vbookdrive.can_Delete.Visibility = Visibility.Collapsed;
                _mainFrame.Navigate(Vbookdrive);
            }

            else
            {
                _mainFrame.Navigate(Vbookdrive);
            }
			
		}

		private void Btn_Service_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Vservice = new ViewService();
            Vservice.RoleType = RoleType;
            Vservice.Department = Department;

            if (RoleType == "SalesMan" || RoleType == "Mechanic" || RoleType == "Surbordinate")
            {
                Vservice.can_Delete.Visibility = Visibility.Collapsed;
                _mainFrame.Navigate(Vservice);
            }

            else
            {
                _mainFrame.Navigate(Vservice);
            }
			
		}

		private void Btn_Motorcycle_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            viewMoto = new ViewMotorCycle();
            viewMoto.RoleType = RoleType;
            viewMoto.Department = Department;

            if (RoleType == "SalesMan" || RoleType == "Mechanic" || RoleType == "Surbordinate")
            {
                viewMoto.can_Delete.Visibility = Visibility.Collapsed;
                _mainFrame.Navigate(viewMoto);
            }

            else
            {
                _mainFrame.Navigate(viewMoto);
            }
			
		}

		private void Btn_Parts_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            viewParts = new ViewParts();
            viewParts.RoleType = RoleType;
            viewParts.Department = Department;

            if (RoleType == "SalesMan" || RoleType == "Mechanic" || RoleType == "Surbordinate")
            {
                viewParts.can_Delete.Visibility = Visibility.Collapsed;
                _mainFrame.Navigate(viewParts);
            }

            else
            {
                _mainFrame.Navigate(viewParts);
            }
			
		}

        private void can_btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
			login = new LoginWindow();
			
            MessageBoxResult result = MessageBox.Show("Are you sure you want to log-out?", "Log out", MessageBoxButton.YesNo, MessageBoxImage.Question); //Display a message-dialog which renders a 'Yes' and a 'No' button//
            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Hide();
                    login.Show();
                    break;

                case MessageBoxResult.No:
                    break;
            }
        }

        private void Btn_Invoice_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	ScaleTransform trans = new ScaleTransform();
			
			Btn_Invoice.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.2, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Invoice.Opacity = 0.7;
			
			TxtBlK_TaskName.Text = "Invoice details";
        }

        private void Btn_Invoice_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	ScaleTransform trans = new ScaleTransform();
			
			Btn_Invoice.RenderTransform = trans;
			
			DoubleAnimation anim = new DoubleAnimation(1.2, 1, TimeSpan.FromSeconds(0.2));
			
			trans.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
			trans.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
			Btn_Invoice.Opacity = 1;
        }

        private void Btn_Invoice_Click(object sender, RoutedEventArgs e)
        {
            viewIn = new ViewInvoice();
            viewIn.RoleType = RoleType;
            viewIn.Department = Department;

            if (Department == 1)
            {
                viewIn.Stck_Parts.Visibility = Visibility.Collapsed;

            }

            else if (Department == 2)
            {
                viewIn.Stck_Parts.Visibility = Visibility.Collapsed;
            }

            else if (Department == 3)
            {
               viewIn.Stck_Parts.Visibility = Visibility.Collapsed;
               viewIn.Stck_ServPlan.Visibility = Visibility.Collapsed;
            }

            else if (Department == 4)
            {
                viewIn.Stck_ServPlan.Visibility = Visibility.Collapsed;
                viewIn.Stack_Vehicle.Visibility = Visibility.Collapsed;
            }

            if (RoleType == "SalesMan" || RoleType == "Mechanic" || RoleType == "Surbordinate")
            {
                viewIn.can_Delete.Visibility = Visibility.Collapsed;
                _mainFrame.Navigate(viewIn);
            }

            else
            {
                _mainFrame.Navigate(viewIn);
            }
        }	
		
	}
}