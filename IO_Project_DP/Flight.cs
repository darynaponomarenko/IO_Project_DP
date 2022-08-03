using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Project_DP
{
    
    public class Flight
    {
        public static List<Flight> flightList = new List<Flight>();

        public int id { get; set; }
        public int userID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public DateTime date { get; set; }
        public string seat { get; set; }
        public string clas { get; set; }

        public Flight()
        {
            id = 0;
            userID = 0;
            name = "name1";
            surname = "surname1";
            from = "from1";
            to = "to1";
            date = DateTime.Now;
            seat = "seat1";
            clas = "class1";
        }
        public Flight(int id, int userID, string name, string surname, string from, string to, DateTime date, string seat, string clas)
        {
            this.id = id;
            this.userID = userID;
            this.name = name;
            this.surname = surname;
            this.from = from;
            this.to = to;
            this.date = date;
            this.seat = seat;
            this.clas = clas;
        }

        public Flight(Flight flight)
        {
            this.id = flight.id;
            this.userID = flight.userID;
            this.name = flight.name;
            this.surname = flight.surname;
            this.from = flight.from;
            this.to = flight.to;
            this.date = flight.date;
            this.seat = flight.seat;
            this.clas = flight.clas;
        }

    }
}
