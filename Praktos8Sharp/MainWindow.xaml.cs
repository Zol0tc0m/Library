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
using ClassLibrary1;


namespace Praktos8Sharp
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

        private void Deserialize_click(object sender, RoutedEventArgs e)
        {
            TextTbx.Text = Class1.MyDeserialize<string>("Test.json");
        }

        private void Serialize_click(object sender, RoutedEventArgs e)
        {
            Class1.MySerialize(TextTbx.Text, "Test.json");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LanguageComboBox.SelectedIndex == 1)
            {
                App.Language = "Lang.en-us";
            }
            else
            {
                App.Language = "lang.ru-ru";
            }
        }
    }
}
