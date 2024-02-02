using LinqSchool.Models;

namespace LinqSchool.Data;

public static class DataGenerator
{
	private static string[] _names =
	{
		"SpongeBob SquarePants",
		"Patrick Star",
		"Squidward Tentacles",
		"Sandy Cheeks",
		"Mr. Krabs",
		"Plankton",
		"Gary the Snail",
		"Mrs. Puff",
		"Pearl Krabs",
		"Mermaid Man",
		"Barnacle Boy",
		"Karen Plankton",
		"Larry the Lobster",
		"Mrs. SquarePants",
		"King Neptune",
		"Patchy the Pirate",
		"Potty the Parrot",
		"Flying Dutchman",
		"Bubble Bass",
		"Man Ray"
	};

	private static int[] _numbers =
	{
		87, 42, 15, 64, 96, 3, 30, 58, 70, 91, 27, 69, 49, 81, 10, 53, 76, 22, 97, 38
	};

	public static Character[] GenerateCharacters()
	{
		return _names.Select((name, i) => new Character(i, name, _numbers[i])).ToArray();
	}

	public static IEnumerable<int> GetSelectedIds()
	{
		return new int[] { 4, 5, 8, 10 };
	}
}