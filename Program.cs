namespace Laboratoy_work_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University fcn = new University("ФКН");

            Console.WriteLine(fcn.Name);

            Institute infsys = new Institute("ИС", "к111");
            Institute dt = new Institute("ЦТ", "к222");
            Institute itu = new Institute("ИТУ", "к333");
            Institute tozi = new Institute("ТОЗИ", "к444");
            Institute piit = new Institute("ПИИТ", "к555");


        }
    }
}
