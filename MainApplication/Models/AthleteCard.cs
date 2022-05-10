using AthletesRating.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

/// <summary>
/// Athlete information card
/// </summary>

public class AthleteCard
{
    #region Fields and Options
	public Account accountInfo { get; private set; }
	public FullName fullName { get; private set; }
	public string Gender { get; private set; }
	public DateTime BirthDate { get; private set; }
	public int Height { get; private set; }
	public int Weight { get; private set; }

	private List<Medal> AthleteMedals;
	public int sportType { get; private set; }
	public int nationality { get; private set; }
	#endregion

	#region Constructors

	/// <summary>
	/// Конструктор для авторизации
	/// </summary>
	/// <param name="email"></param>
	/// <param name="login"></param>
	/// <param name="password"></param>
	/// <param name="isAdmin"></param>
	public AthleteCard(string email, string login, string password, bool isAdmin)
    {
		accountInfo = new Account(email, login, password, isAdmin);
    }

	/// <summary>
	/// Конструктор для регистрации
	/// </summary>
	/// <param name="surname"></param>
	/// <param name="name"></param>
	/// <param name="patronymic"></param>
	/// <param name="gender"></param>
	/// <param name="birthDate"></param>
	/// <param name="email"></param>
	/// <param name="login"></param>
	/// <param name="password"></param>
	/// <param name="isAdmin"></param>
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

	/// <summary>
	/// Полный конструктор
	/// </summary>
	/// <param name="surname"></param>
	/// <param name="name"></param>
	/// <param name="patronymic"></param>
	/// <param name="gender"></param>
	/// <param name="birthDate"></param>
	/// <param name="height"></param>
	/// <param name="weight"></param>
	/// <param name="medals"></param>
	/// <param name="email"></param>
	/// <param name="login"></param>
	/// <param name="password"></param>
	/// <param name="isAdmin"></param>
	public AthleteCard(string surname, string name, string patronymic, string gender, DateTime birthDate, int height, int weight, string medals, int nationality, int sportType, string email, string login, string password, bool isAdmin)
	{
		accountInfo = new Account(email, login, password, isAdmin);
		fullName = new FullName(surname, name, patronymic);
		Gender = gender;
		BirthDate = birthDate;
		Height = height;
		Weight = weight;
		AthleteMedals = DeserializeAchievements(medals);
		this.nationality = nationality;
		this.sportType = sportType;
	}

	/// <summary>
	/// Конструктор для поисковика
	/// </summary>
	/// <param name="surname"></param>
	/// <param name="name"></param>
	/// <param name="patronymic"></param>
	/// <param name="gender"></param>
	/// <param name="birthDate"></param>
	/// <param name="height"></param>
	/// <param name="weight"></param>
	/// <param name="medals"></param>
	/// <param name="nationality"></param>
	/// <param name="sportType"></param>
	public AthleteCard(string surname, string name, string patronymic, string gender, DateTime birthDate, int height, int weight, string medals, int nationality, int sportType, string login)
    {
		accountInfo = new Account("", login, "", false);
		fullName = new FullName(surname, name, patronymic);
		Gender = gender;
		BirthDate = birthDate;
		Height = height;
		Weight = weight;
		AthleteMedals = DeserializeAchievements(medals);
		this.nationality = nationality;
		this.sportType = sportType;
	}
    #endregion

    #region Setters
    public void SetAccountInfo(Account account) => accountInfo = account;
	public void SetFullName(FullName newFullName) => fullName = newFullName;
	public void SetFullName(string surname, string name, string patronymic) =>
		fullName = new FullName(surname, name, patronymic);
	public void SetBirthDate(DateTime newBirthDate) => BirthDate = newBirthDate;
	public void SetHeight(int height) => Height = height;
	public void SetWeight(int weight) => Weight = weight;
	public void SetSportType(int _sportType) => sportType = _sportType;
	public void SetNationality(int _nationality) => nationality = _nationality;

    #endregion
    public List<Medal> GetAchievements() => AthleteMedals;

	public int CalculateAge()
	{
		int age = DateTime.Now.Year - BirthDate.Year;
		if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
			age--;
		return age;
	}

	public string SerializeAchievements() => 
		JsonConvert.SerializeObject(AthleteMedals);

	public List<Medal> DeserializeAchievements(string obj) => JsonConvert.DeserializeObject<List<Medal>>(obj);

