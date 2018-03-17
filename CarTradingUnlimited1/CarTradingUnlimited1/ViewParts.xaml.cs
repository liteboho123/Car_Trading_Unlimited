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
using System.IO;

namespace CarTradingUnlimited
{
	public partial class ViewParts
	{
        
        CTUConnection connect;
        UpdateParts upParts;
        AddParts addParts;

        public string RoleType
        {
            get;
            set;
        }

        public int Department
        {
            get;
            set;
        }

        public string ID
        {
            get;
            set;
        }

		public ViewParts()
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

		private void can_Quote_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow3.Opacity = 1;
		}

		private void can_Quote_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow3.Opacity = 0;
		}

        private void can_Quote_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            PrintQuote Quote = new PrintQuote();
            Quote.ShowDialog();
        }


        private void can_Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection(); // refreshens the 'Connection' class // 

            try
            {
                connect.DeleteParts(int.Parse(ID));
                connect.Selectparts();
                DGV_Parts.ItemsSource = connect.table.DefaultView;
            }

            catch (Exception)
            {

            }
        }

        private const string defaultText = "Please enter details...."; //creating a defualt state for the textbox 'name'//
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

        private const string defaultText2 = "Enter manufacturer...."; //creating a defualt state for the textbox 'name'//
        private void txt_Manufacturer_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Manufacturer.Background = new SolidColorBrush(Colors.White);
            txt_Manufacturer.Clear();
        }

        private void txt_Manufacturer_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Manufacturer.Text = txt_Manufacturer.Text == string.Format(txt_Manufacturer.Text) ? defaultText2 : txt_Manufacturer.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText3 = "Please enter price...."; //creating a defualt state for the textbox 'name'//
        private void txt_Price_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Price.Background = new SolidColorBrush(Colors.White);
            txt_Price.Clear();
        }

        private void txt_Price_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Price.Text = txt_Price.Text == string.Format(txt_Price.Text) ? defaultText3 : txt_Price.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private void txt_Brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.Selectparts();//*Selects the specified columns in the Patient table*//
            connect.SearchPartsBrand(txt_Brand.Text);//Searches the customer's 'name' within the populated table//
            DGV_Parts.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_Manufacturer_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.Selectparts();//*Selects the specified columns in the Patient table*//
            connect.SearchPartsManufact(txt_Manufacturer.Text);//Searches the customer's 'name' within the populated table//
            DGV_Parts.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void txt_Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            connect.Selectparts();//*Selects the specified columns in the Patient table*//
            connect.SearchPartsPrice(txt_Price.Text);//Searches the customer's 'name' within the populated table//
            DGV_Parts.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void can_Show_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            try
            {
                connect.Selectparts();
                DGV_Parts.ItemsSource = connect.table.DefaultView;
            }

            catch(Exception)
            {
 
            }
        }

        private void DGV_Parts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = DGV_Parts.SelectedItem;
                ID = (DGV_Parts.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

                if (RoleType == "Administrator" || RoleType == "Manager")
                {
                    if (DGV_Parts.Items.IsEmpty)
                    {
                        addParts = new AddParts();
                        Parts_page.Navigate(addParts);
                    }

                    else
                    {
                        upParts = new UpdateParts();
                        upParts.txt_Brand.Text = (DGV_Parts.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                        upParts.txt_Manufacturer.Text = (DGV_Parts.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                        upParts.txt_Price.Text = (DGV_Parts.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;                     
                        upParts.ID = ID;
                        upParts.Department = Department;

                        Parts_page.Navigate(upParts);
                    }
                }

                connect.SelectMotorPic(int.Parse(ID));
                byte[] data = (byte[])connect.set.Tables[0].Rows[0][1];
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
	}
}