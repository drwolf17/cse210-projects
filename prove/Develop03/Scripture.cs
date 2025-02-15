public class Scripture
{
    private string _text;
    private List<ScriptureWord> _words = new List<ScriptureWord>();

    public Scripture(string text)
    {
        _text = text;

        List<string> wordList = _text.Split(new char[] {' '}).ToList();

        foreach (string word in wordList)
        {
            ScriptureWord scriptureWord = new ScriptureWord(word);

            _words.Add(scriptureWord);
        }
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public void ResetWords()
    {
        _words.Clear();
        List<string> wordList = _text.Split(new char[] {' '}).ToList();

        foreach (string word in wordList)
        {
            ScriptureWord scriptureWord = new ScriptureWord(word);

            _words.Add(scriptureWord);
        }
    }
}