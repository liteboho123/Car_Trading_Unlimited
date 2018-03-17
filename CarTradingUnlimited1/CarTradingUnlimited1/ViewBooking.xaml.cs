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
	public partial class ViewBooking
	{
        CTUConnection connect;
        
        ChangeBooking Cbook;

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

		public ViewBooking()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
            

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

        private const string defaultText = "Please enter name...."; //creating a defualt state for the textbox 'name'//
        private void txt_Cust_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Cust.Background = new SolidColorBrush(Colors.White);
            txt_Cust.Clear();
        }


        private void txt_Cust_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Cust.Text = txt_Cust.Text == string.Format(txt_Cust.Text) ? defaultText : txt_Cust.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText2 = "Please enter brand name...."; //creating a defualt state for the textbox 'name'//
        private void txt_Brand_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Brand.Background = new SolidColorBrush(Colors.White);
            txt_Brand.Clear();
        }

        private void txt_Brand_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Brand.Text = txt_Brand.Text == string.Format(txt_Brand.Text) ? defaultText2 : txt_Brand.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText3 = "Please enter model...."; //creating a defualt state for the textbox 'name'//
        private void txt_Model_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Model.Background = new SolidColorBrush(Colors.White);
            txt_Model.Clear();
        }

        private void txt_Model_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Model.Text = txt_Model.Text == string.Format(txt_Model.Text) ? defaultText3 : txt_Model.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText4 = "Please enter serial no...."; //creating a defualt state for the textbox 'name'//
        private void txt_SerialNo_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_SerialNo.Background = new SolidColorBrush(Colors.White);
            txt_SerialNo.Clear();
        }

        private void txt_SerialNo_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_SerialNo.Text = txt_SerialNo.Text == string.Format(txt_SerialNo.Text) ? defaultText4 : txt_SerialNo.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText5 = "Please enter price...."; //creating a defualt state for the textbox 'name'//
        private void txt_Price_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Price.Background = new SolidColorBrush(Colors.White);
            txt_Price.Clear();
        }

        private void txt_Price_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Price.Text = txt_Price.Text == string.Format(txt_Price.Text) ? defaultText5 : txt_Price.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private void txt_Cust_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            if (Department == 1)
            {
                connect.SelectTestDrive();//*Selects the specified columns in the Patient table*//
                connect.SearchCustBook(txt_Cust.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }

            else if (Department == 2)
            {
                connect.SelectTestDrive2();//*Selects the specified columns in the Patient table*//
                connect.SearchCustBook(txt_Cust.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }
        }

        private void txt_Brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            if (Department == 1)
            {
                connect.SelectTestDrive();//*Selects the specified columns in the Patient table*//
                connect.SearchBrandBook(txt_Brand.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }

            else if (Department == 2)
            {
                connect.SelectTestDrive2();//*Selects the specified columns in the Patient table*//
                connect.SearchBrandBook(txt_Brand.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }
        }

        private void txt_Model_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            if (Department == 1)
            {
                connect.SelectTestDrive();//*Selects the specified columns in the Patient table*//
                connect.SearchModelBook(txt_Model.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }

            else if (Department == 2)
            {
                connect.SelectTestDrive2();//*Selects the specified columns in the Patient table*//
                connect.SearchModelBook(txt_Model.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }
        }

        private void txt_SerialNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            if (Department == 1)
            {
                connect.SelectTestDrive();//*Selects the specified columns in the Patient table*//
                connect.SearchSerialBook(txt_SerialNo.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }

            else if (Department == 2)
            {
                connect.SelectTestDrive2();//*Selects the specified columns in the Patient table*//
                connect.SearchSerialBook(txt_SerialNo.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }
        }

        private void txt_Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            if (Department == 1)
            {
                connect.SelectTestDrive();//*Selects the specified columns in the Patient table*//
                connect.SearchPriceBook(txt_Price.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }

            else if (Department == 2)
            {
                connect.SelectTestDrive2();//*Selects the specified columns in the Patient table*//
                connect.SearchPriceBook(txt_Price.Text);//Searches the customer's 'name' within the populated table//
                DGV_TestDrive.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
            }
        }

        private void DGV_TestDrive_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                if (RoleType == "Administrator" || RoleType == "Manager")
                {
                    if (DGV_TestDrive.Items.IsEmpty)
                    {
                        BookDrive Book = new BookDrive();
                        Book.Department = Department;
                        Book_page.Navigate(Book);
                    }

                    else
                    {
                        Cbook = new ChangeBooking();
                        object item = DGV_TestDrive.SelectedItem;
                        Cbook.txt_BookNo.Text = (DGV_TestDrive.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                        ID = (DGV_TestDrive.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                        Cbook.ID = ID;
                        Cbook.Department = Department;
                        Book_page.Navigate(Cbook);
                    }
                }

                else
                {

                }
            }
            catch (Exception)
            {
                
            }
        }

        private void can_Show_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();
            try
            {
                if (Department == 1)
                {
                    connect.SelectTestDrive();
                    DGV_TestDrive.ItemsSource = connect.table.DefaultView;
                }

                else if (Department == 2)
                {
                    connect.SelectTestDrive2();
                    DGV_TestDrive.ItemsSource = connect.table2.DefaultView;
                }
            }

            catch (Exception)
            {
                
            }
        }

        private void can_Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection(); // refreshens the 'Connection' class // 

            try
            {
                connect.DeleteTestDrive(int.Parse(ID));
                if (Department == 1)
                {
                    connect.SelectTestDrive();
                    DGV_TestDrive.ItemsSource = connect.table.DefaultView;
                }

                else if (Department == 2)
                {
                    connect.SelectTestDrive2();
                    DGV_TestDrive.ItemsSource = connect.table2.DefaultView;
                }
            }

            catch (Exception)
            {                

            }
        }
	}
}