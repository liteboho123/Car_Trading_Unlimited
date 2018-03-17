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
	public partial class ViewOldVehicles
	{
        CTUConnection connect;
       
        UpdateOldVehicles upOld;
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


		public ViewOldVehicles()
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

		private void can_Show_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            connect = new CTUConnection();
            connect.SelectOldVehicle();
            DGV_Used_DemoCar.ItemsSource = connect.table.DefaultView;            
		}

        private const string defaultText = "Please enter brand name...."; //creating a defualt state for the textbox 'name'//
        private void txt_Brand_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Brand.Background = new SolidColorBrush(Colors.White);
            txt_Brand.Clear();
        }

        private void txt_Brand_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Brand.Text = txt_Brand.Text == string.Format(txt_Brand.Text) ? defaultText : txt_Brand.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText2 = "Please enter model...."; //creating a defualt state for the textbox 'name'//
        private void txt_Model_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Model.Background = new SolidColorBrush(Colors.White);
            txt_Model.Clear();
        }

        private void txt_Model_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Model.Text = txt_Model.Text == string.Format(txt_Model.Text) ? defaultText2 : txt_Model.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText3 = "Please enter serial no...."; //creating a defualt state for the textbox 'name'//
        private void txt_serial_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_serial.Background = new SolidColorBrush(Colors.White);
            txt_serial.Clear();
        }

        private void txt_serial_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_serial.Text = txt_serial.Text == string.Format(txt_serial.Text) ? defaultText3 : txt_serial.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText4 = "Please enter price..."; //creating a defualt state for the textbox 'name'//
        private void txt_Price_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Price.Background = new SolidColorBrush(Colors.White);
            txt_Price.Clear();
        }

        private void txt_Price_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Price.Text = txt_Price.Text == string.Format(txt_Price.Text) ? defaultText4 : txt_Price.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText5 = "Please enter color...."; //creating a defualt state for the textbox 'name'//
        private void txt_Color_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Color.Background = new SolidColorBrush(Colors.White);
            txt_Color.Clear();
        }

        private void txt_Color_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Color.Text = txt_Color.Text == string.Format(txt_Color.Text) ? defaultText5 : txt_Color.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private void txt_Brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectOldVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchOldBrand(txt_Brand.Text);//Searches the customer's 'name' within the populated table//
            DGV_Used_DemoCar.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_Model_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectOldVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchOldModel(txt_Model.Text);//Searches the customer's 'name' within the populated table//
            DGV_Used_DemoCar.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
        }

        private void txt_serial_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectOldVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchOldSerialNO(txt_serial.Text);//Searches the customer's 'name' within the populated table//
            DGV_Used_DemoCar.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
        }

        private void txt_Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectOldVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchOldPrice(txt_Price.Text);//Searches the customer's 'name' within the populated table//
            DGV_Used_DemoCar.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
        }

        private void txt_Color_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectOldVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchOldColor(txt_Color.Text);//Searches the customer's 'name' within the populated table//
            DGV_Used_DemoCar.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
        }

        private void can_Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection(); // refreshens the 'Connection' class // 

            try
            {
                connect.DeleteOldVehicle(int.Parse(ID));
                connect.SelectOldVehicle();
                DGV_Used_DemoCar.ItemsSource = connect.table.DefaultView;
            }

            catch (Exception)
            {

            }
        }

        private void DGV_Used_DemoCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                if (RoleType == "Administrator" || RoleType == "Manager")
                {
                    if (DGV_Used_DemoCar.Items.IsEmpty)
                    {
                        AddOldVehicles oldCar = new AddOldVehicles();
                        OldVehicle_page.Navigate(oldCar);
                    }

                    else
                    {
                        upOld = new UpdateOldVehicles();
                        object item = DGV_Used_DemoCar.SelectedItem;
                        upOld.txt_Brand.Text = (DGV_Used_DemoCar.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                        upOld.txt_Color.Text = (DGV_Used_DemoCar.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                        upOld.txt_Model.Text = (DGV_Used_DemoCar.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                        upOld.txt_Price.Text = (DGV_Used_DemoCar.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                        upOld.txt_serial.Text = (DGV_Used_DemoCar.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                        upOld.txt_Speed.Text = (DGV_Used_DemoCar.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text;
                        upOld.txt_serviceHis.Text = (DGV_Used_DemoCar.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text;

                        if ((DGV_Used_DemoCar.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text == "Used")
                        {
                            upOld.Rad_Used.IsChecked = true;
                        }

                        else if ((DGV_Used_DemoCar.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text == "Demo")
                        {
                            upOld.Rad_Demo.IsChecked = true;
                        }

                        if ((DGV_Used_DemoCar.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text == "Good")
                        {
                            upOld.Rad_Good.IsChecked = true;
                        }

                        else if ((DGV_Used_DemoCar.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text == "Average")
                        {
                            upOld.Rad_Average.IsChecked = true;
                        }

                        else if ((DGV_Used_DemoCar.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text == "Bad")
                        {
                            upOld.Rad_Bad.IsChecked = true;
                        }

                        ID = (DGV_Used_DemoCar.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                        upOld.ID = ID;


                        OldVehicle_page.Navigate(upOld);
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
	}
}