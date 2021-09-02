using Cars_MVP.Data;
using Cars_MVP.Model;
using Cars_MVP.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_MVP.Presenter
{
    class MainPresenter
    {
        private readonly CarContext _carContext;
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _carContext = new CarContext();

            _view.buttonAddCar += AddCarButtonClicked;
            _view.buttonLoadCar += LoadCarButtonClicked;
            _view.brandSelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            _view.buttonDeleteCar += DeleteCarButtonClicked;


            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    _view.CbColor.Items.Add(prop.Name);
            }
            _view.CbColor.SelectedIndex = 8;

            List<string> brands = new List<string>
            {
                "BMW","Mercedes","KIA","Hyundai","Vaz"
            };
            _view.Brands = brands;

            List<string> transmission = new List<string>
            {
                "Automatic","Manual"
            };
            _view.Transmision = transmission;

            
        
        }

        private void AddCarButtonClicked(object sender,EventArgs e)
        {
            Car car = new Car
            {
                Brand = _view.BrandText,
                Model = _view.ModelText,
                Color = _view.ColorText,
                Year = int.Parse(_view.YearText),
                Transmission = _view.TransmissionText
            };
            _carContext.Cars.Add(car);
            _carContext.SaveChanges();
        }

        private void LoadCarButtonClicked(object sender,EventArgs e)
        {
            _view.Cars = _carContext.Cars.ToList();
        }

        private void DeleteCarButtonClicked(object sender, EventArgs e)
        {
            _carContext.Cars.Remove(_view.SelectedCar);
            _carContext.SaveChanges();
        }



        private void comboBoxBrand_SelectedIndexChanged(object sender,EventArgs e)
        {
            if (_view.BrandText == "BMW")
            {
                List<string> models = new List<string>
                {
                    "M3","M5","M6","X5","X6","i3","i8","520","520 GT","523","525","528"
                };
                _view.Models = models;
            }
            else if (_view.BrandText == "Mercedes")
            {
                List<string> models = new List<string>
                {
                    "A-190","A-200","A-210","AMG GT 43","AMG GT 53","AMG GT S","CLA 200","CLA 250"
                };
                _view.Models = models;
            }
            else if (_view.BrandText == "KIA")
            {
                List<string> models = new List<string>
                {
                    "Cerato","Cerato Koup","K3","K5","K7","Sorento","Soul","Sportage","Stinger"
                };
                _view.Models = models;
            }
            else if (_view.BrandText == "Hyundai")
            {
                List<string> models = new List<string>
                {
                    "Accent","Azera","Elantra","Genesis","Santafe","Sonata","Tucson","Veloster","i10","i20","i30","i40"
                };
                _view.Models = models;
            }
            else if (_view.BrandText == "Vaz")
            {
                List<string> models = new List<string>
                {
                   "2103","2104","2105","2106","2107","Niva","Oka","Priora"
                };
                _view.Models = models;
            }
        }
    }
}
