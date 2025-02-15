public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    public Reference()
    {
        _book = "";
        _chapter = 1;
        _firstVerse = 0;
        _lastVerse = 0;
    }

    public Reference(string book)
    {
        _book = book;
        _chapter = 1;
        _firstVerse = 0;
        _lastVerse = 0;
    }

    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = 0;
        _lastVerse = 0;
    }

        public Reference(string book, int chapter, int first)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = first;
        _lastVerse = 0;
    }

        public Reference(string book, int chapter, int first, int last)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = first;
        _lastVerse = last;
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

        public int GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

        public int GetFirst()
    {
        return _firstVerse;
    }

    public void SetFirst(int first)
    {
        _firstVerse = first;
    }

        public int GetLast()
    {
        return _lastVerse;
    }

    public void SetLast(int last)
    {
        _lastVerse = last;
    }

    public void DisplayReference()
    {
        if (_lastVerse > 0 && _lastVerse > _firstVerse)
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse} ");
        
        else if (_firstVerse > 0)
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse} ");
        }

        else 
        {
            Console.WriteLine($"{_book} {_chapter} ");
        }
    }
}