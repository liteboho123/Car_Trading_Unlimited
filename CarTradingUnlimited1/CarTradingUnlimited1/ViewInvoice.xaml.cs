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
    public partial class ViewInvoice
    {
        PrintInvoice prtInv;
        CTUConnection connect;
        IssueInvoice issInv;

        public string ID
        {
            get;
            set;
        }

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

        public ViewInvoice()
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


        private void can_Show_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            if (Department == 1)
            {
                connect.SelectInvoiceNewVehicle();
                DGV_Invoice.ItemsSource = connect.table.DefaultView;
            }

            else if (Department == 2)
            {
                connect.SelectInvoiceOldVehicle();
                DGV_Invoice.ItemsSource = connect.table.DefaultView;
            }

            else if (Department == 3)
            {
                connect.SelectInvoiceService();
                DGV_Invoice.ItemsSource = connect.table.DefaultView;
            }

            else if (Department == 4)
            {
                connect.SelectInvoiceParts();
                DGV_Invoice.ItemsSource = connect.table.DefaultView;
            }

        }

        private void can_Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'Connection' class // 

            try
            {
                connect.DeleteInvoice(int.Parse(ID));
                if (Department == 1)
                {
                    connect.SelectInvoiceNewVehicle();
                    DGV_Invoice.ItemsSource = connect.table.DefaultView;
                }

                else if (Department == 2)
                {
                    connect.SelectInvoiceOldVehicle();
                    DGV_Invoice.ItemsSource = connect.table.DefaultView;
                }

                else if (Department == 3)
                {
                    connect.SelectInvoiceService();
                    DGV_Invoice.ItemsSource = connect.table.DefaultView;
                }

                else if (Department == 4)
                {
                    connect.SelectInvoiceParts();
                    DGV_Invoice.ItemsSource = connect.table.DefaultView;
                }              
              
            }

            catch (Exception)
            {

            }
        }

        private void DGV_Invoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                prtInv = new PrintInvoice();
                object item = DGV_Invoice.SelectedItem;
                prtInv.flwdoc = new FlowDocument();
                prtInv.flwdoc.Blocks.Add(new Paragraph(new Run("Service Plan: " +(DGV_Invoice.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text.ToString())));
                prtInv.flwdoc.Blocks.Add(new Paragraph(new Run((DGV_Invoice.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text.ToString())));
                prtInv.flwdoc.Blocks.Add(new Paragraph(new Run("Date issued: " + (DGV_Invoice.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text.ToString())));
                prtInv.flwdoc.Blocks.Add(new Paragraph(new Run((DGV_Invoice.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text.ToString())));
                prtInv.flwdoc.Blocks.Add(new Paragraph(new Run((DGV_Invoice.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text.ToString())));
                prtInv.flwdoc.Blocks.Add(new Paragraph(new Run((DGV_Invoice.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text.ToString())));
                prtInv.flwdoc.Blocks.Add(new Paragraph(new Run((DGV_Invoice.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text.ToString())));
                prtInv.flwdoc.Blocks.Add(new Paragraph(new Run((DGV_Invoice.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text.ToString())));
                

                prtInv.RICH_Invoice.Document = prtInv.flwdoc;
                prtInv.Department = Department;

                if (RoleType == "SalesMan" || RoleType == "Mechanic" || RoleType == "Surbordinate")
                {
                    prtInv.Can_AddInvoice.Visibility = Visibility.Collapsed;
                    Invoice_page.Navigate(prtInv);
                }

                else
                {
                    if (DGV_Invoice.Items.IsEmpty)
                    {
                        issInv = new IssueInvoice();
                        Invoice_page.Navigate(issInv);
                    }

                    else
                    {
                        prtInv.Department = Department;
                        Invoice_page.Navigate(prtInv);
                    }
                }

            }
            catch (Exception)
            {
                
            }
        }

        private const string defaultText = "Please enter name...."; //creating a defualt state for the textbox 'name'//
        private void txt_Cust_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Cust.Background = new SolidColorBrush(Colors.White);
            txt_Cust.Clear();
        }

        private void txt_Cust_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Cust.Text = txt_Cust.Text == string.Format(txt_Cust.Text) ? defaultText : txt_Cust.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText2 = "Please enter brand name...."; //creating a defualt state for the textbox 'name'//
        private void txt_Vehicle_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Vehicle.Background = new SolidColorBrush(Colors.White);
            txt_Vehicle.Clear();
        }

        private void txt_Vehicle_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Vehicle.Text = txt_Vehicle.Text == string.Format(txt_Vehicle.Text) ? defaultText2 : txt_Vehicle.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText3 = "Please enter parts name...."; //creating a defualt state for the textbox 'name'//
        private void txt_Parts_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Parts.Background = new SolidColorBrush(Colors.White);
            txt_Parts.Clear();
        }

        private void txt_Parts_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_Parts.Text = txt_Parts.Text == string.Format(txt_Parts.Text) ? defaultText3 : txt_Parts.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private const string defaultText4 = "Please enter service...."; //creating a defualt state for the textbox 'name'//
        private void txt_ServPlan_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_ServPlan.Background = new SolidColorBrush(Colors.White);
            txt_ServPlan.Clear();
        }

        private void txt_ServPlan_LostFocus(object sender, RoutedEventArgs e)
        {
            txt_ServPlan.Text = txt_ServPlan.Text == string.Format(txt_ServPlan.Text) ? defaultText4 : txt_ServPlan.Text;//Changing the text of the text box 'name' to default//
            sb1.Begin();
        }

        private void Page_Invoice_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void txt_Cust_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            try
            {
                if (Department == 1)
                {
                    connect.SelectInvoiceNewVehicle();//*Selects the specified columns in the Patient table*//
                    connect.SearchInvoiceCustomer(txt_Cust.Text);//Searches the customer's 'name' within the populated table//
                    DGV_Invoice.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//   
                }

                else if (Department == 2)
                {
                    connect.SelectInvoiceOldVehicle();//*Selects the specified columns in the Patient table*//
                    connect.SearchInvoiceCustomer(txt_Cust.Text);//Searches the customer's 'name' within the populated table//
                    DGV_Invoice.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//   
                }

                else if (Department == 3)
                {
                    connect.SelectInvoiceService();//*Selects the specified columns in the Patient table*//
                    connect.SearchInvoiceCustomer(txt_Cust.Text);//Searches the customer's 'name' within the populated table//
                    DGV_Invoice.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//   
                }

                else if (Department == 4)
                {
                    connect.Selectparts();//*Selects the specified columns in the Patient table*//
                    connect.SearchInvoiceCustomer(txt_Cust.Text);//Searches the customer's 'name' within the populated table//
                    DGV_Invoice.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//   
                }
            }

            catch (Exception)
            {

            }
        }

        private void txt_Vehicle_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            try
            {
                if (Department == 1)
                {
                    connect.SelectInvoiceNewVehicle();//*Selects the specified columns in the Patient table*//
                    connect.SearchInvoiceVehicle(txt_Vehicle.Text);//Searches the customer's 'name' within the populated table//
                    DGV_Invoice.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//   
                }

                else if (Department == 2)
                {
                    connect.SelectInvoiceOldVehicle();//*Selects the specified columns in the Patient table*//
                    connect.SearchInvoiceVehicle(txt_Vehicle.Text);//Searches the customer's 'name' within the populated table//
                    DGV_Invoice.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//   
                }
            }

            catch (Exception)
            {

            }

        }

        private void txt_Parts_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            try
            {
                if (Department == 4)
                {
                    connect.SelectInvoiceNewVehicle();//*Selects the specified columns in the Patient table*//
                    connect.SearchInvoiceCustomer(txt_Cust.Text);//Searches the customer's 'name' within the populated table//
                    DGV_Invoice.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//   
                }
            }

            catch (Exception)
            {

            }
        }

        private void txt_ServPlan_TextChanged(object sender, TextChangedEventArgs e)
        {
            connect = new CTUConnection();// refreshens the 'CTUConnection' class //
            try
            {
                if (Department == 3)
                {
                    connect.SelectInvoiceNewVehicle();//*Selects the specified columns in the Patient table*//
                    connect.SearchInvoiceCustomer(txt_Cust.Text);//Searches the customer's 'name' within the populated table//
                    DGV_Invoice.ItemsSource = connect.dataset;//*All the selected fields are filtered inside the table and stored inside the grid-view*//   
                }
            }

            catch (Exception)
            {

            }
        }
    }
}