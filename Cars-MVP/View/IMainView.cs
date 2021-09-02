using Cars_MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_MVP.View
{
    public interface IMainView
    {
         string BrandText { get; set; }
         string ModelText { get; set; }
         string ColorText { get; set; }
         string YearText { get; set; }
         string TransmissionText { get; set; }
         Car SelectedCar { get; set; }
         ComboBox CbColor { get; }

        EventHandler<EventArgs> buttonAddCar { get; set; }
        EventHandler<EventArgs> buttonLoadCar { get; set; }
        EventHandler<EventArgs> buttonDeleteCar { get; set; }
        EventHandler<EventArgs> brandSelectedIndexChanged { get; set; }

        
        

        List<Car> Cars { set; }
        List<string> Colors { set; }
        List<string> Models { set; }
        List<string> Brands { set; }
        List<string> Transmision { set; }
    }
}
