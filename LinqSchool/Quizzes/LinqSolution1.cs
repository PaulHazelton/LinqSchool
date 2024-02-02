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
		//throw new NotImplementedException();
		return _characters.Select(c => new ItemCheckbox<Character>()
		{
			DisplayText = c.Name,
			Item = c
		});
	}

	public IEnumerable<string> WhoHasAnEvenNumberOfApples()
	{
		//throw new NotImplementedException();
		return _characters.Where(c => c.NumberOfApples % 2 == 0).Select(c => c.Name);
	}

	public IEnumerable<string> WhoHasTheseIds(IEnumerable<int> selectedIds)
	{
		//throw new NotImplementedException();
		return _characters.Where(c =>  selectedIds.Contains(c.Id)).Select(c => c.Name);
	}

	public IEnumerable<string> WhoHasAPrimeNumberOfApples()
	{
		throw new NotImplementedException();
	}
}