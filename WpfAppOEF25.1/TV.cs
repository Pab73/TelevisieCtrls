using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppOEF25._1
{
    class TV
    {
        private string _afbeelding;
        private string _merk;
        private string _type;
        private int _beeldgrootte;
        private int _herz;
        private int _kanaal;
        private int _volume;
        private bool _power;
        private bool _teletekst;

        ////public string Helderheid { get; set; }
        //public int MyProperty { get;  set; }  //kleinste waarde: 0 en g...   
        ////value trager dan 0
        //// value sneller 250 
        ////int kleinste waarde -10000000   grootste waarde 11000000000000

        public string Afbeelding { get => _afbeelding; set => _afbeelding = value; }
        public string Merk { get => _merk; set => _merk = value; }
        public string Type { get => _type; set => _type = value; }
        public int Beeldgrootte { get => _beeldgrootte; set => _beeldgrootte = value; }
        public int Herz { get => _herz; set => _herz = value; }
        public int Kanaal
        {
            get => _kanaal;
            set
            {
                if (Power)
                {
                    if (value >= 0 && value <= 30)
                    {
                        _kanaal = value;
                    }
                    else
                    {
                        if (value > 30)
                        {
                            _kanaal = 30;
                        }
                        else if (value < 0)
                        {
                            _kanaal = 0;
                        }
                    }
                }
            }
        }
        public int Volume
        {
            get => _volume;
            set
            {
                if (Power)
                {
                    if (value >= 0 && value <= 99)
                    {
                        _volume = value;
                    }
                    else
                    {
                        if (value > 99)
                        {
                            _volume = 99;
                        }
                        else if (value < 0)
                        {
                            _volume = 0;
                        }
                    }
                }
            }
        }

        public bool Power { get => _power; set => _power = value; }
        public bool Teletekst { get => _teletekst; set => _teletekst = value; }

        public TV()
        {
            Power = false;
        }
        public TV(string merk, string type, int herz, int beeldgrootte, string afbeelding)
        {
            Teletekst = _teletekst;
            Power = _power;
            Kanaal = _kanaal;
            Volume = _volume;
            Merk = merk;
            Type = type;
            Herz = herz;
            Beeldgrootte = beeldgrootte;
            Afbeelding = afbeelding;
        }
        public override string ToString()
        {
            return "";
        }

    }
}
