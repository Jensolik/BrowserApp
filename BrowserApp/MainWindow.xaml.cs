using ModelBrowserLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

namespace BrowserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Tab> tab = new ObservableCollection<Tab>();
        public MainWindow()
        {
            InitializeComponent();


            tab.Add(new Tab("Yandex1", "https://yandex.com"));
            
        }

        private void TabList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tab p = (Tab)TabList.SelectedItem;
            
        }
  
    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var request = addressTextBox.Text;
            if (!addressTextBox.Text.Contains("https://")) { addressTextBox.Text = "https://" + addressTextBox.Text; }


            Uri uri = new Uri(this.addressTextBox.Text, UriKind.RelativeOrAbsolute);

            // Only absolute URIs can be navigated to  
            if (!uri.IsAbsoluteUri)
            {
              
                MessageBox.Show("The Address URI must be absolute. For example, 'http://www.microsoft.com'");
                return;
            }

            // Navigate to the desired URL by calling the .Navigate method  
            this.myWebBrowser.Navigate(uri);
            tab.Add(new Tab(request, "addressTextBox.Text"));
            TabList.ItemsSource = tab;

        }

    }
}
