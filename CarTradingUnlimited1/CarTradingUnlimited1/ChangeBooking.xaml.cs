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
using System.Text.RegularExpressions;

namespace CarTradingUnlimited
{
    public partial class ChangeBooking
    {
        CTUConnection connect;
        ViewBooking ViewBook;
        BookDrive AddBook;


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
        

        public ChangeBooking()
        {
            this.InitializeComponent();

            // Insert code required on object creation below this point.         
        }

        string Type
        {
            get;
            set;
        }

        private void can_Submit_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.glow.Opacity = 1;
        }

        private void can_Submit_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.glow.Opacity = 0;
        }

        private void can_Clear_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.glow1.Opacity = 1;
        }

        private void can_Clear_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.glow1.Opacity = 0;
        }

        private void Can_AddDrive_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Can_Circles.Visibility = Visibility.Visible;
            elipse_AddDrive.Opacity = 0.75;

            TxtBlk_AddDrive.Foreground = new SolidColorBrush(Colors.White);

            ScaleTransform trans = new ScaleTransform();

            TxtBlk_AddDrive.RenderTransform = trans;

            DoubleAnimation anim = new DoubleAnimation(1, 1.1, TimeSpan.FromSeconds(0));

            trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
            trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);

            sb1.Begin();
        }

        private void Can_AddDrive_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Can_Circles.Visibility = Visibility.Collapsed;
            elipse_AddDrive.Opacity = 1;

            TxtBlk_AddDrive.Foreground = new SolidColorBrush(Colors.Black);

            ScaleTransform trans = new ScaleTransform();

            TxtBlk_AddDrive.RenderTransform = trans;

            DoubleAnimation anim = new DoubleAnimation(1.1, 1, TimeSpan.FromSeconds(0));

            trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
            trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);

            sb1.Stop();
        }

        private void Can_AddDrive_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ViewBook = new ViewBooking();
            AddBook = new BookDrive();

            ViewBook.Book_page = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && ViewBook.Book_page == null)
            {
                ViewBook.Book_page = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            if (ViewBook.Book_page != null)
            {
                AddBook.Department = Department;
                ViewBook.Book_page.Navigate(AddBook);
            }
        }

        private void NoText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            connect = new CTUConnection();
            connect.SelectCustomerBooking();
            cmbx_Cust.ItemsSource = connect.table.DefaultView;
            cmbx_Cust.DisplayMemberPath = "[Name of the customer]";
            cmbx_Cust.SelectedValuePath = "ID";
        }

        private void Rad_New_Click(object sender, RoutedEventArgs e)
        {
            Type = "New"; //Set the string "Type" variable Text to "New"//            

            Rad_New.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Used.Foreground = new SolidColorBrush(Colors.Black);
            Rad_Demo.Foreground = new SolidColorBrush(Colors.Black);

            connect = new CTUConnection();
            connect.SelectNewDrive();
            cmbx_Vehicle.ItemsSource = connect.table2.DefaultView;
            cmbx_Vehicle.DisplayMemberPath = "[Name of vehicle]";
            cmbx_Vehicle.SelectedValuePath = "ID";

        }

        private void Rad_Used_Click(object sender, RoutedEventArgs e)
        {
            Type = "Used"; //Set the string "Type" variable Text to "Used"//


            Rad_New.Foreground = new SolidColorBrush(Colors.Black);
            Rad_Used.Foreground = new SolidColorBrush(Colors.Red);
            Rad_Demo.Foreground = new SolidColorBrush(Colors.Black);

            connect = new CTUConnection();
            connect.SelectUsedDrive();
            cmbx_Vehicle.ItemsSource = connect.table2.DefaultView;
            cmbx_Vehicle.DisplayMemberPath = "[Name of vehicle]";
            cmbx_Vehicle.SelectedValuePath = "ID";
        }

        private void Rad_Demo_Click(object sender, RoutedEventArgs e)
        {
            Type = "Demo"; //Set the string "Type" variable Text to "Demo"//           

            Rad_New.Foreground = new SolidColorBrush(Colors.Black);
            Rad_Used.Foreground = new SolidColorBrush(Colors.Black);
            Rad_Demo.Foreground = new SolidColorBrush(Colors.Red);

            connect = new CTUConnection();
            connect.SelectDemoDrive();
            cmbx_Vehicle.ItemsSource = connect.table2.DefaultView;
            cmbx_Vehicle.DisplayMemberPath = "[Name of vehicle]";
            cmbx_Vehicle.SelectedValuePath = "ID";
        }

        private void can_Clear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txt_BookNo.Clear();
        }

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            try
            {
                if (string.IsNullOrEmpty(txt_BookNo.Text))
                {
                    MessageBox.Show("Please insert a booking number");
                }

                else
                {
                    if (Rad_New.IsChecked == true)
                    {
                        connect.UpdateTestDrive(Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), int.Parse(txt_BookNo.Text), int.Parse(cmbx_Cust.SelectedValue.ToString()), int.Parse(cmbx_Vehicle.SelectedValue.ToString()), int.Parse(ID));
                    }

                    else if (Rad_Used.IsChecked == true || Rad_Demo.IsChecked == true)
                    {
                        connect.UpdateTestDrive2(Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), int.Parse(txt_BookNo.Text), int.Parse(cmbx_Cust.SelectedValue.ToString()), int.Parse(cmbx_Vehicle.SelectedValue.ToString()), int.Parse(ID));
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter the date the vehicle was booked");
            }

        }
    }
}