using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VKD.UI
{
    /// <summary>
    /// Interaction logic for AudioWindow.xaml
    /// </summary>
    public partial class AudioWindow : Window
    {
        private BL.Library _library;

        public AudioWindow()
        {
            InitializeComponent();
        }

        public AudioWindow(BL.Library library)
        {
            InitializeComponent();
            this._library = library;
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            var list = _library.LoadSongListFromVK(0);
            vkSongList.ItemsSource = list;

        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            Application curApp = Application.Current;
            curApp.Shutdown();
        }
    }
}
