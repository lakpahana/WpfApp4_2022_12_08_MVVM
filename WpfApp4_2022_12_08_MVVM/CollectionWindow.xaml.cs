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

namespace WpfApp4_2022_12_08_MVVM
{
    /// <summary>
    /// Interaction logic for CollectionWindow.xaml
    /// </summary>
    public partial class CollectionWindow : Window
    {
        public CollectionWindow()
        {
            DataContext = new CollectionWindowVM();
            InitializeComponent();
        }
    }
}
