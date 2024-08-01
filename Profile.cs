namespace Employee.Console;
using System;

public class Profile
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public GenderEnum Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool IsActive { get; set; }

    public Profile(
        int employeeID,
        string firstName,
        string middleName,
        string lastName,
        string email,
        GenderEnum gender,
        DateTime dateOfBirth,
        bool isActive
    )
    {
        EmployeeID = employeeID;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        Email = email;
        Gender = gender;
        DateOfBirth = dateOfBirth;
        IsActive = isActive;
    }

    public override string ToString()
    {
        return $"EmployeeID: {EmployeeID},\n Name: {MiddleName}, {FirstName}, {LastName.Substring(0, 1)}, \nDateOfBirth: {DateOfBirth.ToShortDateString()}, \nGender: {Gender}, \nIsActive: {IsActive})\n";
    }

}
