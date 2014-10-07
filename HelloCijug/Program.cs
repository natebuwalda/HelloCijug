namespace HelloCijug
{
    using System;

    using HelloCijug.Sample;

    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello CIJUG! Press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("Three and Five added together", SampleClass.Add(3, 5));
            Console.WriteLine("Hello CIJUG! Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
