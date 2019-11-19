using System;

namespace OOAD_LABB_1
{
    class ChangeCarColor : Command
    {
        private readonly Car car;
        private readonly string color;

        public ChangeCarColor(Car car, string color)
        {
            this.car = car;
            this.color = color;
        }
        public void Execute()
        {    
            Console.WriteLine($"Setting color {this.color}");
            car.color = color;
        }

        public void Undo()
        {
            Console.WriteLine($"Undoing color");
            car.color = color;          
        }

        public void Redo()
        {
            Console.WriteLine($"Redoing color");
            car.color = color;          
        }


    }
}
