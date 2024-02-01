using System;


namespace BaseClass
{
   sealed class StepArray : BaseClass
   {
       private int[][] array;


       public StepArray(int wid, bool InputByUser = false){
           array = new int[wid][];
           if(!InputByUser){
               RandomInput();
           }
           else{
               UserInput();
           }
       }

       public override void RandomInput(){
           Random rnd = new Random();
           for(int i = 0; i < array.Length; i ++){
               int LenEl = rnd.Next(0, 10);
               int[] interAr = new int[LenEl];
               for(int j = 0; j < LenEl; j ++){
                   interAr[j] = rnd.Next(0, 1000);
               }
               array[i] = interAr;
           }
       }

       public override void UserInput(){
           for(int i = 0; i < array.Length; i++){
               Console.WriteLine("Введите количество элементов в строке");
               int LenEl = int.Parse(Console.ReadLine());
               int[] interAr = new int[LenEl];
               for(int j = 0; j < LenEl; j++){
                   Console.WriteLine("Введите элемент");
                   int el = int.Parse(Console.ReadLine());
                   interAr[j] = el;
               }
               array[i] = interAr;
           }
       }

       public override void average(){
           decimal sum = 0;
           int col = 0;
           for(int i = 0; i < array.Length; i ++){
               for(int j = 0; j < array[i].Length; j ++){
                   sum = sum + array[i][j];
                   col++;
               }
           }
           Console.WriteLine(sum/col);
       }

       public override void Output(){
           for(int i = 0; i < array.Length; i++){
               for(int j = 0; j < array[i].Length; j++){
                   Console.Write(array[i][j] + " ");
               }
               Console.WriteLine();
           }
       }
   }
}
