namespace LinqSchool.Models;

public class Character
{
	public int Id { get; private set; }
	public string Name { get; private set; }
	public int NumberOfApples { get; private set; }

	public Character(int id, string name, int appleCount)
	{
		Id = id;
		Name = name;
		NumberOfApples = appleCount;
	}
}