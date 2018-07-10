using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Modell
{
    public class Classes
    {
        public Classes(MySqlDataReader data)
        {
            dayOfWeek = uint.Parse(data[4].ToString());
            Places = uint.Parse(data[3].ToString());
            Id = uint.Parse(data[0].ToString());
            Name = data[1].ToString();
            StartTime = data[2].ToString();
            Instructor = data[5].ToString();
            DataBases.DBConnection dBConnection = new DataBases.DBConnection();
            TakenPlaces = dBConnection.TakenPlaces(Id);
        }
        uint dayOfWeek;
        public uint Places { get; private set; }
        public uint TakenPlaces { get; set; }
        public string Name { get; private set; }
        public string DayOfWeek
        {
            get
            {
                string day = "";
                switch (dayOfWeek)
                {
                    case 1:
                        day = "Poniedziałek";
                        break;
                    case 2:
                        day = "Wtorek";
                        break;
                    case 3:
                        day = "Środa";
                        break;
                    case 4:
                        day = "Czwartek";
                        break;
                    case 5:
                        day = "Piątek";
                        break;
                    case 6:
                        day = "Sobota";
                        break;
                    case 7:
                        day = "Niedziela";
                        break;
                }
                return day;
            }
        }
        public string Instructor { get; private set; }
        public string StartTime { get; private set; }
        public uint Id { get; private set; }
        public uint NumberOfDay { get { return dayOfWeek; } }
    }
}
