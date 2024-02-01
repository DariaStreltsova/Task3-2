using System;




namespace BaseClass
{
   sealed class OneDimensionalArray : BaseClass
   {
       private int[] array;
       public OneDimensionalArray(int n, bool InputByUser = false)
       {
           array = new int[n];
           if(!InputByUser)
           {
               RandomInput();
           }
           else
           {
               UserInput();
           }
       }
  
       public override void RandomInput(){
           Random el = new Random();
           for(int i = 0; i < array.Length; i ++){
               array[i] = el.Next(0, 1000);
           }
       }
  
       public override void UserInput(){
           for(int i = 0; i < array.Length; i ++){
               Console.WriteLine("Введите элемент");
               int el = int.Parse(Console.ReadLine());
               array[i] = el;
           }
       }
  
       public override void average(){
           double sum = 0;
           for(int i = 0; i < array.Length; i ++){
               sum = sum + array[i];
           }
           Console.WriteLine(sum/array.Length);
       }

       public override void Output(){
           for(int i = 0; i < array.Length; i ++){
               Console.Write(array[i] + " ");
           }
       }
   }
}
