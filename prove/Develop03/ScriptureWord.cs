public class ScriptureWord
{
    private string _word;

    public ScriptureWord()
    {
        _word = "";
    }

    public ScriptureWord(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public void DisplayWord()
    {
        Console.Write(_word + " ");
    }

}