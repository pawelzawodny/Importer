using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace Importer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();

            open.Multiselect = false;

            open.Filter = "AllFiles|*.*";

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
{
    UserImporterDataProvider uidp = (UserImporterDataProvider)this.Resources["UserImporterDataProvider"];
    uidp.Uploader(open.FileName, open.OpenFile());

                    textBlock1.Text = "File Uploaded";
            }
            
    

            else
            {

                textBlock1.Text = " No files selected!";

            }

        }











    }
}
