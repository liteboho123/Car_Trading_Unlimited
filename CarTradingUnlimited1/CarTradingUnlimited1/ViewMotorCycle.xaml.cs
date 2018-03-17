using System;
using System.Collections.Generic;
using System.IO;
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
	public partial class ViewMotorCycle
	{
        CTUConnection connect;
        UpdateMotorCycle upMoto;
        AddMotorCycle addmoto;

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

		public ViewMotorCycle()
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
        private void txt_Brand1_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Brand1.Background = new SolidColorBrush(Colors.White);
            txt_Brand1.Clear();
        }

        private void txt_Brand1_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Brand1.Text = txt_Brand1.Text == string.Format(txt_Brand1.Text) ? defaultText2 : txt_Brand1.Text;//Changing the text of the text box 'name' to default//
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

        private const string defaultText3 = "Please enter color...."; //creating a defualt state for the textbox 'name'//
        private void txt_Color_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Color.Background = new SolidColorBrush(Colors.White);
            txt_Color.Clear();
        }

        private void txt_Color_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Color.Text = txt_Color.Text == string.Format(txt_Color.Text) ? defaultText3 : txt_Color.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText4 = "Please enter price...."; //creating a defualt state for the textbox 'name'//
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

        private const string defaultText5 = "Please enter date...."; //creating a defualt state for the textbox 'name'//
        private void txt_Date_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Date.Background = new SolidColorBrush(Colors.White);
            txt_Date.Clear();
        }

        private void txt_Date_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Date.Text = txt_Date.Text == string.Format(txt_Date.Text) ? defaultText5 : txt_Date.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private void txt_Brand1_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectMotor();//*Selects the specified columns in the Patient table*//
            connect.SearchMotoBrand(txt_Brand1.Text);//Searches the customer's 'name' within the populated table//
            DGV_Moto.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_Model_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectMotor();//*Selects the specified columns in the Patient table*//
            connect.SearchMotoModel(txt_Model.Text);//Searches the customer's 'name' within the populated table//
            DGV_Moto.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_Color_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectMotor();//*Selects the specified columns in the Patient table*//
            connect.SearchMotoColor(txt_Color.Text);//Searches the customer's 'name' within the populated table//
            DGV_Moto.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectMotor();//*Selects the specified columns in the Patient table*//
            connect.SearchMotoPrice(txt_Price.Text);//Searches the customer's 'name' within the populated table//
            DGV_Moto.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_Date_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.SelectMotor();//*Selects the specified columns in the Patient table*//
            connect.SearchMotoYear(txt_Date.Text);//Searches the customer's 'name' within the populated table//
            DGV_Moto.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void DGV_Moto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = DGV_Moto.SelectedItem;
                ID = (DGV_Moto.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

                if (RoleType == "Administrator" || RoleType == "Manager")
                {
                    if (DGV_Moto.Items.IsEmpty)
                    {
                        addmoto = new AddMotorCycle();
                        Moto_page.Navigate(addmoto);
                    }

                    else
                    {
                        upMoto = new UpdateMotorCycle();
                        upMoto.txt_Brand.Text = (DGV_Moto.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                        upMoto.txt_Model.Text = (DGV_Moto.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                        upMoto.txt_Color.Text = (DGV_Moto.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                        upMoto.txt_Price.Text = (DGV_Moto.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                        upMoto.ID = ID;
                        upMoto.Department = Department;

                        Moto_page.Navigate(upMoto);
                    }
                }

                connect.SelectMotorPic(int.Parse(ID));
                byte[] data =(byte[])connect.set.Tables[0].Rows[0][1];
                MemoryStream strm = new MemoryStream();
                strm.Write(data, 0, data.Length);
                strm.Position = 0;

                System.Drawing.Image imgs = System.Drawing.Image.FromStream(strm);
                BitmapImage bi = new BitmapImage();

                bi.BeginInit();
                MemoryStream ms = new MemoryStream();

                imgs.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                strm.Seek(0, SeekOrigin.Begin);

                bi.StreamSource = strm;
                bi.EndInit();
                im.Source = bi;
            }
            catch (Exception)
            {
               
            }
        }

        private void can_Show_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();
            connect.SelectMotor();
            DGV_Moto.ItemsSource = connect.table.DefaultView;
        }

        private void can_Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection(); // refreshens the 'Connection' class // 

            try
            {
                connect.DeleteMoto(int.Parse(ID));
                connect.SelectMotor();
                DGV_Moto.ItemsSource = connect.table.DefaultView;
            }

            catch (Exception)
            {                

            }
        }

        
	}
}