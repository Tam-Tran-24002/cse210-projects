using System.Security.Cryptography;
class Program
{
    public static void Main()
    {
        Person myPerson = new Person("John", "Revelator", 50, 180.0);
        Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 45, 279, "Knife");
        Console. WriteLine(myDoctor.GetPersonInformation());
        Console. WriteLine(myDoctor.GetDoctorInformation());

    }
}