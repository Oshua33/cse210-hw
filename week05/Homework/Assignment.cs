public class Assignment
{
    private string _studentName;
    private string _topic;
   

    //constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //method to display the assignment information
    public string GetStudentSummary()
    {
        return ($"\nStudent Name: {_studentName} \nTopic: {_topic}");
    }

    private string GetStudentName()
    {
        return _studentName;
    }
}