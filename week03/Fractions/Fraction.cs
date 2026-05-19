public class Fraction
{
    private int _top;
    private int _bottom;

    //3 Fraction constructors

    // constructor with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // constructor with one parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //getters and setters methods
    public int GetTop()
    {
        return _top;
    }

    //method to set the value of the top of the fraction to the user
    public void SetTop(int top)
    {
        _top = top;
    }

    //method to return the value of the bottom of the fraction to the user
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //method to return the fraction as a string to the user
    public string GetFractionString()
    {
        return $" {_top}/{_bottom}";
    }
    
    //method to return the decimal value of the fraction to the user
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

  
}