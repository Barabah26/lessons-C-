using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var medicalAppointment = new MedicalAppointment(
                "John Smith", new DateTime(2023, 4, 3));
            medicalAppointment.OverwriteMonthAndDay(5, 1);
            medicalAppointment.MoveByMonthsAndDays(1, 2);


        }
    }

    public class MedicalAppointment 
    {
        private string _patientName;
        private DateTime _date;

        public MedicalAppointment(string patientName, DateTime date)
        {
            _patientName = patientName;
            _date = date;
        }

        public MedicalAppointment(string patientName) :
            this(patientName, 7)
        { 
        }

        public MedicalAppointment(string patientName, int daysFromNow)
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(daysFromNow);
        }

        public void Reschedule(DateTime date)
        {
            _date = date;
        }

        public void OverwriteMonthAndDay(int month, int day)
        {
            _date = new DateTime(_date.Year, month, day);   
        }

        public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
        {
            _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
        }

    }
}
