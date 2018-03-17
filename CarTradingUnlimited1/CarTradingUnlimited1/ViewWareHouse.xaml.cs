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
	/// <summary>
	/// Interaction logic for ViewWareHouse.xaml
	/// </summary>
	public partial class ViewWareHouse : Window
	{
		AddWareHouse AddWare;
        UpdateWareHouse UpWare;      
        LoginWindow log;
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

        public string RoleType
        {
            get;
            set;
        }       

		public ViewWareHouse()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
            
		}

		private void can_Show_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            connect = new CTUConnection();
            connect.SelectWareHouseVehicle();
            DGV_Warehouse.ItemsSource = connect.table.DefaultView;
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

		private void can_Delete_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            connect = new CTUConnection(); // refreshens the 'Connection' class // 

            try
            {
                connect.DeleteWareHouseVehicle(int.Parse(ID));
                connect.SelectWareHouseVehicle();
                DGV_Warehouse.ItemsSource = connect.table.DefaultView;
            }

            catch (Exception)
            {                

            }
		}

		private void can_AddWarehouse_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{			
			this.Hide();
			AddWare = new AddWareHouse();
			AddWare.Show();
		}

		private void can_AddWarehouse_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow2.Opacity = 1;
		}

		private void can_AddWarehouse_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow2.Opacity = 0;
		}

		private void can_UpdateWarehouse_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			this.Hide();
			UpWare = new UpdateWareHouse();           
			UpWare.Show();
		}

		private void can_UpdateWarehouse_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow3.Opacity = 1;
		}

		private void can_UpdateWarehouse_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow3.Opacity = 0;
		}

        private void can_Back_MouseDown(object sender, MouseButtonEventArgs e)
        {           
            this.Hide();
        }

        private void can_Back_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glow4.Opacity = 1;
        }

        private void can_Back_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glow4.Opacity = 0;
        }

        private void DGV_Warehouse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                if (RoleType == "Administrator" || RoleType == "Manager")
                {                  
                    object item = DGV_Warehouse.SelectedItem;                     
                    ID = (DGV_Warehouse.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                }

                else 
                {
                    
                }
            }
            catch (ArgumentOutOfRangeException f)
            {
                MessageBox.Show(f.Message);
            }
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

        private void Btn_Close_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.Close();
        }

        private void can_btn_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	this.glow5.Opacity = 1;
			TxtBlk_LogOut.Foreground = new SolidColorBrush(Colors.White);
        }

        private void can_btn_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	this.glow5.Opacity = 0;
			TxtBlk_LogOut.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void can_btn_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	log = new LoginWindow();
			
            MessageBoxResult result = MessageBox.Show("Are you sure you want to log-out?", "Log out", MessageBoxButton.YesNo, MessageBoxImage.Question); //Display a message-dialog which renders a 'Yes' and a 'No' button//
            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Hide();
                    log.Show();
                    break;

                case MessageBoxResult.No:
                    break;
            }
        }

        private void Rec_Ware_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	 if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void txt_Brand_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        	connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectWareHouseVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchWareHouseBrand(txt_Brand.Text);//Searches the customer's 'name' within the populated table//
            DGV_Warehouse.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_Model_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        	connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectWareHouseVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchWareHouseModel(txt_Model.Text);//Searches the customer's 'name' within the populated table//
            DGV_Warehouse.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_Serial_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        	connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectWareHouseVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchWareHouseSerialNO(txt_Brand.Text);//Searches the customer's 'name' within the populated table//
            DGV_Warehouse.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_Price_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        	connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectWareHouseVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchWareHousePrice(txt_Price.Text);//Searches the customer's 'name' within the populated table//
            DGV_Warehouse.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_Color_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        	connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectWareHouseVehicle();//*Selects the specified columns in the Patient table*//
            connect.SearchWareHouseColor(txt_Color.Text);//Searches the customer's 'name' within the populated table//
            DGV_Warehouse.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void Btn_Close_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	this.Btn_Close.Opacity = .7;
        }

        private void Btn_Close_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	this.Btn_Close.Opacity = 1;
        }
	}
}