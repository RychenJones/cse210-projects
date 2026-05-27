using System.Runtime.ConstrainedExecution;

public class RJWord
{
    private string _RJword;
    private bool _RJisHidden;
    public RJWord(string RJnewWord)
    {
        _RJword = RJnewWord;
        _RJisHidden = false;
    }
    public string returnWord()
    {
        if (_RJisHidden)
        {
            int RJwordLength = _RJword.Length;
            string RJline = "";
            for (int i = 0; i < RJwordLength; i++)
            {
                RJline = RJline + "_";
            }
            return RJline + " ";
        }
        else
        {
            return _RJword + " ";
        }
    }
    public bool RJgetIsHidden()
    {
        return _RJisHidden;
    }

    public void hideWord()
    {
        _RJisHidden = true;
    }
}