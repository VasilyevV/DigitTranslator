using System.Globalization;
using DigitTranslator;
class Consumer
{
    static void Main()
    {
        var rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            long Number = rnd.NextInt64(0, 999999999999);
            var muster = new Translator();
            var a = muster.Compilation(Number);
            Console.WriteLine(Number);
            Console.WriteLine(a);
        }

        Console.ReadLine();
    }

}