	public string CalculateRating()
	{
		double rating = 0;

		for (int i = 0; i < AthleteMedals.Count; i++)
		{
			switch(AthleteMedals[i].Level)
            {
				case Constants.WORLDLEVEL:
					rating += Constants.WORLDLEVEL_ACHIEVEMENT / AthleteMedals[i].Place;
					break;
				case Constants.OLYMPICLEVEL:
					rating += Constants.OLYMPICLEVEL_ACHIEVEMENT / AthleteMedals[i].Place;
					break;
				case Constants.LOCALLEVEL:
					rating += Constants.LOCALLEVEL_ACHIEVEMENT / AthleteMedals[i].Place;
					break;
			}
		}
		return Math.Round(rating, 2).ToString();
	}

	public void NewUserRegistration(SqlConnection connection)
    {
		SqlCommand registrationAccounts = new SqlCommand("INSERT INTO [Accounts] (Email, Login, Password, IsAdmin) VALUES (@email, @login, @password, @isAdmin)", connection);
		registrationAccounts.Parameters.AddWithValue("@email", accountInfo.Email);
		registrationAccounts.Parameters.AddWithValue("@login", accountInfo.Login);
		registrationAccounts.Parameters.AddWithValue("@password", accountInfo.Password);
		registrationAccounts.Parameters.AddWithValue("@isAdmin", Convert.ToInt32(accountInfo.isAdmin));

		SqlCommand registrationAthletes = new SqlCommand("INSERT INTO [Athletes] (Surname, Name, Patronymic, Gender, BirthDate, Height, Weight, Achievements, Nationality, SportType, Login) VALUES (@surname, @name, @patronymic, @gender, @birthDate, @null, @null, @nullList, @nullstr, @nullstr, @log)", connection);
		registrationAthletes.Parameters.AddWithValue("@surname", fullName.Surname);
		registrationAthletes.Parameters.AddWithValue("@name", fullName.Name);
		registrationAthletes.Parameters.AddWithValue("@patronymic", fullName.Patronymic);
		registrationAthletes.Parameters.AddWithValue("@gender", Gender);
		registrationAthletes.Parameters.AddWithValue("@birthDate", BirthDate);
		registrationAthletes.Parameters.AddWithValue("@null", 0);
		registrationAthletes.Parameters.AddWithValue("@nullList", SerializeAchievements());
		registrationAthletes.Parameters.AddWithValue("@nullstr", 0);
		registrationAthletes.Parameters.AddWithValue("@log", accountInfo.Login);

		registrationAccounts.ExecuteNonQuery();
		registrationAthletes.ExecuteNonQuery();
    }

	public void NewUserRegistration(SqlConnection connection, string gen)
	{
		Random rnd = new Random();
		SqlCommand registrationAccounts = new SqlCommand("INSERT INTO [Accounts] (Email, Login, Password, IsAdmin) VALUES (@email, @login, @password, @isAdmin)", connection);
		registrationAccounts.Parameters.AddWithValue("@email", accountInfo.Email);
		registrationAccounts.Parameters.AddWithValue("@login", accountInfo.Login);
		registrationAccounts.Parameters.AddWithValue("@password", accountInfo.Password);
		registrationAccounts.Parameters.AddWithValue("@isAdmin", Convert.ToInt32(accountInfo.isAdmin));

		SqlCommand registrationAthletes = new SqlCommand("INSERT INTO [Athletes] (Surname, Name, Patronymic, Gender, BirthDate, Height, Weight, Achievements, Nationality, SportType, Login) VALUES (@surname, @name, @patronymic, @gender, @birthDate, @height, @weight, @nullList, @nat, @st, @log)", connection);
		registrationAthletes.Parameters.AddWithValue("@surname", fullName.Surname);
		registrationAthletes.Parameters.AddWithValue("@name", fullName.Name);
		registrationAthletes.Parameters.AddWithValue("@patronymic", fullName.Patronymic);
		registrationAthletes.Parameters.AddWithValue("@gender", Gender);
		registrationAthletes.Parameters.AddWithValue("@birthDate", BirthDate);
		registrationAthletes.Parameters.AddWithValue("@height", rnd.Next(165, 200));
		registrationAthletes.Parameters.AddWithValue("@weight", rnd.Next(70, 100));
		registrationAthletes.Parameters.AddWithValue("@nullList", SerializeAchievements());
		registrationAthletes.Parameters.AddWithValue("@nat", rnd.Next(1, Constants.Countries.Length));
		registrationAthletes.Parameters.AddWithValue("@st", rnd.Next(1, Constants.SportTypes.Length));
		registrationAthletes.Parameters.AddWithValue("@log", accountInfo.Login);

		registrationAccounts.ExecuteNonQuery();
		registrationAthletes.ExecuteNonQuery();
	}
}
