public class Word
{
    //private varibles
    private string _text;
    private bool _isHidden;

    //constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

  
    //method to hide the text wich will be called later
    public void Hide()
    {
        _isHidden = true;
    }

    // check is its hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

    public void Show()
    {
        _isHidden = true;
    }
}