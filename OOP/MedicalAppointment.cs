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
            medicalAppointment.Reschedule(new DateTime(2023, 5, 9));
            medicalAppointment.OverwriteMonthAndDay(5, 1);
            medicalAppointment.MoveByMonthsAndDays(1, 2);
            var medicalAppointment2 = new MedicalAppointment(
                "Only name");


        }
    }

    public class MedicalAppointmentPrinter
    {
        public void Print(MedicalAppointment appointment)
        {
            Console.WriteLine(
                "Appointment will take place on " + appointment.GetDate());
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

        //public MedicalAppointment(string patientName) :
        //    this(patientName, 7)
        //{ 
        //}

        public MedicalAppointment(string patientName = "Unknown", int daysFromNow = 7)
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(daysFromNow);
        }

  

        public void Reschedule(DateTime date)
        {
            _date = date;
            var printer = new MedicalAppointmentPrinter();
            printer.Print(this);
        }

        public void OverwriteMonthAndDay(int month, int day)
        {
            _date = new DateTime(_date.Year, month, day);   
        }

        public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
        {
            _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
        }

        public DateTime GetDate() => _date;

    }

    
}
