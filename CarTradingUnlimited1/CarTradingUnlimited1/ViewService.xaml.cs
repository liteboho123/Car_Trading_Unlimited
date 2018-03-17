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
	public partial class ViewService
	{
        CTUConnection connect;
        UpdateService upserv;
       

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
       

		public ViewService()
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
            connect.SelectCarService();
            DGV_Service.ItemsSource = connect.table.DefaultView;
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

        private const string defaultText2 = "Please enter name...."; //creating a defualt state for the textbox 'name'//
        private void txt_CustName_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_CustName.Background = new SolidColorBrush(Colors.White);
            txt_CustName.Clear();
        }

        private void txt_CustName_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_CustName.Text = txt_CustName.Text == string.Format(txt_CustName.Text) ? defaultText2 : txt_CustName.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText3 = "Please enter name...."; //creating a defualt state for the textbox 'name'//
        private void txt_MechName_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_MechName.Background = new SolidColorBrush(Colors.White);
            txt_MechName.Clear();
        }

        private void txt_MechName_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_MechName.Text = txt_MechName.Text == string.Format(txt_MechName.Text) ? defaultText3 : txt_MechName.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText4 = "Please enter details...."; //creating a defualt state for the textbox 'name'//
        private void txt_Prob_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Prob.Background = new SolidColorBrush(Colors.White);
            txt_Prob.Clear();
        }

        private void txt_Prob_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Prob.Text = txt_Prob.Text == string.Format(txt_Prob.Text) ? defaultText4 : txt_Prob.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText5 = "Please enter status...."; //creating a defualt state for the textbox 'name'//
        private void txt_Progress_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Progress.Background = new SolidColorBrush(Colors.White);
            txt_Progress.Clear();
        }

        private void txt_Progress_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Progress.Text = txt_Progress.Text == string.Format(txt_Progress.Text) ? defaultText5 : txt_Progress.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private void txt_Brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectCarService();//*Selects the specified columns in the Patient table*//
            connect.SearchServiceCar(txt_Brand.Text);//Searches the customer's 'name' within the populated table//
            DGV_Service.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_CustName_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectCarService();//*Selects the specified columns in the Patient table*//
            connect.SearchServiceCust(txt_CustName.Text);//Searches the customer's 'name' within the populated table//
            DGV_Service.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_MechName_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectCarService();//*Selects the specified columns in the Patient table*//
            connect.SearchServiceMech(txt_MechName.Text);//Searches the customer's 'name' within the populated table//
            DGV_Service.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_Prob_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectCarService();//*Selects the specified columns in the Patient table*//
            connect.SearchServiceProb(txt_Prob.Text);//Searches the customer's 'name' within the populated table//
            DGV_Service.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void txt_Progress_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectCarService();//*Selects the specified columns in the Patient table*//
            connect.SearchServiceProgress(txt_Progress.Text);//Searches the customer's 'name' within the populated table//
            DGV_Service.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//            
        }

        private void can_Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection(); // refreshens the 'Connection' class // 

            try
            {
                connect.DeleteCarService(int.Parse(ID));
                connect.SelectCarService();
                DGV_Service.ItemsSource = connect.table.DefaultView;
            }

            catch (Exception)
            {                

            }
        }

        private void DGV_Service_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                if (RoleType == "Administrator" || RoleType == "Manager")
                {
                    if(DGV_Service.Items.IsEmpty)
                    {
                        AddService adserv = new AddService();
                        Service_page.Navigate(adserv);
                    }

                    else
                    {
                    upserv = new UpdateService();
                    object item = DGV_Service.SelectedItem;
                    upserv.txt_CustCar.Text = (DGV_Service.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                    upserv.txt_Prob.Text = (DGV_Service.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                    if ((DGV_Service.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text == "On hold")
                    {
                        upserv.Rad_Hold.IsChecked = true;
                    }

                    else if ((DGV_Service.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text == "In process")
                    {
                        upserv.Rad_Process.IsChecked = true;
                    }

                    else if ((DGV_Service.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text == "Completed")
                    {
                        upserv.Rad_Done.IsChecked = true;
                    }                   
                    ID = (DGV_Service.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    upserv.ID = ID;

                    Service_page.Navigate(upserv);
                    }
                }

                else
                {

                }
            }
            catch (ArgumentNullException)
            {
                
            }
        }
	}
}