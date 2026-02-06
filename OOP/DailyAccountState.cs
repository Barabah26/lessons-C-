using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class DailyAccountState
    {
        public int InitialState { get; }

        public int SumOfOperations { get; }

        public DailyAccountState(
            int initialState,
            int sumOfOperations)
        {
            InitialState = initialState;
            SumOfOperations = sumOfOperations;
        }

        public int EndOfDayState
        {
            get
            {
                return InitialState + SumOfOperations;
            } 
        }

        public string Report
        {
            get {
                return $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
            }
        }
    }
}
