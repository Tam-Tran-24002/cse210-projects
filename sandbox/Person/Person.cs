class Person
{
    protected string _firstName;
    protected string _lastName;
    protected int _age;
    protected double _weight;

    public Person(string firstName, string lastName, int age, double weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    public string GetPersonInformation()
    {
        return $"{_firstName} {_lastName} is {_age} years old and weighs {_weight}";
    }
}