using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfTaxi.Model;

namespace WpfTaxi.Viwe_Model
{
    class AddDrivers : Base
    {
        private Model1 BD;
        private windowcs win;
        public AddDrivers(Model1 bd, windowcs window)
        {
            BD = bd;
            win = window;
            Colors = new ObservableCollection<Color>(BD.Color);
            Models = new ObservableCollection<Model.Model>(BD.Model);
        }

        public ObservableCollection<Color> Colors { get; set; }
        public ObservableCollection<Model.Model> Models { get; set; }
        private Color selectColor;
        private Model.Model selectModel;

        public Model.Model SelectModel
        {
            get { return selectModel; }
            set
            {
                selectModel = value;
                OnPropertyChanged("SelectModel");
            }
        }

        public Color SelectColor
        {
            get { return selectColor; }
            set
            {
                selectColor = value;
                OnPropertyChanged("SelectColor");
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
        private string nomerPhone;
        public string NomerPhone
        {
            get { return nomerPhone; }
            set
            {
                nomerPhone = value;
                OnPropertyChanged("NomerPhone");
            }
        }
        private string nomerDrive;
        public string NomerDrive
        {
            get { return nomerDrive; }
            set
            {
                nomerDrive = value;
                OnPropertyChanged("NomerDrive");
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
                        MessageBoxResult dialogResult = MessageBox.Show(
        "Вы уверены",
        "Внимание",
        MessageBoxButton.YesNo,
        MessageBoxImage.Information,
        MessageBoxResult.No,
        MessageBoxOptions.DefaultDesktopOnly);
                        if (dialogResult == MessageBoxResult.Yes)
                        {
                            Driver driver = new Driver();
                            driver.Color_FK = selectColor.Color_ID;
                            driver.Driver_ID = 1;
                            driver.Driver_name = fio;
                            driver.Driver_phone_number = nomerPhone;
                            driver.Model_FK = selectModel.Model_ID;
                            driver.number_car = nomerDrive;
                            BD.Driver.Add(driver);
                            BD.SaveChanges();
                            win.ld1();
                        }
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
