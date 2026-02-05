using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class HotelBooking
    {
        public string GuestName;
        public int LengthOfStayInDays;
        public DateTime StartDate;
        public DateTime EndDate;

        public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
        {
            GuestName = guestName;
            StartDate = startDate;
            LengthOfStayInDays = lengthOfStayInDays;
            EndDate = startDate.AddDays(LengthOfStayInDays);
        }
    }
}
