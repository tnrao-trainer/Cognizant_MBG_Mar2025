class Person
{
    // Data
    // Auto-implemented properties
    public string Name { get; set; }
    public int Age { get; set; }


    // Methods
    public void PrintDetails()
    {
        Console.WriteLine($"Name : {Name}, Age : {Age}");
    }
}


class Program{
    static void Main(){

        Person p1 = new  Person();
        p1.Name = "Scott";
        p1.Age = 26;
        p1.PrintDetails();
        
    }
}