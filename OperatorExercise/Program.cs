namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Original Variables for add, sub, mul
            int a = 17;
            int b = 4;

            //Add
            int sum = a + b;
            
            //Suntract
            int difference = a - b;
            
            //Multiply
            int product = a * b;


            //____________________________________________________
            //New variables for div and mod
            int w = 384;
            int s = 43;

            
            //Divide
            int quotient = w / s;
            
            //Modolus
            int remainder = w % s;

            //Answers to console
            Console.WriteLine($"{a} + {b} is {sum}.");
            Console.WriteLine($"{a} - {b} is {difference}.");
            Console.WriteLine($"{a} * {b} is {product}.");
            Console.WriteLine($"{w} / {s} is {quotient} remainder {remainder}.");


            //_____________________________________________________
            //Exercise 2
            //

            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a cirlce with a radius of {radius} is {area}");




        }
        //New method Area of Circle, return double, add param double radius, add formula
        public static double AreaOfCircle(double radius)
        {

            double area = Math.PI * Math.Pow( radius, 2 );
            return area;

        }
    }
}
