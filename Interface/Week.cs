using System;

namespace BaseClass{
    class DaysOfTheWeek : IPrinter{
        public void Print()
        {
            Console.WriteLine("Понедельник, вторник, среда, четверг, пятница, суббота, воскресенье");
        }
    }
}