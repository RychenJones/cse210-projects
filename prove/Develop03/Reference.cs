public class RJReference
{
    private string _RJbook;
    private int _RJchapter;
    private string _RJverse;

    public RJReference()
    {
        _RJbook = "";
        _RJchapter = 0;
        _RJverse = "";
    }
    public RJReference(string RJbook, int RJchapter, int[] RJverse)
    {
        if (RJverse.Count() == 1)
        {
            _RJverse = (RJverse.First()).ToString();
        }
        else
        {
            _RJverse = $"{RJverse.First()}-{RJverse.Last()}";
        }

        _RJbook = RJbook;
        _RJchapter = RJchapter;
    }

    public string RJReturnReference()
    {
        string RJreference = $"{_RJbook} {_RJchapter}:{_RJverse}";
        return RJreference;
    }
}
