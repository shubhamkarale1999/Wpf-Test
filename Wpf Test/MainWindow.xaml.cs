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

namespace Wpf_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Package1 { get; set; } = "Gold";

        public string Package2 { get; set; } = "Silver";

        public string Package3 { get; set; } = "Daimond";

        


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext=this;  
        }

        private void ComboBox1_Copy1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
