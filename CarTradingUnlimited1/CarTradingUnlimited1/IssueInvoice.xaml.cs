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
	public partial class IssueInvoice
	{
        CTUConnection connect;

		public string ServicePlan
		{
			get;
			set;
		}

        public int Department
        {
            get;
            set;
        }
		
		public IssueInvoice()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void Rad_Yes_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Rad_Yes.Foreground = new SolidColorBrush(Colors.Red);
			Rad_No.Foreground = new SolidColorBrush(Colors.GreenYellow);
			ServicePlan = "Yes";
		}

		private void Rad_No_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Rad_Yes.Foreground = new SolidColorBrush(Colors.GreenYellow);
			Rad_No.Foreground = new SolidColorBrush(Colors.Red);
			ServicePlan = "No";
		}

		private void NoText(object sender, System.Windows.Input.TextCompositionEventArgs e)
		{
			Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
		}

		private void cmbx_Cust_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			DOCK_IssueInvoice.Visibility = Visibility.Visible;
		}			

		private void can_Submit_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            connect = new CTUConnection();

            try
            {
                if (Department == 1)
                {
                    connect.GetInvoiceNewCar(int.Parse(cmbx_SalesMan.SelectedValue.ToString()), ServicePlan, Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), int.Parse(cmbx_Cust.SelectedValue.ToString()), int.Parse(cmbx_Car.SelectedValue.ToString()));
                }

                else if (Department == 2)
                {
                    connect.GetInvoiceOldCar(int.Parse(cmbx_Car.SelectedValue.ToString()), ServicePlan, Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), int.Parse(cmbx_Cust.SelectedValue.ToString()), int.Parse(cmbx_Car.SelectedValue.ToString()));
                }

                else if (Department == 3)
                {

                    connect.GetInvoiceServiceCar(int.Parse(cmbx_Mech.SelectedValue.ToString()), txt_Price.Text, Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), int.Parse(cmbx_Cust.SelectedValue.ToString()), txt_Prob.Text);
                }

                else if (Department == 4)
                {
                    connect.GetInvoiceParts(Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), int.Parse(cmbx_Cust.SelectedValue.ToString()), int.Parse(cmbx_Parts.SelectedValue.ToString()));
                }
            }

            catch (Exception)
            {
                
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

        private void Page_Invoice_Loaded(object sender, RoutedEventArgs e)
        {
            connect = new CTUConnection();

            try
            {
                
            }

            catch (Exception)
            {

            }
        }
	}
}