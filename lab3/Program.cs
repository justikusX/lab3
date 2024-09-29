try
{
    Console.WriteLine("Введите Номер места от 1 до 36 :");
    int x = int.Parse(Console.ReadLine());
    int k = (x - 1) / 4 + 1;
    Console.WriteLine($"номер вашего купе:{k:F0}" +
        $"\n1-4 купе N^1" +
        $"\n5-8 купе N^2" +
        $"\n9-12 купе N^3" +
        $"\n13-16 купе N^4" +
        $"\n17-20 купе N^5" +
        $"\n21-24 купе N^6" +
        $"\n25-28 купе N^7" +
        $"\n29-32 купе N^8" +
        $"\n33-36 купе N^9");
}
catch
{
    Console.WriteLine("Error");
}