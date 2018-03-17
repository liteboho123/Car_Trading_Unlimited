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
	public partial class UpdateEmployee
	{
        ViewEmployee ViewEmploy;
        AddEmployee AddEmploy;
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

		public UpdateEmployee()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
            txt_IDnumber.MaxLength = 13;
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

		private void Can_AddEmployee_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Visible;		
			elipse_AddEmployee.Opacity = 0.75;
			
			TxtBlk_AddEmployee.Foreground = new SolidColorBrush(Colors.White);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddEmployee.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);			
			
			sb1.Begin();
		}

		private void Can_AddEmployee_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Collapsed;
			elipse_AddEmployee.Opacity = 1;	
			
			TxtBlk_AddEmployee.Foreground = new SolidColorBrush(Colors.Black);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddEmployee.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1.1, 1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);
			
			sb1.Stop();
		}

        private void Can_AddEmployee_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ViewEmploy = new ViewEmployee();
            AddEmploy = new AddEmployee();

            ViewEmploy.Employee_page = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && ViewEmploy.Employee_page == null)
            {
                ViewEmploy.Employee_page = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            if (ViewEmploy.Employee_page != null)
            {
                AddEmploy.Department = Department;
                ViewEmploy.Employee_page.Navigate(AddEmploy);                
            }
        }

        private void Page_Employee_Loaded(object sender, RoutedEventArgs e)
        {
            connect = new CTUConnection();
            connect.SelectRole();
            cmbx_Role.ItemsSource = connect.table.DefaultView;
            cmbx_Role.DisplayMemberPath = "RoleType";
            cmbx_Role.SelectedValuePath = "ID";
        }

        private void can_Clear_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txt_Firstname.Clear();
            txt_Surname.Clear();
            txt_IDnumber.Clear();
            txt_Username.Clear();
            txt_Password.Clear();
        }

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            if (string.IsNullOrEmpty(txt_Firstname.Text))
            {
                MessageBox.Show("Please enter the firstname of the employee");
            }

            else if (string.IsNullOrEmpty(txt_Surname.Text))
            {
                MessageBox.Show("Please enter the surname of the employee");
            }

            else if (string.IsNullOrEmpty(txt_IDnumber.Text) || txt_IDnumber.MaxLength != 13)
            {
                MessageBox.Show("Please enter the ID number of the employee");
            }

            else if (string.IsNullOrEmpty(txt_Username.Text))
            {
                MessageBox.Show("Please enter the username of the employee");
            }

            else if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Please enter the password of the employee");
            }

            else
            {
                try
                {
                    connect.UpdateEmployee(txt_Username.Text, txt_Password.Text, txt_Firstname.Text, txt_Surname.Text, txt_IDnumber.Text, int.Parse(cmbx_Role.SelectedValue.ToString()), int.Parse(ID));
                    connect.SelectEmployee();
                    ViewEmploy.DGV_Employee.ItemsSource = connect.table.DefaultView;
                }

                catch(Exception)
                {
 
                }
            }
        }
	}
}