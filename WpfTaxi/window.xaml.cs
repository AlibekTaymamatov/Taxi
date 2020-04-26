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
using WpfTaxi.Viwe_Model;
using WpfTaxi.Model;


namespace WpfTaxi
{
    /// <summary>
    /// Логика взаимодействия для window.xaml
    /// </summary>
    public partial class window : Window
    {
        public window(int id)
        {
            InitializeComponent();
            
            DataContext = new windowcs( id,this);
        }
    }
}
