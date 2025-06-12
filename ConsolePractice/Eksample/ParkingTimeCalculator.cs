using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.Eksample
{
    public class ParkingTimeCalculator
    {
        public DateTime parkingExpiration(int paid, DateTime date) {
            DateTime end = date.AddHours(paid / 5);
            return end;
        }

    }
}
