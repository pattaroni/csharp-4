using System;

public class Student
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int BirthYear { get; set; }

    public int GetAge()
    {
        return DateTime.Now.Year - BirthYear;
    }
}
