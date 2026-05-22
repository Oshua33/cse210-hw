using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    //variblE;
    private Reference _reference;
    private List<Word> _words;

    private Random _random = new Random();


    //constuctor
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        //create empty string to get each text 
        string[] words = text.Split(" ");

        //save each words in the object and to the list
        //now loop through each words to get each word and save as an object and store in the list or word
        foreach (string textword in words)
        {
            //create the word object geting the inputt
            Word word1 = new Word(textword);

            //add it to the list
            _words.Add(word1);

        }
    }

    public string GetDisplayText()
    {
        string result = "";
        
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return $" {_reference.GetDisplayText()} : {result} ";

    }
   
    //to hiderandomwords
    public void HideRandomWords(int numberToHide)
    {
        // numberToHide = 0;
        for (int i = 0; i < numberToHide; i++)
        {
            //get the number of text and get a random index number
            int numberoftext = _random.Next(_words.Count);

            //hide it with the hide method
            _words[numberoftext].Hide();
        }
    }

    //check if all words are hidden.
    public bool IsCompletelyHidden()
    {
        //use the foreach loop to loop through the words list and check if hideen
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
   
        } 
        return true;
    }
   

}