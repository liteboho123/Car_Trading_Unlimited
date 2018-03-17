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
	public partial class UpdateParts
	{
        CTUConnection connect;
        ViewParts viewparts;
        AddParts addparts;

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

		public UpdateParts()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void Can_AddParts_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Visible;		
			elipse_AddParts.Opacity = 0.75;
			
			TxtBlk_AddParts.Foreground = new SolidColorBrush(Colors.White);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddParts.RenderTransform = trans;			
			
			DoubleAnimation anim = new DoubleAnimation(1, 1.1, TimeSpan.FromSeconds(0));
			
			trans.BeginAnimation(ScaleTransform.CenterXProperty, anim);
			trans.BeginAnimation(ScaleTransform.CenterYProperty, anim);			
			
			sb1.Begin();
		}

		private void Can_AddParts_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			Can_Circles.Visibility = Visibility.Collapsed;
			elipse_AddParts.Opacity = 1;	
			
			TxtBlk_AddParts.Foreground = new SolidColorBrush(Colors.Black);
			
			ScaleTransform trans = new ScaleTransform();
			
			TxtBlk_AddParts.RenderTransform = trans;			
			
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

        private void Can_AddParts_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            viewparts = new ViewParts();
            addparts = new AddParts();

            viewparts.Parts_page = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && viewparts.Parts_page == null)
            {
                viewparts.Parts_page = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            if (viewparts.Parts_page != null)
            {
                viewparts.Parts_page.Source = new Uri("AddParts.xaml", UriKind.Relative);
            }
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
            catch (NullReferenceException)
            {
                MessageBox.Show("Please insert a picture.");
            }

            catch (ArgumentException)
            {

            }
        }

        private void can_Browse_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glow2.Opacity = 1;
        }

        private void can_Browse_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glow2.Opacity = 0;
        }

        private void NoText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void can_Clear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txt_Brand.Clear();
            txt_Manufacturer.Clear();
            txt_Price.Clear();
        }

        private void can_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            connect = new CTUConnection();

            try
            {

                if (string.IsNullOrEmpty(txt_Brand.Text))
                {
                    MessageBox.Show("Please enter the details of the part");
                }

                else if (string.IsNullOrEmpty(txt_Manufacturer.Text))
                {
                    MessageBox.Show("Please enter the name of the manufacturer");
                }

                else if (string.IsNullOrEmpty(txt_Price.Text))
                {
                    MessageBox.Show("Please enter the price of the part");
                }             

                else
                {
                    connect.UpdateParts(txt_Brand.Text, txt_Price.Text, txt_Manufacturer.Text, data2, int.Parse(ID));
                }
            }           

            catch (Exception)
            {

            }
        }
	}
}