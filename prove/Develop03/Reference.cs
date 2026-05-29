/*
This class takes care of formatting the reference information into a standard reference format.
*/
public class RJReference
{
    private string _RJbook;
    private int _RJchapter;
    private string _RJverse;

    public RJReference(string RJbook, int RJchapter, int RJverse)
    {
        /* Constructor for 3 inputs */
        _RJbook = RJbook;
        _RJchapter = RJchapter;
        _RJverse = RJverse.ToString();
    }
    public RJReference(string RJbook, int RJchapter, int RJstartVerse, int RJendVerse)
    {
        /* Constructor for 4 inputs */
        _RJbook = RJbook;
        _RJchapter = RJchapter;
        _RJverse = $"{RJstartVerse}-{RJendVerse}";
    }

    public string RJReturnReference()
    {
        /* Returns a properly formatted string */
        string RJreference = $"{_RJbook} {_RJchapter}:{_RJverse}";
        return RJreference;
    }
}
