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
using WpfTaxi.Model;
using WpfTaxi.Viwe_Model;

namespace WpfTaxi.Viwe
{
    /// <summary>
    /// Логика взаимодействия для Otchet_dis.xaml
    /// </summary>
    public partial class Otchet_dis : Page
    {
        public Otchet_dis(Model1 bd, windowcs win)
        {
            InitializeComponent();
            DataContext = new OrdersStatus(bd,win);
        }
    }
}
