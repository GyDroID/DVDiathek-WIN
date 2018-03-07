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

namespace DVDiathek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<MediaListControl> mediaListControls = new List<MediaListControl>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ComboBoxViewModel();
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = "Zoomania.jpg" });
            //MediaList.ItemsSource = mediaListControls;
            MediaList.DataContext = mediaListControls;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeLayout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
