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
    public class windowcs
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

