using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfTaxi.Model;
using WpfTaxi.Viwe_Model;
using System.Windows;

namespace WpfTaxi
{
    class AuthorizationLog


    {
        Authorization win;
        public AuthorizationLog(Authorization autor)
        {
          
            win = autor;
        }


        string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }

        public RelayCommand OK
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    try
                    {
                        string passworld = win.pas.Password;
                        if ((login.Length > 0) && (passworld.Length > 0))
                        {
                                Model1 bd = new Model1();
                                Dispatcher dispatcher = bd.Dispatcher.Where(i => (i.Dispatcher_name == login) && (i.password == passworld)).FirstOrDefault();
                                if (dispatcher != null)
                                {
                                    win.Hide();
                                    window window = new window(dispatcher.Dispatcher_ID);
                                    window.ShowDialog();
                                    win.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Неверный логин или пароль");
                                }                
                        }
                        else
                            MessageBox.Show("Введите логин и пароль");
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
