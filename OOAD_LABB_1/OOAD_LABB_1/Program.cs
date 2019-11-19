using System;
using System.Collections.Generic;
using System.Collections;

namespace OOAD_LABB_1
{
    class Program
    {
        static void Main(string[] args)
        { 

            //Brand and NumberOfDoors are obligatory and can only be set when object is built. 
            var jaguar = Car.Builder.Start().
                SetBrand(Brand.Jaguar).
                SetNumberOfDoors(2).
                SetColor("Orange").
                SetHasSunRoof(true).
                Build();

            Console.WriteLine($"{jaguar}");
            Console.WriteLine($"-------------\n");

            CommandManager manager = CommandManager.getInstance();
            manager.Execute(new ChangeCarColor(jaguar, "White"));     
            manager.Execute(new ChangeCarColor(jaguar, "Purple"));  
            manager.Execute(new ChangeCarColor(jaguar, "Green"));   
            manager.Execute(new ChangeCarColor(jaguar, "Red")); 
            Console.WriteLine($"-------------");

            manager.Undo();
            Console.WriteLine($"Current color is: {jaguar.color}");
            manager.Undo();
            Console.WriteLine($"Current color is: {jaguar.color}");
            manager.Undo();
            Console.WriteLine($"Current color is: {jaguar.color}");
            manager.Undo(); //should not be able to undo further
            manager.Undo(); //should not be able to undo further
            Console.WriteLine($"-------------");
         
            manager.Redo();
            Console.WriteLine($"Current color is: {jaguar.color}");
            manager.Redo();
            Console.WriteLine($"Current color is: {jaguar.color}");
            manager.Redo();
            Console.WriteLine($"Current color is: {jaguar.color}");
            Console.WriteLine($"-------------");
            manager.Undo();
            Console.WriteLine($"Current color is: {jaguar.color}");





        }
    }
}
