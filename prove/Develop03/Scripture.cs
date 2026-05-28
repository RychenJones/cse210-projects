using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

/*
This handles most things happening with the scripture.
It calls Reference and Word to compute values and returns it to main.
*/
public class RJScripture
{   
    private string _RJverseText;
    private string[] _RJsplitWords;
    private List<RJWord> _RJwordsList;
    private int _RJnumberHidden;

    public RJScripture(string RJverse)
    {
        /* Constuctor for 1 value */
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

    public int RJgetListLength()
    {
        /* Get the length of the word list */
        return _RJwordsList.Count();
    }
    public int RJgetNumberHidden()
    {
        /* Get the amount of words that are hidden */
        return _RJnumberHidden;
    }

    public void RJHideWords()
    {
        /* Call Word to hide 3 random words from those that are unhidden */
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
        /* Return the verse with hidden words shown with underscores */
        string RJverse = "";

        foreach (RJWord word in _RJwordsList)
        {
            RJverse += word.returnWord();
        }
        return RJverse;
    }
}