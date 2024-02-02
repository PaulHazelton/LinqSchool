namespace LinqSchool.Models;

public class ItemCheckbox<T>
{
	public required T Item { get; init; }
	public required string DisplayText { get; init; }
}