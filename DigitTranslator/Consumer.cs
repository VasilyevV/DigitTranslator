using System.Globalization;
using DigitTranslator;
class Consumer
{
    static void Main()
    {
        var rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            long Number = rnd.Next(0, 999999999);//Random накладывает ограничения Int32, поэтому здесь в качестве max 9-значное число,
            var muster = new Translator();// но реализованный класс позваляет переводить до 12-значных значений (999 млрд) включительно
            var a = muster.Compilation(Number);
            Console.WriteLine(Number);
            Console.WriteLine(a);
        }

        Console.ReadLine();
    }

}