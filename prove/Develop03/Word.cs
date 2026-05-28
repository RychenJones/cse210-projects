using System.Runtime.ConstrainedExecution;

/*
This class manages each indivudual word and whether it is shown or hidden.
*/
public class RJWord
{
    private string _RJword;
    private bool _RJisHidden;
    public RJWord(string RJnewWord)
    {
        /* Constuctor with 1 value */
        _RJword = RJnewWord;
        _RJisHidden = false;
    }
    public string returnWord()
    {
        /* Returns a single word. The word is underscored if it is hidden. */
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
        /* Return whether the word is hidden or not. */
        return _RJisHidden;
    }

    public void hideWord()
    {
        /* Hide the given word. */
        _RJisHidden = true;
    }
}