using LinqSchool.Data;
using LinqSchool.Quizzes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LinqSchool.Lessons;

public class Lesson1
{
	public Lesson1() { }

	public void Run()
	{
		var data = DataGenerator.GenerateCharacters();

		var loopSolution = new LoopSolution1(data);
		var linqSolution = new LinqSolution1(data);

		Console.WriteLine("Loop Solution: _________");
		PrintSolution(loopSolution);
		Console.WriteLine("Linq Solution: _________");
		PrintSolution(linqSolution);
	}

	private void PrintSolution(ISolution1 solution)
	{
		var selectedIds = DataGenerator.GetSelectedIds();

		var answerA = solution.TransformCharactersToCheckboxes();
		var answerB = solution.WhoHasAnEvenNumberOfApples();
		var answerC = solution.WhoHasTheseIds(selectedIds);
		var answerD = solution.WhoHasAPrimeNumberOfApples();

		Console.Write(JsonSerializer.Serialize(answerA));
		Console.WriteLine();
		Console.Write(JsonSerializer.Serialize(answerB));
		Console.WriteLine();
		Console.Write(JsonSerializer.Serialize(answerC));
		Console.WriteLine();
		Console.Write(JsonSerializer.Serialize(answerD));
		Console.WriteLine();
	}
}
