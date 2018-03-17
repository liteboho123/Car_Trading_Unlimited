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
using System.Text.RegularExpressions;

namespace CarTradingUnlimited
{
	public partial class AddMotorCycle
	{
        CTUConnection connect;

        public byte[] data2
        {
            get;
            set;
        }

		public AddMotorCycle()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
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

            catch (NullReferenceException)
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
                    connect.GetMoto(txt_Brand.Text, txt_Model.Text, txt_Color.Text, txt_Price.Text, Convert.ToDateTime(DTP_Date.SelectedDate.ToString()), data2);
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