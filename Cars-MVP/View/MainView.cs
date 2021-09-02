using Cars_MVP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_MVP.View
{
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public string BrandText
        {
            get => comboBox_brand.Text;
            set => comboBox_brand.Text = value;
        }

        public string ModelText
        {
            get => comboBox_model.Text;
            set => comboBox_model.Text = value;
        }

        public string ColorText
        {
            get => comboBox_color.Text;
            set => comboBox_color.Text = value;
        }

        public string YearText
        {
            get => comboBox_year.Text;
            set => comboBox_year.Text = value;
        }

        public string TransmissionText
        {
            get => comboBox_transmission.Text;
            set => comboBox_transmission.Text = value;
        }
        

        public EventHandler<EventArgs> buttonAddCar { get ; set ; }
        public EventHandler<EventArgs> buttonLoadCar { get ; set ; }
        public EventHandler<EventArgs> brandSelectedIndexChanged { get ; set; }
        public EventHandler<EventArgs> buttonDeleteCar { get; set; }
        

        

        public List<Car> Cars
        {
            set
            {
                listBoxCar.DataSource = value;
            }
        }
        public List<string> Colors {
            set 
            {
                comboBox_color.DataSource = value;
            }
                
        }
        public List<string> Models { 
            set
            {
                comboBox_model.DataSource = value;
            }
        }
        public List<string> Brands {
            set
            {
                comboBox_brand.DataSource = value;
            }
        }

        public List<string> Transmision { 
            set
            {
                comboBox_transmission.DataSource = value;
            }
        }

        public ComboBox CbColor => comboBox_color;

        public Car SelectedCar 
        {
            get => listBoxCar.SelectedItem as Car;
            set => listBoxCar.SelectedItem=value; 
        }

        private void btn_AddCar_Click(object sender, EventArgs e)
        {
            buttonAddCar.Invoke(sender, e);
        }

        private void btn_LoadCar_Click(object sender, EventArgs e)
        {
            buttonLoadCar.Invoke(sender, e);
        }

        private void comboBox_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            brandSelectedIndexChanged.Invoke(sender, e);
        }

        private void btn_deleteCar_Click(object sender, EventArgs e)
        {
            buttonDeleteCar.Invoke(sender, e);
        }
    }
}
