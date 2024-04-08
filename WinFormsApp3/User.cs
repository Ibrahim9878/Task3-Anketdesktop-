namespace WinFormsApp3;
public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime Date { get; set; }
    public override string ToString()
    {
        return $"{Name}";
    }

    public User(string name, string surname, string email, string phone, DateTime date)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Phone = phone;
        Date = date;
    }
    public User()
    {
        Name = string.Empty;
        Surname= string.Empty;
        Email = string.Empty;
        Phone = string.Empty;
        Date = DateTime.MinValue;
    }
}
