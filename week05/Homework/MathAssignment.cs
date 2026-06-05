public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    //constructor
    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    //method to display the math assignment information
    public new string GetHomeworkList()
    {
        return ($"\nStudent Name: {GetStudentSummary()} \nSection: {_section} \nProblems: {_problems}");
    }
}