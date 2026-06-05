public class WritingAssignment : Assignment
{
    private string _title;


    //constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    //method to display the writing assignment information
    public new string GetWritingInformation()
    {
        return ($"\nStudent Name: {GetStudentSummary()} \nTitle: {_title}");
    }
}