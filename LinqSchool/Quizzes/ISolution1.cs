using LinqSchool.Models;

namespace LinqSchool.Quizzes;

public interface ISolution1
{
	IEnumerable<ItemCheckbox<Character>> TransformCharactersToCheckboxes();
	IEnumerable<string> WhoHasAnEvenNumberOfApples();
	IEnumerable<string> WhoHasTheseIds(IEnumerable<int> selectedIds);
	IEnumerable<string> WhoHasAPrimeNumberOfApples();
}