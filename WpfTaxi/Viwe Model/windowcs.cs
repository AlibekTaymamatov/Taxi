using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTaxi.Model;
using WpfTaxi.Viwe;
using System.Windows;

namespace WpfTaxi.Viwe_Model
{
    public class windowcs : Base
    {
        public window w;
        PageOrdersStatus or;
        PageAddOrders ao;
        PageAddDrivers ad;
        PageListDrivers ld;
        Model1 bd;
        Otchet_dis ot;
        int Dispatcher_ID;

        public windowcs( int id , window win)
        {
            Dispatcher_ID = id;
            this.w = win;
            bd = new Model1();
        }

        bool check0;
        bool check1;
        bool check2;
        bool check3;

        public bool Check0
        {
            get { return check0; }
            set
            {
                check0 = true;
                check1 = false;
                check2 = false;
                check3 = false;
                OnPropertyChanged("Check0");
                OnPropertyChanged("Check1");
                OnPropertyChanged("Check2");
                OnPropertyChanged("Check3");
            }
        }
        public bool Check1
        {
            get { return check1; }
            set
            {
                check0 = false;
                check1 = true;
                check2 = false;
                check3 = false;
                OnPropertyChanged("Check0");
                OnPropertyChanged("Check1");
                OnPropertyChanged("Check2");
                OnPropertyChanged("Check3");
            }
        }
        public bool Check2
        {
            get { return check2; }
            set
            {
                check0 = false;
                check1 = false;
                check2 = true;
                check3 = false;
                OnPropertyChanged("Check0");
                OnPropertyChanged("Check1");
                OnPropertyChanged("Check2");
                OnPropertyChanged("Check3");
            }
        }
        public bool Check3
        {
            get { return check3; }
            set
            {
                check0 = false;
                check1 = false;
                check2 = false;
                check3 = true;
                OnPropertyChanged("Check0");
                OnPropertyChanged("Check1");
                OnPropertyChanged("Check2");
                OnPropertyChanged("Check3");
            }
        }

        public RelayCommand OrV
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    try
                    {
                        orvs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
        }

        public void orvs()
        {
            //if (or == null)
                or = new PageOrdersStatus(bd,this);
            
            w.Page.Content = or;
        }



        public RelayCommand AdV
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    try
                    {
                        ad1();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
        }

        public void ad1()
        {
            //if (ad == null)
                ad = new PageAddDrivers(bd, this);

            w.Page.Content = ad;
        }

        public RelayCommand AoV
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    try
                    {
                        ao1();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
        }

        public void ao1()
        {
            //if (ao == null)
            
                ao = new PageAddOrders(bd, bd.Dispatcher.Find(Dispatcher_ID));

            w.Page.Content = ao;
        }

        public RelayCommand ldV
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    try
                    {
                        ld1();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
        }

        public void ld1()
        {
           // if (ld == null)
                ld = new PageListDrivers(bd,this);

            w.Page.Content = ld;
        }

        public RelayCommand otT
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    try
                    {
                        ot1();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
        }

        public void ot1()
        {
            // if (ld == null)
            ot = new Otchet_dis (bd,this);

            w.Page.Content = ot;
        }
    }
}

