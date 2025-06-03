public class Assignment
{
    private Student _student;
    private TextBook _textBook;

    public Assignment(string name, string topic, string section, string problem)
    {
        _student = new Student(name);
        _textBook = new TextBook(topic, section, problem);
    }

    public string GetSummary()
    {
        return $"Student: {_student.GetStudentName()}, Topic: {_textBook.GetTopic()}";
    }

    public string GetHomework()
    {
        return $"Section: {_textBook.GetSection()} Problems {_textBook.GetProblem()}";
    }
}