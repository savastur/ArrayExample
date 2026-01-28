namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thing = 0;
            string[] fruits = new string[7];
            fruits[0] = "apple";
            fruits[1] = "bananna";
            fruits[2] = "kiwi";
            fruits[3] = "tomato";
            fruits[4] = "pineapple";
            fruits[5] = "dragon fruit";
            fruits[6] = "watermellon";
            //fruits[7] = "tangerine"; out of range causes it to crash

            Console.WriteLine(fruits[3]);


            
            
            //pause
            Console.Read();
        }
    }
}
