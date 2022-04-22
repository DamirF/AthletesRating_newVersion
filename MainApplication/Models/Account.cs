public struct Account
{
    public string Email { get; private set; }
    public string Login { get; private set; }
    public string Password { get; private set; }
    public bool isAdmin { get; private set; }

    public Account(string email, string login, string password, bool is_Admin)
    {
        Email = email;
        Login = login;
        Password = password;
        isAdmin = is_Admin;
    }

    public void SetAdmin() => isAdmin = true;
    public void DelAdmin() => isAdmin = false;
}