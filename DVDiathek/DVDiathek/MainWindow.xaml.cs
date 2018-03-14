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
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Zoomania", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\Zoomania.jpg" });
            mediaListControls.Add(new MediaListControl() { Index = 1, MediaTitle = "Forrest Gump", MediaDetail = "Testbeschreibung", MediaImage = @"\Image\ForrestGump.jpg" });
            MediaList.ItemsSource = mediaListControls;
            //MediaList.DataContext = mediaListControls;
        }

        private void btnChangeLayout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
