using System;




namespace BaseClass
{
   class Program{
       static void Main(){
           OneDimensionalArray one = new OneDimensionalArray(4);
           BaseClass one_1 = new OneDimensionalArray(8);


           TwoDimensionalArray two = new TwoDimensionalArray(4, 4);
           BaseClass two_2 = new TwoDimensionalArray(3, 5);


           StepArray step = new StepArray(5);
           BaseClass step_3 = new StepArray(2);


           BaseClass[] baseArray = new BaseClass[6] { one, one_1, two, two_2, step, step_3 };


           foreach (BaseClass i in baseArray)
           {
               Console.WriteLine($"{i.GetType()} массив: \n");
               i.Print();
               Console.WriteLine();
               Console.WriteLine($"Среднее значение в {i.GetType()} массиве:");
               i.average();
               Console.WriteLine();
           }
           
           Console.WriteLine("Базовый интерфейс");

            IBase[] ar = new IBase[3] {new OneDimensionalArray(5), new TwoDimensionalArray(2, 3), new StepArray(4)};

            foreach (IBase i in ar)
            {
                Console.WriteLine($"{i.GetType()} массив: \n");
               i.Print();
               Console.WriteLine();
               Console.WriteLine($"Среднее значение в {i.GetType()} массиве:");
               i.average();
               Console.WriteLine();
            }

            Console.WriteLine("Интерфейс");

            IPrinter[] array = new IPrinter[4]{new OneDimensionalArray(6), new TwoDimensionalArray(3, 5), new StepArray(4), new DaysOfTheWeek()};

            foreach(IPrinter i in array){
                Console.WriteLine($"{i.GetType()} массив: \n");
               i.Print();
            }
            

       }
   }
}