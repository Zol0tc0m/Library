using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Praktos8Sharp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string language;

        public static string Language
        {
            get { return language; }
            set
            {
                language = value;
                var dict = new ResourceDictionary { Source = new Uri($"/CustomLib;component/Themes/{value}.xaml", UriKind.Relative) };
                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }
        public App()
        {
            InitializeComponent();
        }
    }
}
