public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;
    public MathAssignment(string name, string topic, string reading, string problems) : base(name, topic)
    {
        _textbookSection = reading;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";

    }
}
