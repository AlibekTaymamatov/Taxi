using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using WpfTaxi.Model;

namespace WpfTaxi.Viwe_Model
{
    class ListDrivers 
    {
        private Model1 BD;
        private windowcs win;
        public ListDrivers(Model1 bd, windowcs window)//Конструктор 
        {
            BD = bd;
            win = window;
            drivers = new ObservableCollection<Driver> (BD.Driver);
            Colors = new ObservableCollection<Color>(BD.Color);
            Models = new ObservableCollection<Model.Model>(BD.Model);
           
        }
        public ObservableCollection<Color> Colors { get; set; }
    
        public ObservableCollection<Driver> drivers { get; set; }//Список заполнения комбобокс
        public ObservableCollection<Model.Model> Models { get; set; }
        

    } 
}
