public class ScriptureWord
{
    private string _word;
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

    public void DisplayWord()
    {
        Console.Write(_word + " ");
    }

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