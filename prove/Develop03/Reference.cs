public class RJReference
{
    private string _RJbook;
    private int _RJchapter;
    private string _RJverse;

    public RJReference(string RJbook, int RJchapter, int RJverse)
    {
        _RJbook = RJbook;
        _RJchapter = RJchapter;
        _RJverse = RJverse.ToString();
    }
    public RJReference(string RJbook, int RJchapter, int RJstartVerse, int RJendVerse)
    {
        _RJbook = RJbook;
        _RJchapter = RJchapter;
        _RJverse = $"{RJstartVerse}-{RJendVerse}";
    }

    public string RJReturnReference()
    {
        string RJreference = $"{_RJbook} {_RJchapter}:{_RJverse}";
        return RJreference;
    }
}
