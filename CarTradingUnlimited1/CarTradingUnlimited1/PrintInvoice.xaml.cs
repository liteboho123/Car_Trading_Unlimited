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
using System.IO;

namespace CarTradingUnlimited
{
	public partial class PrintInvoice
	{
		ViewInvoice viewinvoice;
		IssueInvoice AddInvoice;
        CTUConnection connect;

        public FlowDocument flwdoc;
        PrintDialog pd;
        TextRange sourc;
        MemoryStream str;
        FlowDocument flwDocCopy;
        TextRange sourc2;

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
		
		public PrintInvoice()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void Can_AddInvoice_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Visible;		
			elipse_AddInvoice.Opacity = 0.75;
			
			TxtBlk_AddInvoice.Foreground = new SolidColorBrush(Colors.White);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddInvoice.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);			
			
			sb1.Begin();
		}

		private void Can_AddInvoice_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Collapsed;
			elipse_AddInvoice.Opacity = 1;	
			
			TxtBlk_AddInvoice.Foreground = new SolidColorBrush(Colors.Black);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddInvoice.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1.1, 1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);
			
			sb1.Stop();
		}

		private void Can_AddInvoice_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			viewinvoice = new ViewInvoice();
            AddInvoice = new IssueInvoice();
            connect = new CTUConnection();
            

            viewinvoice.Invoice_page = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && viewinvoice.Invoice_page == null)
            {
                viewinvoice.Invoice_page = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            if (viewinvoice.Invoice_page != null)
            {
                try
                {
                    if (Department == 1)
                    {
                        AddInvoice.Stck_Prob.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Parts.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Mech.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Price.Visibility = Visibility.Collapsed;

                        connect.SelectNewVehicle();
                        AddInvoice.cmbx_Car.ItemsSource = connect.table.DefaultView;
                        AddInvoice.cmbx_Car.DisplayMemberPath = "Model";
                        AddInvoice.cmbx_Car.SelectedValuePath = "ID";

                        connect.SelectInvoiceCustomer2();
                        AddInvoice.cmbx_Cust.ItemsSource = connect.table2.DefaultView;
                        AddInvoice.cmbx_Cust.DisplayMemberPath = "[Name]";
                        AddInvoice.cmbx_Cust.SelectedValuePath = "ID";

                        connect.SelectInvoiceEmployeeSalesMen();
                        AddInvoice.cmbx_SalesMan.ItemsSource = connect.table3.DefaultView;
                        AddInvoice.cmbx_SalesMan.DisplayMemberPath = "[EmName]";
                        AddInvoice.cmbx_SalesMan.SelectedValuePath = "ID";


                    }

                    else if (Department == 2)
                    {
                        AddInvoice.Stck_Prob.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Parts.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Mech.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Price.Visibility = Visibility.Collapsed;

                        connect.SelectOldVehicle();
                        AddInvoice.cmbx_Car.ItemsSource = connect.table.DefaultView;
                        AddInvoice.cmbx_Car.DisplayMemberPath = "Model";
                        AddInvoice.cmbx_Car.SelectedValuePath = "ID";

                        connect.SelectInvoiceCustomer2();
                        AddInvoice.cmbx_Cust.ItemsSource = connect.table2.DefaultView;
                        AddInvoice.cmbx_Cust.DisplayMemberPath = "[Name]";
                        AddInvoice.cmbx_Cust.SelectedValuePath = "ID";

                        connect.SelectInvoiceEmployeeSalesMen();
                        AddInvoice.cmbx_SalesMan.ItemsSource = connect.table3.DefaultView;
                        AddInvoice.cmbx_SalesMan.DisplayMemberPath = "[EmName]";
                        AddInvoice.cmbx_SalesMan.SelectedValuePath = "ID";
                    }

                    else if (Department == 3)
                    {
                        AddInvoice.Stck_Car.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Parts.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Sales.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Serv.Visibility = Visibility.Collapsed;


                        connect.SelectInvoiceCustomer2();
                        AddInvoice.cmbx_Cust.ItemsSource = connect.table2.DefaultView;
                        AddInvoice.cmbx_Cust.DisplayMemberPath = "[Name]";
                        AddInvoice.cmbx_Cust.SelectedValuePath = "ID";

                        connect.SelectInvoiceEmployeeMech();
                        AddInvoice.cmbx_Mech.ItemsSource = connect.table3.DefaultView;
                        AddInvoice.cmbx_Mech.DisplayMemberPath = "[EmName]";
                        AddInvoice.cmbx_Mech.SelectedValuePath = "ID";

                    }

                    else if (Department == 4)
                    {
                        AddInvoice.Stck_Car.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Sales.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Mech.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Serv.Visibility = Visibility.Collapsed;
                        AddInvoice.Stck_Price.Visibility = Visibility.Collapsed;

                        connect.SelectInvoiceCustomer2();
                        AddInvoice.cmbx_Cust.ItemsSource = connect.table2.DefaultView;
                        AddInvoice.cmbx_Cust.DisplayMemberPath = "[Name]";
                        AddInvoice.cmbx_Cust.SelectedValuePath = "ID";

                        connect.Selectparts();
                        AddInvoice.cmbx_Parts.ItemsSource = connect.table.DefaultView;
                        AddInvoice.cmbx_Parts.DisplayMemberPath = "Details";
                        AddInvoice.cmbx_Parts.SelectedValuePath = "ID";
                    }

                    AddInvoice.Department = Department;
                    viewinvoice.Invoice_page.Navigate(AddInvoice);
                }

                catch (Exception)
                {
 
                }
            }
		}

		private void can_Print_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            pd = new PrintDialog();
            sourc = new TextRange(RICH_Invoice.Document.ContentStart, RICH_Invoice.Document.ContentEnd);
            str = new MemoryStream();
            sourc.Save(str, DataFormats.Xaml);
            flwDocCopy = new FlowDocument();
            sourc2 = new TextRange(flwDocCopy.ContentStart, flwDocCopy.ContentEnd);
            sourc2.Load(str, DataFormats.Xaml);            

            if (pd.ShowDialog() == true)
            {
                pd.PrintVisual(RICH_Invoice as Visual, "Print Invoice");
            }
		}

		private void can_Print_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 1;
		}

		private void can_Print_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow.Opacity = 0;
		}
		
	}
}