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
using System.Text.RegularExpressions;

namespace CarTradingUnlimited
{
	public partial class UpdateMotorCycle
	{
        ViewMotorCycle ViewMoto;
        AddMotorCycle AddMoto;
        CTUConnection connect;

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


        public byte[] data2
        {
            get;
            set;
        }

		public UpdateMotorCycle()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void Can_AddMoto_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Visible;		
			elipse_AddMoto.Opacity = 0.75;
			
			TxtBlk_AddMoto.Foreground = new SolidColorBrush(Colors.White);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddMoto.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);			
			
			sb1.Begin();
		}

		private void Can_AddMoto_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Collapsed;
			elipse_AddMoto.Opacity = 1;	
			
			TxtBlk_AddMoto.Foreground = new SolidColorBrush(Colors.Black);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddMoto.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1.1, 1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);
			
			sb1.Stop();
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

        private void Can_AddMoto_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ViewMoto = new ViewMotorCycle();
            AddMoto = new AddMotorCycle();

            ViewMoto.Moto_page = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && ViewMoto.Moto_page == null)
            {
                ViewMoto.Moto_page = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            if (ViewMoto.Moto_page != null)
            {
                ViewMoto.Moto_page.Source = new Uri("AddMotorCycle.xaml", UriKind.Relative);
            }
        }

        private void can_Browse_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow2.Opacity = 1;
		}

		private void can_Browse_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			this.glow2.Opacity = 0;
		}

        private void can_Browse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();
                dig.ShowDialog();

                FileStream fs = new FileStream(dig.FileName, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();

                ImageSourceConverter imgs = new ImageSourceConverter();
                im.SetValue(Image.SourceProperty, imgs.ConvertFromString(dig.FileName.ToString()));

                data2 = data;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Please insert a picture.");
            }

            catch (ArgumentException)
            {
                
            }
        }

        private void NoText(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
        	 Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void can_Clear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txt_Brand.Clear();
            txt_Color.Clear();
            txt_Model.Clear();
            txt_Price.Clear();
        }

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            try
            {

                if (string.IsNullOrEmpty(txt_Brand.Text))
                {
                    MessageBox.Show("Please enter the name of the motocycle");
                }

                else if (string.IsNullOrEmpty(txt_Color.Text))
                {
                    MessageBox.Show("Please enter the color of the motocycle");
                }

                else if (string.IsNullOrEmpty(txt_Model.Text))
                {
                    MessageBox.Show("Please enter the model of the motocycle");
                }

                else if (string.IsNullOrEmpty(txt_Price.Text))
                {
                    MessageBox.Show("Please enter the price of the motocycle");
                }

                else
                {
                    connect.UpdateMoto(txt_Brand.Text, txt_Model.Text, txt_Color.Text, txt_Price.Text, Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), data2, int.Parse(ID));
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please select a date");
            }

            catch (Exception)
            {
 
            }
        }

	}
}