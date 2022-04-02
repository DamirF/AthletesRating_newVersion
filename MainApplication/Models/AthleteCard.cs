using AthletesRating.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;

/// <summary>
/// Athlete information card
/// </summary>

public class AthleteCard
{
	private int ID;
	private Account accountInfo;
	private FullName fullName;
	private string Gender;
	private DateTime BirthDate;
	private int Height;
	private int Weight;
	private List<Medal> AthleteMedals;

	public AthleteCard(int id, string email, string login, string password, bool isAdmin)
    {
		ID = id;
		accountInfo = new Account(email, login, password, isAdmin);
    }

	public AthleteCard(string surname, string name, string patronymic, string gender, DateTime birthDate, string email, string login, string password, bool isAdmin)
	{
		accountInfo = new Account(email, login, password, isAdmin);
		fullName = new FullName(surname, name, patronymic);
		Gender = gender;
		BirthDate = birthDate;
		Height = 0;
		Weight = 0;
		AthleteMedals = new List<Medal>();
	}

	public AthleteCard(int id, string surname, string name, string patronymic, string gender, DateTime birthDate, int height, int weight, List<Medal> medals, string email, string login, string password, bool isAdmin)
    {
		ID = id;
		accountInfo = new Account(email, login, password, isAdmin);
		fullName = new FullName(surname, name, patronymic);
		Gender = gender;
		BirthDate = birthDate;
		Height = height;
		Weight = weight;
		AthleteMedals = medals;
    }

	public AthleteCard(int id, string surname, string name, string patronymic, string gender, DateTime birthDate, int height, int weight, string medals, string email, string login, string password, bool isAdmin)
	{
		ID = id;
		accountInfo = new Account(email, login, password, isAdmin);
		fullName = new FullName(surname, name, patronymic);
		Gender = gender;
		BirthDate = birthDate;
		Height = height;
		Weight = weight;
		AthleteMedals = DeserializeAchievements(medals);
	}

	public int GetID() => ID;
	public Account GetAccountInfo() => accountInfo;
	public void SetAccountInfo(Account account) => accountInfo = account;
	public FullName GetFullName() => fullName;
	public void SetFullName(FullName newFullName) => fullName = newFullName;
	public void SetFullName(string surname, string name, string patronymic) =>
		fullName = new FullName(surname, name, patronymic);
	public DateTime GetBirthDate() => BirthDate;
	public void SetBirthDate(DateTime newBirthDate) => BirthDate = newBirthDate;
	public string GetGender() => Gender;
	public void SetHeight(int height) => Height = height;
	public int GetHeight() => Height;
	public void SetWeight(int weight) => Weight = weight;
	public int GetWeight() => Weight;
	public List<Medal> GetAchievements() => AthleteMedals;

	public int CalculateAge()
	{
		int age = DateTime.Now.Year - BirthDate.Year;
		if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
			age++;
		return age;
	}

	public string SerializeAchievements() => 
		JsonConvert.SerializeObject(AthleteMedals);

	public List<Medal> DeserializeAchievements(string obj) => JsonConvert.DeserializeObject<List<Medal>>(obj);

	public void NewUserRegistration(SqlConnection connection)
    {
		SqlCommand registrationAccounts = new SqlCommand("INSERT INTO [Accounts] (Email, Login, Password, IsAdmin) VALUES (@email, @login, @password, @isAdmin)", connection);
		registrationAccounts.Parameters.AddWithValue("@email", accountInfo.GetEmail());
		registrationAccounts.Parameters.AddWithValue("@login", accountInfo.GetLogin());
		registrationAccounts.Parameters.AddWithValue("@password", accountInfo.GetPassword());
		registrationAccounts.Parameters.AddWithValue("@isAdmin", Convert.ToInt32(accountInfo.IsAdmin()));

		SqlCommand registrationAthletes = new SqlCommand("INSERT INTO [Athletes] (Surname, Name, Patronymic, Gender, BirthDate, Height, Weight, Achievements) VALUES (@surname, @name, @patronymic, @gender, @birthDate, @null, @null, @nullList)", connection);
		registrationAthletes.Parameters.AddWithValue("@surname", fullName.GetSurname());
		registrationAthletes.Parameters.AddWithValue("@name", fullName.GetName());
		registrationAthletes.Parameters.AddWithValue("@patronymic", fullName.GetPatronymic());
		registrationAthletes.Parameters.AddWithValue("@gender", Gender);
		registrationAthletes.Parameters.AddWithValue("@birthDate", BirthDate);
		registrationAthletes.Parameters.AddWithValue("@null", 0);
		registrationAthletes.Parameters.AddWithValue("@nullList", SerializeAchievements());

		registrationAccounts.ExecuteNonQuery();
		registrationAthletes.ExecuteNonQuery();
    }

	/*
	 Необходимые доработки:
	1) Функция считывания данных с БД
	2) Конструктор для считывания данных с БД (?)
	3) Десериализация списка достижений
	4) Добавление медали/достижения (?)
	 */
}
