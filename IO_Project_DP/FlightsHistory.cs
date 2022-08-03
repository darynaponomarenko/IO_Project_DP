using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Project_DP
{
    public class FlightsHistory
    {
        private int _id;

        public int id
        {
            get { return this._id; }
            set
            {
                if (this._id != value)
                {
                    this._id = value;
                    this.NotifyPropertyChanged("id");
                }
            }
        }

        private string _name;

        public string name
        {
            get { return this._name; }
            set
            {
                if (this._name != value)
                {
                    this._name = value;
                    this.NotifyPropertyChanged("name");
                }
            }
        }

        private string _fromPlace;
        public string fromPlace
        {
            get { return this._fromPlace; }
            set
            {
                if (this._fromPlace != value)
                {
                    this._fromPlace = value;
                    this.NotifyPropertyChanged("fromPlace");
                }
            }
        }
        private string _toPlace;

        public string toPlace
        {
            get { return this._toPlace; }
            set
            {
                if (this._toPlace != value)
                {
                    this._toPlace = value;
                    this.NotifyPropertyChanged("toPlace");
                }
            }
        }

        private string _flightNo;

        public string flightNo
        {
            get { return this._flightNo; }
            set
            {
                if (this._flightNo != value)
                {
                    this._flightNo = value;
                    this.NotifyPropertyChanged("flightNo");
                }
            }
        }

        private DateTime _date;
        public DateTime date
        {
            get { return this._date; }
            set
            {
                if (this._date != value)
                {
                    this._date = value;
                    this.NotifyPropertyChanged("date");
                }
            }
        }

        private string _seatNo;
        public string seatNo
        {
            get { return this._seatNo; }
            set
            {
                if (this._seatNo != value)
                {
                    this._seatNo = value;
                    this.NotifyPropertyChanged("seatNo");
                }
            }
        }

        private char _seatClass;
        public char seatClass
        {
            get { return this._seatClass; }
            set
            {
                if (this._seatClass != value)
                {
                    this._seatClass = value;
                    this.NotifyPropertyChanged("class");
                }
            }
        }

        private DateTime _departureTime;
        public DateTime departureTime
        {
            get { return this._departureTime; }
            set
            {
                if (this._departureTime != value)
                {
                    this._departureTime = value;
                    this.NotifyPropertyChanged("departureTime");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
