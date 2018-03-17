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
	public partial class ViewEmployee
	{
        CTUConnection connect;
        UpdateEmployee upEmploy;
        AddEmployee ademploy;

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

        public string RoleType
        {
            get;
            set;
        }


		public ViewEmployee()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.                     
		}
		
		private const string defaultText = "Please enter name...."; //creating a defualt state for the textbox 'name'//
		private void txt_Name_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			txt_Name.Background = new SolidColorBrush(Colors.White);
			txt_Name.Clear();
		}

		private void txt_Name_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			txt_Name.Text = txt_Name.Text == string.Format(txt_Name.Text) ? defaultText : txt_Name.Text;//Changing the text of the text box 'name' to default//
			sb1.Begin();
		}


        private const string defaultText2 = "Please enter ID...."; //creating a defualt state for the textbox 'name'//
        private void txt_ID_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_ID.Background = new SolidColorBrush(Colors.White);
            txt_ID.Clear();
        }


        private void txt_ID_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_ID.Text = txt_ID.Text == string.Format(txt_ID.Text) ? defaultText2 : txt_ID.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText3 = "Please enter username...."; //creating a defualt state for the textbox 'name'//
        private void txt_Username_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Username.Background = new SolidColorBrush(Colors.White);
            txt_Username.Clear();
        }


        private void txt_Username_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Username.Text = txt_Username.Text == string.Format(txt_Username.Text) ? defaultText3 : txt_Username.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText4 = "Please enter password...."; //creating a defualt state for the textbox 'name'//
        private void txt_Password_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Password.Background = new SolidColorBrush(Colors.White);
            txt_Password.Clear();
        }

        private void txt_Password_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Password.Text = txt_Password.Text == string.Format(txt_Password.Text) ? defaultText4 : txt_Password.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText5 = "Please enter surname...."; //creating a defualt state for the textbox 'name'//
        private void txt_Surname_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Surname.Background = new SolidColorBrush(Colors.White);
            txt_Surname.Clear();
        }

        private void txt_Surname_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Surname.Text = txt_Surname.Text == string.Format(txt_Surname.Text) ? defaultText5 : txt_Surname.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        } 

		private void can_Show_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 1;
		}

		private void can_Show_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 0;
		}

		private void can_Delete_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow1.Opacity = 1;
		}

		private void can_Delete_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow1.Opacity = 0;
		}

		private void can_Show_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            connect = new CTUConnection();
            connect.SelectEmployee();
            DGV_Employee.ItemsSource = connect.table.DefaultView;

		}

        private void can_Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection(); // refreshens the 'Connection' class // 

            try
            {
                connect.DeleteEmployee(int.Parse(ID));
                connect.SelectEmployee();
                DGV_Employee.ItemsSource = connect.table.DefaultView;
            }

            catch (Exception)
            {               

            }
        }

        private void DGV_Employee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                if (RoleType == "Administrator" || RoleType == "Manager")
                {
                    if(DGV_Employee.Items.IsEmpty)
                    {
                        ademploy = new AddEmployee();
                        Employee_page.Navigate(ademploy);
                    }

                    else
                    {
                    upEmploy = new UpdateEmployee();
                    object item = DGV_Employee.SelectedItem;
                    upEmploy.txt_Firstname.Text = (DGV_Employee.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                    upEmploy.txt_Surname.Text = (DGV_Employee.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                    upEmploy.txt_IDnumber.Text = (DGV_Employee.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                    upEmploy.txt_Username.Text = (DGV_Employee.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                    upEmploy.txt_Password.Text = (DGV_Employee.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                    ID = (DGV_Employee.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    upEmploy.ID = ID;
                    upEmploy.Department = Department;

                    Employee_page.Navigate(upEmploy);
                    }
                }
            }
            catch (Exception)
            {
               
            }
        }

        private void txt_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectEmployee();//*Selects the specified columns in the Patient table*//
            connect.SearchEmployeeName(txt_Name.Text);//Searches the customer's 'name' within the populated table//
            DGV_Employee.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_Surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectEmployee();//*Selects the specified columns in the Patient table*//
            connect.SearchEmployeeSurname(txt_Surname.Text);//Searches the customer's 'name' within the populated table//
            DGV_Employee.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_ID_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectEmployee();//*Selects the specified columns in the Patient table*//
            connect.SearchEmployeeID(txt_ID.Text);//Searches the customer's 'name' within the populated table//
            DGV_Employee.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectEmployee();//*Selects the specified columns in the Patient table*//
            connect.SearchEmployeeUsername(txt_Username.Text);//Searches the customer's 'name' within the populated table//
            DGV_Employee.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectEmployee();//*Selects the specified columns in the Patient table*//
            connect.SearchEmployeePassword(txt_Password.Text);//Searches the customer's 'name' within the populated table//
            DGV_Employee.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }               
	}
}