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
using System.Windows.Shapes;

namespace DVDiathek
{
    /// <summary>
    /// Interaktionslogik für insertTitlePopUp.xaml
    /// </summary>
    public partial class InsertTitleView : Window
    {
        public string clicked;

        public InsertTitleView()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            clicked = "OK";
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            clicked = "CANCEL";
            this.Close();
        }
    }
}
