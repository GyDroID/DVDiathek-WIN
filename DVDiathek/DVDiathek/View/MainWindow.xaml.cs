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
        public List<MediaListControl> mediaListControls = new List<MediaListControl>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ComboBoxViewModel();
            insertMedia(1, "Zoomania", "Testbeschreibung", @"\Image\Zoomania.jpg");
            insertMedia(1, "Zoomania", "Testbeschreibung", @"\Image\Zoomania.jpg");
            insertMedia(1, "Zoomania", "Testbeschreibung", @"\Image\Zoomania.jpg");
        }

        private void btnChangeLayout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnAddMedia_Click(object sender, RoutedEventArgs e)
        {
            InsertTitleView popUp = new InsertTitleView();
            popUp.ShowDialog();
            
            string test = popUp.tbNewTitle.Text;
            if (popUp.clicked == "OK")
                insertMedia(0, popUp.tbNewTitle.Text, "", "");                


        }

        private void insertMedia(int index, string mediaTitle, string mediaDetail, string mediaImage)
        {
            mediaListControls.Add(new MediaListControl() { Index = index, MediaTitle = mediaTitle, MediaDetail = mediaDetail, MediaImage = mediaImage });
            MediaList.ItemsSource = mediaListControls;
        }

        private void MediaList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnDisplayDetail_Click(object sender, RoutedEventArgs e)
        {
            int index = this.MediaList.SelectedIndex;

        }
    }
}
