using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class RJScripture
{   
    private string _RJverseText;
    private string[] _RJsplitWords;
    private List<RJWord> _RJwordsList;
    private int _RJnumberHidden;

    public int RJgetListLength()
    {
        return _RJwordsList.Count();
    }
    public RJScripture(string RJverse)
    {
        _RJwordsList = new List<RJWord>();
        _RJverseText = RJverse;
        _RJsplitWords = _RJverseText.Split(' ');
        foreach (string word in _RJsplitWords)
        {
            RJWord RJnewWord = new RJWord(word);
            _RJwordsList.Add(RJnewWord);
        }
        _RJnumberHidden = 0;
    }

    public int RJgetNumberHidden()
    {
        return _RJnumberHidden;
    }

    public void RJHideWords()
    {
        int i = 0;
        while (i < 3)
        {
            Random RJrand = new Random();
            RJWord RJword = _RJwordsList[RJrand.Next(_RJwordsList.Count())];
            if (RJword.RJgetIsHidden() == false)
            {
                _RJnumberHidden++;
                i++;
                RJword.hideWord();
            }
            if (_RJnumberHidden == _RJwordsList.Count())
            {
                i++;
            }
        }
    }
    public string RJReturnVerse()
    {
        string RJverse = "";

        foreach (RJWord word in _RJwordsList)
        {
            RJverse += word.returnWord();
        }
        return RJverse;
    }
}