public class Scripture
{
    private string _text;
    private bool _isAllHidden;
    private List<ScriptureWord> _words = new List<ScriptureWord>();

    public Scripture(string text)
    {
        _text = text;
        _isAllHidden = false;

        // Turns the string in _text into a list of the ScriptureWord 
        // class to seperate out each word to be able to manipulate each
        // individually.
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

    // Used to reset the list of words in
    // _words if _text is updated.
    private void ResetWords()
    {
        _words.Clear();
        List<string> wordList = _text.Split(new char[] {' '}).ToList();

        foreach (string word in wordList)
        {
            ScriptureWord scriptureWord = new ScriptureWord(word);

            _words.Add(scriptureWord);
        }
    }

    // Randomly hides an amount of words 
    // inputted into the method (amount)
    public void RandomHide(int amount)
    {
        int numberShown = 0;

        // Checking how many words aren't hidden
        // to make sure it can actually 
        // hide the amount of words that was
        // inputted into the method
        foreach (ScriptureWord word in _words)
        {
            if (word.GetIsHidden() == false)
            {
                numberShown++;
            }
        }

        // if there aren't enough words left to hide 
        // it will set it so it hides all the words left
        // and sets _isAllHidden to true so later in 
        // the main program it will be able to check once 
        // its finished hiding all the words.
        if (amount >= numberShown)
        {
            amount = numberShown;
            _isAllHidden = true;
        }

        // if there is at least one word that
        // it can hide it will generate a random
        // number corresponding to one of the words
        // in the scripture and will attempt to hide
        // it. If the word is already hidden it will 
        // retry and set the for loop back 1 so it 
        // always hides the amount it needs to.
        if (amount > 0)
        {        
            Random rand = new Random();
            for (int i = 0; i < amount; i++)
            {
                int randomNumber = rand.Next(_words.Count());

                if (_words[randomNumber].GetIsHidden() == false)
                {
                    _words[randomNumber].MakeUnderscores();
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