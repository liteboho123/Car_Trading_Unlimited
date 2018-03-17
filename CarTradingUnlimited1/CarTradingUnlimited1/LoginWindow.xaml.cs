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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        MainWindow main;
        ImageBrush ib = new ImageBrush();
        CTUConnection connect;
        ViewWareHouse Viewware;
        ViewEmployee Vemp = new ViewEmployee();
        AddEmployee ademply = new AddEmployee();

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

        public LoginWindow()
        {
            this.InitializeComponent();
            // Insert code required on object creation below this point.           
            
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Btn_Close_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void can_btn_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.glow.Opacity = .8;
        }

        private void can_btn_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.glow.Opacity = 0;
        }

        private void can_btn_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            if (cmbx_Department.SelectedIndex == 0)
            {
                main = new MainWindow();
                connect.LoginAccountEmployee(Txt_Username.Text, Txt_Password.Password, int.Parse(cmbx_Department.SelectedValue.ToString()));
                main.Btn_Motorcycle.Visibility = Visibility.Collapsed;
                main.Btn_OldVehicles.Visibility = Visibility.Collapsed;
                main.Btn_Parts.Visibility = Visibility.Collapsed;
                main.Btn_Service.Visibility = Visibility.Collapsed;                
                Department = 1;
                main.Department = Department;

                if (connect.Count == 1)
                {
                    if (connect.table.Rows[0][7].ToString() == "1")
                    {
                        main.TxtBlk_Department.Text = string.Format("New vehicle department (Administrator)");
                        RoleType = "Administrator";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "2")
                    {
                        main.TxtBlk_Department.Text = string.Format("New vehicle department (Manager)");
                        RoleType = "Manager";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "3")
                    {
                        main.TxtBlk_Department.Text = string.Format("New vehicle department (SalesMan)");
                        RoleType = "SalesMan";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "4")
                    {
                        main.TxtBlk_Department.Text = string.Format("New vehicle department (Mechanic)");
                        RoleType = "Mechanic";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "5")
                    {
                        main.TxtBlk_Department.Text = string.Format("New vehicle department (Surbordinate)");
                        RoleType = "Surbordinate";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }
                }

            }

            else if (cmbx_Department.SelectedIndex == 1)
            {
                main = new MainWindow();
                connect.LoginAccountEmployee(Txt_Username.Text, Txt_Password.Password, int.Parse(cmbx_Department.SelectedValue.ToString()));
                main.Btn_Motorcycle.Visibility = Visibility.Collapsed;
                main.Btn_NewVehicles.Visibility = Visibility.Collapsed;
                main.Btn_Parts.Visibility = Visibility.Collapsed;
                main.Btn_Service.Visibility = Visibility.Collapsed;           
                Department = 2;
                main.Department = Department;

                if (connect.Count == 1)
                {
                    if (connect.table.Rows[0][7].ToString() == "1")
                    {
                        main.TxtBlk_Department.Text = string.Format("Used/demo vehicle department (Administrator)");
                        RoleType = "Administrator";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "2")
                    {
                        main.TxtBlk_Department.Text = string.Format("Used/demo vehicle department (Manager)");
                        RoleType = "Manager";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "3")
                    {
                        main.TxtBlk_Department.Text = string.Format("Used/demo vehicle department (SalesMan)");
                        RoleType = "SalesMan";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "4")
                    {
                        main.TxtBlk_Department.Text = string.Format("Used/demo vehicle department (Mechanic)");
                        RoleType = "Mechanic";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "5")
                    {
                        main.TxtBlk_Department.Text = string.Format("Used/demo vehicle department (Surbordinate)");
                        RoleType = "Surbordinate";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }
                }
            }

            else if (cmbx_Department.SelectedIndex == 2)
            {
                main = new MainWindow();
                connect.LoginAccountEmployee(Txt_Username.Text, Txt_Password.Password, int.Parse(cmbx_Department.SelectedValue.ToString()));
                main.Btn_Motorcycle.Visibility = Visibility.Collapsed;
                main.Btn_OldVehicles.Visibility = Visibility.Collapsed;
                main.Btn_Parts.Visibility = Visibility.Collapsed;
                main.Btn_NewVehicles.Visibility = Visibility.Collapsed;
                main.Btn_TestDrive.Visibility = Visibility.Collapsed;
                Department = 3;
                main.Department = Department;

                if (connect.Count == 1)
                {
                    if (connect.table.Rows[0][7].ToString() == "1")
                    {
                        main.TxtBlk_Department.Text = string.Format("Service department (Administrator)");
                        RoleType = "Administrator";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "2")
                    {
                        main.TxtBlk_Department.Text = string.Format("Service department (Manager)");
                        RoleType = "Manager";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "3")
                    {
                        main.TxtBlk_Department.Text = string.Format("Service department (SalesMan)");
                        RoleType = "SalesMan";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "4")
                    {
                        main.TxtBlk_Department.Text = string.Format("Service department (Mechanic)");
                        RoleType = "Mechanic";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "5")
                    {
                        main.TxtBlk_Department.Text = string.Format("Service department (Surbordinate)");
                        RoleType = "Surbordinate";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }
                }
            }

            else if (cmbx_Department.SelectedIndex == 3)
            {
                main = new MainWindow();
                connect.LoginAccountEmployee(Txt_Username.Text, Txt_Password.Password, int.Parse(cmbx_Department.SelectedValue.ToString()));
                main.Btn_Motorcycle.Visibility = Visibility.Collapsed;
                main.Btn_OldVehicles.Visibility = Visibility.Collapsed;
                main.Btn_NewVehicles.Visibility = Visibility.Collapsed;
                main.Btn_Service.Visibility = Visibility.Collapsed;
                main.Btn_TestDrive.Visibility = Visibility.Collapsed;
                Department = 4;
                main.Department = Department;

                if (connect.Count == 1)
                {
                    if (connect.table.Rows[0][7].ToString() == "1")
                    {
                        main.TxtBlk_Department.Text = string.Format("Parts department (Administrator)");
                        RoleType = "Administrator";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "2")
                    {
                        main.TxtBlk_Department.Text = string.Format("Parts department (Manager)");
                        RoleType = "Manager";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "3")
                    {
                        main.TxtBlk_Department.Text = string.Format("Parts department (SalesMan)");
                        RoleType = "SalesMan";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "4")
                    {
                        main.TxtBlk_Department.Text = string.Format("Parts department (Mechanic)");
                        RoleType = "Mechanic";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "5")
                    {
                        main.TxtBlk_Department.Text = string.Format("Parts department (Surbordinate)");
                        RoleType = "Surbordinate";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }
                }
            }

            else if (cmbx_Department.SelectedIndex == 4)
            {
                main = new MainWindow();
                connect.LoginAccountEmployee(Txt_Username.Text, Txt_Password.Password, int.Parse(cmbx_Department.SelectedValue.ToString()));
                main.Btn_NewVehicles.Visibility = Visibility.Collapsed;
                main.Btn_OldVehicles.Visibility = Visibility.Collapsed;
                main.Btn_Parts.Visibility = Visibility.Collapsed;
                main.Btn_Service.Visibility = Visibility.Collapsed;
                main.Btn_TestDrive.Visibility = Visibility.Collapsed;
                main.Btn_Invoice.Visibility = Visibility.Collapsed;
                Department = 5;
                main.Department = Department;


                if (connect.Count == 1)
                {
                    if (connect.table.Rows[0][7].ToString() == "1")
                    {
                        main.TxtBlk_Department.Text = string.Format("Motorcycle department (Administrator)");
                        RoleType = "Administrator";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "2")
                    {
                        main.TxtBlk_Department.Text = string.Format("Motorcycle department (Manager)");
                        RoleType = "Manager";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "3")
                    {
                        main.TxtBlk_Department.Text = string.Format("Motorcycle department (SalesMan)");
                        RoleType = "SalesMan";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "4")
                    {
                        main.TxtBlk_Department.Text = string.Format("Motorcycle department (Mechanic)");
                        RoleType = "Mechanic";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "5")
                    {
                        main.TxtBlk_Department.Text = string.Format("Motorcycle department (Surbordinate)");
                        RoleType = "Surbordinate";
                        main.RoleType = RoleType;
                        this.Hide();
                        main.ShowDialog();
                    }
                }

            }

            else if (cmbx_Department.SelectedIndex == 5)
            {
                Viewware = new ViewWareHouse();
                connect.LoginAccountEmployee(Txt_Username.Text, Txt_Password.Password, int.Parse(cmbx_Department.SelectedValue.ToString()));                
                Department = 6;
                Viewware.Department = Department;


                if (connect.Count == 1)
                {
                    if (connect.table.Rows[0][7].ToString() == "1")
                    {
                        RoleType = "Administrator";
                        Viewware.RoleType = RoleType;
                        this.Hide();
                        Viewware.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "2")
                    {
                        RoleType = "Manager";                       
                        Viewware.RoleType = RoleType;
                        this.Hide();
                        Viewware.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "3")
                    {
                        RoleType = "SalesMan";                        
                        Viewware.RoleType = RoleType;
                        this.Hide();
                        Viewware.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "4")
                    {
                        RoleType = "Mechanic";                       
                        Viewware.RoleType = RoleType;
                        this.Hide();
                        Viewware.ShowDialog();
                    }

                    else if (connect.table.Rows[0][7].ToString() == "5")
                    {
                        RoleType = "Surbordinate";                        
                        Viewware.RoleType = RoleType;
                        this.Hide();
                        Viewware.ShowDialog();
                    }
                }
            }
        }

        private void Btn_Minimize_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Btn_Close_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Btn_Close.Opacity = .8;
        }

        private void Btn_Close_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Btn_Close.Opacity = 1;
        }

        private void Btn_Minimize_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Btn_Minimize.Opacity = .8;
        }

        private void Btn_Minimize_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Btn_Minimize.Opacity = 1;
        }

        private void cmbx_Department_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            if (cmbx_Department.SelectedIndex == 0)
            {
                Txt_Department.Text = "New vehicle department";
                ib.ImageSource = new BitmapImage(new Uri("Images/NewCarsFrontPic.jpeg", UriKind.Relative));
                Can_images.Background = ib;
            }

            else if (cmbx_Department.SelectedIndex == 1)
            {
                Txt_Department.Text = "Used/Demo vehicle department";
                ib.ImageSource = new BitmapImage(new Uri("Images/OldCarsFrontPic.jpeg", UriKind.Relative));
                Can_images.Background = ib;
            }

            else if (cmbx_Department.SelectedIndex == 2)
            {
                Txt_Department.Text = "Service department";
                ib.ImageSource = new BitmapImage(new Uri("Images/ServiceFrontPic.jpeg", UriKind.Relative));
                Can_images.Background = ib;
            }

            else if (cmbx_Department.SelectedIndex == 3)
            {
                Txt_Department.Text = "Parts department";
                ib.ImageSource = new BitmapImage(new Uri("Images/PartsFrontPic.jpeg", UriKind.Relative));
                Can_images.Background = ib;
            }

            else if (cmbx_Department.SelectedIndex == 4)
            {
                Txt_Department.Text = "Motorcycle department";
                ib.ImageSource = new BitmapImage(new Uri("Images/MotorCycleFrontPic.jpeg", UriKind.Relative));
                Can_images.Background = ib;
            }

            else if (cmbx_Department.SelectedIndex == 5)
            {
                Txt_Department.Text = "Warehouse department";
                ib.ImageSource = new BitmapImage(new Uri("Images/Warehouse.jpeg", UriKind.Relative));
                Can_images.Background = ib;
            }
        }

        private void Win_Login_Loaded(object sender, RoutedEventArgs e)
        {
            connect = new CTUConnection();
            connect.SelectDepartment();
            cmbx_Department.ItemsSource = connect.table.DefaultView;
            cmbx_Department.DisplayMemberPath = "DepartmentType";
            cmbx_Department.SelectedValuePath = "ID";
        }
    }
}