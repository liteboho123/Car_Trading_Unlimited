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
	public partial class AddEmployee
	{
        CTUConnection connect;
        ViewEmployee viewEm;      
       
        
        public int Department
        {
            get;
            set;
        }
       
		public AddEmployee()
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

        private void can_Clear_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txt_FirstName.Clear();
            txt_Surname.Clear();
            txt_IDnumber.Clear();
            txt_UserName.Clear();
            txt_Password.Clear();
        }

        private void can_Submit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();
            viewEm = new ViewEmployee();

            if (string.IsNullOrEmpty(txt_FirstName.Text))
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

            else if (string.IsNullOrEmpty(txt_UserName.Text))
            {
                MessageBox.Show("Please enter the username of the employee");
            }

            else if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Please enter the password of the employee");
            }

            else 
            {
                connect.GetEmployee(txt_UserName.Text, txt_Password.Text, txt_FirstName.Text, txt_Surname.Text, txt_IDnumber.Text, Department, int.Parse(cmbx_Role.SelectedValue.ToString()));
                connect.SelectEmployee();
                viewEm.DGV_Employee.ItemsSource = connect.table.DefaultView;
            }
        }

        private void Page_Eploy_Loaded(object sender, RoutedEventArgs e)
        {
            connect = new CTUConnection();
            connect.SelectRole();
            cmbx_Role.ItemsSource = connect.table.DefaultView;
            cmbx_Role.DisplayMemberPath = "RoleType";
            cmbx_Role.SelectedValuePath = "ID";
        }

        private void cmbx_Role_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DOCK_ADDEMPLOYEE.Visibility = Visibility.Visible;
        }
	}
}