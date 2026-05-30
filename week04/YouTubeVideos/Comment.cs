public class Comment
{
    // create a method that tracks both name of person and 
    //who made the comment and the txt

    //create name of person varible
    private string _person;

    //create text of comment varible
    private string _text;

    //constructor to of varibles
    public Comment(string person, string text)
    {
        _person = person;
        _text = text;
    }

    //method display
    public string GetDisplayText()
    {
        return $"{_person} : {_text}";
    }


}