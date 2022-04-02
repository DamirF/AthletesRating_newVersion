public struct FullName
{
	private string Surname;
	private string Name;
	private string Patronymic;

	public FullName(string surname, string name, string patronymic)
	{
		Surname = surname;
		Name = name;
		Patronymic = patronymic;
	}

	public string GetSurname() => Surname;
	public string GetName() => Name;
	public string GetPatronymic() => Patronymic;
}