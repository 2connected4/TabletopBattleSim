using TabletopBattleSimApp.Objects;

namespace TabletopBattleSimApp;
class Program
{
    static void Main(string[] args)
    {
        D6Dice d6 = new D6Dice();
        D3Dice d3 = new D3Dice();

        Console.WriteLine("\nInit:");

        Console.WriteLine(d6);
        Console.WriteLine(d3);

        Console.WriteLine("\nRolls:");

        d6.Roll();
        d3.Roll();

        Console.WriteLine(d6);
        Console.WriteLine(d3);

    }
}
