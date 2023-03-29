using TabletopBattleSimApp.Interfaces;

namespace TabletopBattleSimApp.Objects;

public class D3Dice : IDice
{
	public int TopSide { get; set; }

	public D3Dice()
	{
	}

	public int Roll()
	{
		TopSide = new Random().Next(1, 4); 
		return TopSide;
	}

	public void Print()
	{
		Console.WriteLine($"{TopSide}");
	}

	public override string ToString()
	{
		return $"D3: {TopSide}";
	}
}