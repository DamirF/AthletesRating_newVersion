public struct Account
{
    private string Email;
    private string Login;
    private string Password;
    private bool isAdmin;

    public Account(string email, string login, string password, bool is_Admin)
    {
        Email = email;
        Login = login;
        Password = password;
        isAdmin = is_Admin;
    }

    public string GetEmail() => Email;
    public string GetLogin() => Login;
    public string GetPassword() => Password;
    public bool IsAdmin() => isAdmin;

    public void SetAdmin() => isAdmin = true;
    public void DelAdmin() => isAdmin = false;
}