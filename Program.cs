using System;
using System.Collections.Generic;

namespace foreachArray
{
    class Program
    {
        static void Main(string[] args)
        {

         var numbers = new List<int>{1,3,5,7,9,11,20};
        
         foreach (var x in numbers){
             if (x % 2 != 0){
                 Console.WriteLine(x);

             }
         }
              
             
         
        }
    }
}
