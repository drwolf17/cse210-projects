public class Scripture
{
    private string _text;
    private bool _isAllHidden;
    private List<ScriptureWord> _words = new List<ScriptureWord>();

    public Scripture(string text)
    {
        _text = text;
        _isAllHidden = false;

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
        ResetWords();
    }

    public bool AreAllHidden()
    {
        return _isAllHidden;
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

    public void RandomHide(int amount)
    {
        int numberShown = 0;

        foreach (ScriptureWord word in _words)
        {
            if (word.GetIsHidden() == false)
            {
                numberShown++;
            }
        }

        if (amount >= numberShown)
        {
            amount = numberShown;
            _isAllHidden = true;
        }

        if (amount > 0)
        {        
            Random rand = new Random();
            for (int i = 0; i < amount; i++)
            {
                int randomNumber = rand.Next(_words.Count());

                if (_words[randomNumber].GetIsHidden() == false)
                {
                    _words[randomNumber].SetIsHidden(true);
                }

                else
                {
                    i--;
                }

            }
        }
    }

    public void DisplayScripture()
    {
        foreach (ScriptureWord word in _words)
        {
            word.DisplayWord();
        }

    }
}