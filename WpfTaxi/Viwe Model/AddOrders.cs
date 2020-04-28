using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTaxi.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfTaxi.Viwe_Model
{
    class AddOrders : Base
    {
        private Model1 BD;

      
        public AddOrders(Model1 bd, Dispatcher dispatcher)
        {
            BD = bd;
            dispatchers = dispatcher;
            Drivers = new ObservableCollection<Driver>(BD.Driver);
            client = null;
        }
         
        public ObservableCollection<Driver> Drivers { get; set; }
        private Driver Selectdriver;
        private Dispatcher dispatchers;

        public Driver SelectDriver
        {
            get { return Selectdriver; }
            set
            {
                Selectdriver = value;
                OnPropertyChanged("SelectDriver");
            }
        }

        private string fio;
        public string FIO
        {
            get { return fio; }
            set
            {
                fio = value;
                OnPropertyChanged("FIO");
            }
        }

        private string otpravka;
        public string Otpravka
        {
            get { return otpravka; }
            set
            {
                otpravka = value;
                OnPropertyChanged("Otpravka");
            }
        }

        private string naznacheniye;
        public string Naznacheniye
        {
            get { return naznacheniye; }
            set
            {
                naznacheniye = value;
                OnPropertyChanged("Naznacheniye");
            }
        }

        private string timeOR;
        public string TimeOR
        {
            get { return timeOR; }
            set
            {
                timeOR = value;
                OnPropertyChanged("TimeOR");
            }
        }
        private string nomerClient;
        public string NomerClient
        {
            get { return nomerClient; }
            set
            {
                nomerClient = value;
                OnPropertyChanged("NomerClient");
                Client client = BD.Client.Where(i => i.phone_number_client == nomerClient).FirstOrDefault();

                if (client != null)
                {
                    this.client = client;
                    FIO = client.client_name;
                }
            }
        }
        Client client;
        public RelayCommand OK
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    try
                    {
                       
                      
                        
                            Orders oreder = new Orders();
                            Client client;
                            if (this.client != null)
                            {
                                client = this.client;
                            }
                            else
                            {
                                client = new Client();
                                client.Client_ID = 1;
                                client.client_name = fio;
                                client.phone_number_client = nomerClient;
                                BD.Client.Add(client);
                                BD.SaveChanges();
                            }
                            
                      
                            oreder.Dipatcher_FK = dispatchers.Dispatcher_ID;
                            oreder.status_orders_FK=1;
                            oreder.Driver_FK = Selectdriver.Driver_ID;
                      
                            oreder.Orders_ID = 1;
                            oreder.mesto_otpravleniya = otpravka;
                            oreder.mesto_naznacheniya = naznacheniye;
                           
                            string[] str = timeOR.Split('.');
                            int h = int.Parse(str[0]);
                            int m = int.Parse(str[1]);
                            DateTime n = DateTime.Now;
                            oreder.time = new DateTime(n.Year,n.Month,n.Day,h,m,0);
                            
                            oreder.Client_FK = client.Client_ID;
                            
                            BD.Orders.Add(oreder);                            
                            BD.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }

        }

   
       
    }
}
