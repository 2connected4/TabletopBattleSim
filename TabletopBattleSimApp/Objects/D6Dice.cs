using TabletopBattleSimApp.Interfaces;

namespace TabletopBattleSimApp.Objects;

public class D6Dice : IDice
{
	public int TopSide { get; set; }

	public D6Dice()
	{
	}

	public int Roll()
	{
		TopSide = new Random().Next(1, 7); 
		return TopSide;
	}

	public void Print()
	{
		Console.WriteLine($"{TopSide}");
	}

	public override string ToString()
	{
		return $"D6: {TopSide}";
	}
}