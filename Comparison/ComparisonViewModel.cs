using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{

    public class Instrument
    {
        public string Name { get; set; }
        public bool Checked { get; set; }
    }

    public class SecType
    {
        public string Name { get; set; }
        public bool Checked { get; set; }
    }




    public class ComparisonViewModel : INotifyPropertyChanged
    {

        public Instrument[] Instruments = new[]
        {
           new Instrument { Name=  "All", Checked = false },
           new Instrument { Name=  "Test", Checked = true }
        };


        private string _busDate;
        public string BusDate
        {
            get { return _busDate; }
            set
            {
                _busDate = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(BusDate)));
            }
        }



        private string[] _instrumentTypes;

        /*
        public string[] InstrumentTypes;
        {
            get { return null; }
            set
            {

            }
        }*/

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }


    }
    
}
