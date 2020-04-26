using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfTaxi.Model;

namespace WpfTaxi.Viwe_Model
{
    class OrdersStatus:Base
    {
       

        public OrdersStatus(Model1 bd, windowcs window)//Конструктор 
        {
            BD = bd;
            win = window;
            clients = new ObservableCollection<Client>(BD.Client);
            Colors = new ObservableCollection<Color>(BD.Color);
            Models = new ObservableCollection<Model.Model>(BD.Model);
            orders = new ObservableCollection<Orders>(BD.Orders);
            status_Orders = new ObservableCollection<status_orders>(BD.status_orders);
            dispatch = new ObservableCollection<Dispatcher>(BD.Dispatcher);
            
        }
        public ObservableCollection<Dispatcher> dispatch { get; set; }
        public ObservableCollection<status_orders> status_Orders { get; set; }//Список заполнения комбобокс
        private status_orders Selectstatus;
        public status_orders SelectStatus
        {
            get { return Selectstatus; }
            set
            {
                Selectstatus = value;
                OnPropertyChanged("SelectStatus");
            }
        }

        private Model1 BD;
        private windowcs win;
        private int Dispatcher_ID;
        public ObservableCollection<Color> Colors { get; set; }
        public ObservableCollection<Orders> orders { get; set; }
        public ObservableCollection<Client> clients { get; set; }
        public ObservableCollection<Model.Model> Models { get; set; }
        public Dispatcher dispatchers;     

        public OrdersStatus(int id, windowcs window, Model1 bd)
        {
            BD = bd;
            Dispatcher_ID = id;
            dispatchers = bd.Dispatcher.Find(id);

            orders = new ObservableCollection<Orders>(dispatchers.Orders);
            BD = bd;
            this.win = window;
        }


    }
}
