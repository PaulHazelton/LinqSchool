using LinqSchool.Models;

namespace LinqSchool.Quizzes;

public class LinqSolution1 : ISolution1
{
	private readonly Character[] _characters;

	public LinqSolution1(Character[] characters)
	{
		_characters = characters;
	}

	public IEnumerable<ItemCheckbox<Character>> TransformCharactersToCheckboxes()
	{
		throw new NotImplementedException();
	}

	public IEnumerable<string> WhoHasAnEvenNumberOfApples()
	{
		throw new NotImplementedException();
	}

	public IEnumerable<string> WhoHasTheseIds(IEnumerable<int> selectedIds)
	{
		throw new NotImplementedException();
	}

	public IEnumerable<string> WhoHasAPrimeNumberOfApples()
	{
		throw new NotImplementedException();
	}
}
