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
using System.Windows.Media.Animation;

namespace CarTradingUnlimited
{
	public partial class UpdateCustomer
	{
        ViewCustomer cust;
        AddCustomer addCust;
        CTUConnection connect;

        public string ID
        {
            get;
            set;
        }

		public UpdateCustomer()
		{
			this.InitializeComponent();
			// Insert code required on object creation below this point.
            txt_BankNo.MaxLength = 18;
            txt_IDnumber.MaxLength = 13;
		}

		private void can_Submit_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 1;
		}

		private void can_Submit_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 0;
		}		

		private void Can_AddCust_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Visible;		
			elipse_AddCust.Opacity = 0.75;
			
			TxtBlk_AddCust.Foreground = new SolidColorBrush(Colors.White);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddCust.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);			
			
			sb1.Begin();
		}

		private void Can_AddCust_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Collapsed;
			elipse_AddCust.Opacity = 1;	
			
			TxtBlk_AddCust.Foreground = new SolidColorBrush(Colors.Black);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddCust.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1.1, 1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);
			
			sb1.Stop();
		}

		private void can_Clear_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow1.Opacity = 1;
		}

		private void can_Clear_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow1.Opacity = 0;
		}

		private void Can_AddCust_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            cust = new ViewCustomer();
            addCust = new AddCustomer();

            cust.Cust_page = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && cust.Cust_page == null)
            {
                cust.Cust_page = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            if (cust.Cust_page != null)
            {
                cust.Cust_page.Source = new Uri("AddCustomer.xaml", UriKind.Relative);
            }
		}

        private void can_Clear_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txt_Firstname.Clear();
            txt_Surname.Clear();
            txt_Username.Clear();
            txt_Password.Clear();
            txt_BankNo.Clear();
            txt_IDnumber.Clear();
        }

        private void can_Submit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            if (txt_BankNo.MaxLength != 18 || string.IsNullOrEmpty(txt_BankNo.Text))
            {
                MessageBox.Show("Make sure the bank account number is correct");
            }

            else if (string.IsNullOrEmpty(txt_Firstname.Text))
            {
                MessageBox.Show("Please enter the firstname of the customer");
            }

            else if (txt_IDnumber.MaxLength != 13 || string.IsNullOrEmpty(txt_IDnumber.Text))
            {
                MessageBox.Show("Please enter the ID number of the customer");
            }

            else if (string.IsNullOrEmpty(txt_Surname.Text))
            {
                MessageBox.Show("Please enter the surname of the customer");
            }

            else if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Please enter the password of the customer");
            }

            else
            {
                connect.UpdateCustomer(txt_Username.Text, txt_Password.Text, txt_Firstname.Text, txt_Surname.Text, txt_IDnumber.Text, txt_BankNo.Text, int.Parse(ID));
            }
        }        
	}
}