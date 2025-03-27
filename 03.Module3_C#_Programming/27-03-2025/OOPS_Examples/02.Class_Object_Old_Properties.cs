using System;

class Person
{
    // Data
    private string _name;
    private int  _age;


    // Properties
     // Old Properties style
    public string Name { 
        get{
            return _name;
        }

        set
        {
            _name = value;
        }
     }
    public int Age { 
        get{
            return _age;
        }

        set
        {
            _age = value;
        }
     }


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