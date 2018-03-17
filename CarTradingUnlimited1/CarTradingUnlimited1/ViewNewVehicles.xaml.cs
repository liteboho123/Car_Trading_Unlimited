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
	public partial class ViewNewVehicles
	{
        
        UpdateNewVehicle upNewCars;
        CTUConnection connect;
        MainWindow main;

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
       

		public ViewNewVehicles()
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
        private void txt_Serial_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Serial.Background = new SolidColorBrush(Colors.White);
            txt_Serial.Clear();
        }

        private void txt_Serial_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Serial.Text = txt_Serial.Text == string.Format(txt_Serial.Text) ? defaultText3 : txt_Serial.Text;//Changing the text of the text box 'name' to default//
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

        private void DGV_NewCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                if (RoleType == "Administrator" || RoleType == "Manager")
                {
                    if(DGV_NewCars.Items.IsEmpty)
                    {
                        AddNewVehicles VnewCar = new AddNewVehicles();
                        NVehicle_page.Navigate(VnewCar);
                    }
                    else
                    {
                    upNewCars = new UpdateNewVehicle();
                    object item = DGV_NewCars.SelectedItem;
                    upNewCars.txt_Brand.Text = (DGV_NewCars.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                    upNewCars.txt_Color.Text = (DGV_NewCars.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                    upNewCars.txt_Model.Text = (DGV_NewCars.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                    upNewCars.txt_Price.Text = (DGV_NewCars.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                    upNewCars.txt_serial.Text = (DGV_NewCars.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;                   
                    ID = (DGV_NewCars.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    upNewCars.ID = ID;

                    NVehicle_page.Navigate(upNewCars);
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

        private void can_Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection(); // refreshens the 'Connection' class // 

            try
            {
                connect.DeleteNewVehicle(int.Parse(ID));
                connect.SelectNewVehicle();
                DGV_NewCars.ItemsSource = connect.table.DefaultView;
            }

            catch (Exception)
            {                

            }
        }

        private void can_Show_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();
            connect.SelectNewVehicle();
            DGV_NewCars.ItemsSource = connect.table.DefaultView;
        }

        private void txt_Brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectNewVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchNewBrand(txt_Brand.Text);//Searches the customer's 'name' within the populated table//
            DGV_NewCars.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_Model_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectNewVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchNewModel(txt_Model.Text);//Searches the customer's 'name' within the populated table//
            DGV_NewCars.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
        }

        private void txt_Serial_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectNewVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchNewSerialNO(txt_Serial.Text);//Searches the customer's 'name' within the populated table//
            DGV_NewCars.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
        }

        private void txt_Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectNewVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchNewPrice(txt_Price.Text);//Searches the customer's 'name' within the populated table//
            DGV_NewCars.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
        }

        private void txt_Color_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectNewVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchNewColor(txt_Color.Text);//Searches the customer's 'name' within the populated table//
            DGV_NewCars.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*// 
        }

        private void can_WareHouse_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glow2.Opacity = 1;
        }

        private void can_WareHouse_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glow2.Opacity = 0;
        }

        private void can_WareHouse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            main = new MainWindow();
            main.Visibility = Visibility.Collapsed;
            ViewWareHouse viewWare = new ViewWareHouse();
            viewWare.can_Delete.Visibility = Visibility.Collapsed;
            viewWare.can_AddWarehouse.Visibility = Visibility.Collapsed;
            viewWare.can_UpdateWarehouse.Visibility = Visibility.Collapsed;
            viewWare.can_btn.Visibility = Visibility.Collapsed;
            viewWare.Btn_Close.Visibility = Visibility.Collapsed;
            viewWare.can_Back.Visibility = Visibility.Visible;            
            viewWare.ShowDialog();
        }
	}
}