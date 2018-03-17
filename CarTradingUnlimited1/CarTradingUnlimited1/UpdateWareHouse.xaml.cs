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
using System.Text.RegularExpressions;

namespace CarTradingUnlimited
{
	/// <summary>
	/// Interaction logic for UpdateWareHouse.xaml
	/// </summary>
	public partial class UpdateWareHouse : Window
	{
        CTUConnection connect;
        ViewWareHouse viewWare;
       

		public UpdateWareHouse()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
            txt_serial.MaxLength = 13;
		}

		private void can_Submit_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            connect = new CTUConnection();

            try
            {

                if (txt_serial.MaxLength != 13 || string.IsNullOrEmpty(txt_serial.Text))
                {
                    MessageBox.Show("Please enter a serial number for the vehicle");
                }

                else if (string.IsNullOrEmpty(txt_Brand.Text))
                {
                    MessageBox.Show("Please enter the serial number of the vehicle");
                }

                else if (string.IsNullOrEmpty(txt_Color.Text))
                {
                    MessageBox.Show("Please enter the color of vehicle");
                }

                else if (string.IsNullOrEmpty(txt_Model.Text))
                {
                    MessageBox.Show("Please enter the model of the vehicle");
                }

                else if (string.IsNullOrEmpty(txt_Price.Text))
                {
                    MessageBox.Show("Please enter a serial number for the vehicle");
                }

                else
                {
                    connect.UpdateWareHouseVehicles(txt_Brand.Text, txt_Model.Text, txt_serial.Text, txt_Color.Text, txt_Price.Text, Convert.ToDateTime(DTP_Year.SelectedDate.ToString()), int.Parse(cmbx_Ware.SelectedValue.ToString()));
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please select the date the vehicle was manufactured");
            }
		}		

		private void can_Submit_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 1;
		}
		
		private void can_Submit_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 0;
		}

		private void can_Clear_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            txt_Brand.Clear();
            txt_Color.Clear();
            txt_Model.Clear();
            txt_Price.Clear();
            txt_serial.Clear();
		}

		private void can_Clear_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow1.Opacity = 1;
		}

		private void can_Clear_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow1.Opacity = 0;
		}

		private void can_Back_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            this.Hide();
            viewWare = new ViewWareHouse();
            viewWare.Show();

		}

		private void can_Back_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow2.Opacity = 1;
		}

		private void can_Back_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow2.Opacity = 0;
		}

		private void cmbx_Ware_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
            connect.SelectcertainWareHouseVehicle(int.Parse(cmbx_Ware.SelectedValue.ToString()));
            txt_Brand.Text = connect.table.Rows[0][1].ToString();
            txt_Color.Text = connect.table.Rows[0][4].ToString();
            txt_Model.Text = connect.table.Rows[0][2].ToString();
            txt_Price.Text = connect.table.Rows[0][5].ToString();
            txt_serial.Text = connect.table.Rows[0][3].ToString();
            DTP_Year.DisplayDate = Convert.ToDateTime(connect.table.Rows[0][6].ToString());
			DOCK_AddWare.Visibility = Visibility.Visible;
		}

        private void NoText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Rec_Ware_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Window_WareHouse_Loaded(object sender, RoutedEventArgs e)
        {
            connect = new CTUConnection();
            connect.SelectWareHouseVehicle();
            cmbx_Ware.ItemsSource = connect.table.DefaultView;
            cmbx_Ware.DisplayMemberPath = "[Brand name]";
            cmbx_Ware.SelectedValuePath = "ID";
        }
	}
}