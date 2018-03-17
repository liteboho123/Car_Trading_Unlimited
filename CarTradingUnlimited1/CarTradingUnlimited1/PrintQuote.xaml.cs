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


namespace CarTradingUnlimited
{
	/// <summary>
	/// Interaction logic for PrintQuote.xaml
	/// </summary>
	public partial class PrintQuote : Window
	{
        CTUConnection connect;

        FlowDocument flwdoc;
        PrintDialog pd;
        TextRange sourc;
        MemoryStream str;
        FlowDocument flwDocCopy;
        TextRange sourc2;
       
		public PrintQuote()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.          
		}


        /// <summary>
        /// Display the relevent information in the rich-textbox as 
        /// the parts selected changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbx_Parts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            connect = new CTUConnection();
            flwdoc = new FlowDocument();
            connect.PrintQuote(int.Parse(cmbx_Parts.SelectedValue.ToString())); 

            flwdoc.Blocks.Add(new Paragraph(new Run("File number: " + connect.set.Tables[0].Rows[0][0].ToString())));                
            flwdoc.Blocks.Add(new Paragraph(new Run("Manufacturer: " + connect.set.Tables[0].Rows[0][3].ToString())));          
            flwdoc.Blocks.Add(new Paragraph(new Run("Details: " + connect.set.Tables[0].Rows[0][1].ToString())));     
            flwdoc.Blocks.Add(new Paragraph(new Run("Price: " + "R" + connect.set.Tables[0].Rows[0][2].ToString())));            
            flwdoc.Blocks.Add(new Paragraph(new Run("Valid for only 3 days"))); 

            Rich_Quote.Document = flwdoc;
        }

        /// <summary>
        /// Print the document displayed within the rich-text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void can_Print_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pd = new PrintDialog();
            sourc = new TextRange(Rich_Quote.Document.ContentStart, Rich_Quote.Document.ContentEnd);
            str = new MemoryStream();
            sourc.Save(str, DataFormats.Xaml);
            flwDocCopy = new FlowDocument();
            sourc2 = new TextRange(flwDocCopy.ContentStart, flwDocCopy.ContentEnd);
            sourc2.Load(str, DataFormats.Xaml);        
            

            if (pd.ShowDialog() == true)
            {
                pd.PrintVisual(Rich_Quote as Visual, "Print Quote");
            }
        }

        private void can_Print_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glow.Opacity = 1;
        }

        private void can_Print_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glow.Opacity = 0;
        }

        private void can_Back_MouseDown(object sender, MouseButtonEventArgs e)
        {          
            this.Hide();
        }

        private void can_Back_MouseEnter(object sender, MouseEventArgs e)
        {
            this.glow2.Opacity = 1;
        }

        private void can_Back_MouseLeave(object sender, MouseEventArgs e)
        {
            this.glow2.Opacity = 0;
        }

        private void Rec_Parts_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Window_Qoute_Loaded(object sender, RoutedEventArgs e)
        {
            connect = new CTUConnection();
            connect.Selectparts();
            cmbx_Parts.ItemsSource = connect.table.DefaultView;
            cmbx_Parts.DisplayMemberPath = "Details";
            cmbx_Parts.SelectedValuePath = "ID";
        }

        
	}
}