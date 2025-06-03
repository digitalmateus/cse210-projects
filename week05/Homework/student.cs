using System;

public class Student
{
    protected string _name;

    public Student(string name)
    {
        _name = name;
    }

    public string GetStudentName()
    {
        return _name;
    }

    
}