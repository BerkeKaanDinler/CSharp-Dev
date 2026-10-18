/*public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Birinci tam sayıyı giriniz:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("İkinci tam sayıyı giriniz:");
        int b = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine($"Toplam: {a - b}");

    } 

}
*/


int currentSlot = 0;

while (currentSlot < 5)
{
    currentSlot++; // Crucial: the update happens before the continue check

    if (currentSlot == 3)
    {
        Console.WriteLine($"Skipping item slot {currentSlot}.");
        continue;
    }

    Console.WriteLine($"Successfully processed item in slot {currentSlot}.");
}

Console.WriteLine("Inventory scan complete!");