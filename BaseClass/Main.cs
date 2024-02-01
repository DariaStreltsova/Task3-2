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
               i.Output();
               Console.WriteLine($"Среднее значение в {i.GetType()} массиве:");
               i.average();
           }
       }
   }
}
