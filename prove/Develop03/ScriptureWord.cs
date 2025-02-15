public class ScriptureWord
{
    private string _word;

    // flag for making sure the same
    // word isn't hidden twice and
    // to be able to check when every 
    // word is hidden.
    private bool _isHidden;

    public ScriptureWord()
    {
        _word = "";
        _isHidden = false;
    }

    public ScriptureWord(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool hiddeness)
    {
        _isHidden = hiddeness;
    }

    // have this so each time it also adds the space.
    public void DisplayWord()
    {
        Console.Write(_word + " ");
    }

    // changes _word to be all underscores
    // and checks the flag that it is hidden
    // for RandomHide() in the Scripture class.
    public void MakeUnderscores()
    {
        string wordAsUnderscores = "";

        while (wordAsUnderscores.Length < _word.Length)
        {
            wordAsUnderscores += "_";
        }

        _word = wordAsUnderscores;
        _isHidden = true;
    }

}