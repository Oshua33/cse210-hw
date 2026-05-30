public class Video
{
    //tracking 
    // 1. track the title
    // varable 
    private string _title;

    //2. track the author, varable author
    private string _author;

    //3. track the length of video
    private int _lenght;

    //each vido should store list of comment
    // create variable list of comments comes from class comment
    private List<Comment> _comments = new List<Comment>();

    //create a comment class, which the commet above will be define by.

    //create the constructor that initalizes the object with only attributes of author, title and lenght. 
    public Video( string author, string title, int length)
    {
        _author = author;
        _title = title;
        _lenght = length;

        //to get each text as comment wich is a list
        //create empty string to get of text seperated by space 
        // string[] comments = text.Split(" ");

        // //save each text as a list.
        // foreach (string textcomment in comments)
        // {
        //     //get the input from user
        //     Comment comment = new Comment(textcomment);
        //     _comments.Add(comment);
            
        // }

    }

    // now let get the methods
    public void AddComment(Comment newComment)
    {
     _comments.Add(newComment);

    }

    public void DisplayAllComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
        }
        
    }

    public int GetCountComment()
    {
        return _comments.Count();
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($" title : {_title}");
        Console.WriteLine($" auhor : {_author}");
        Console.WriteLine($" lenght : {_lenght}");
        Console.WriteLine($" numberofcomment : {GetCountComment()}");

    }


    
}