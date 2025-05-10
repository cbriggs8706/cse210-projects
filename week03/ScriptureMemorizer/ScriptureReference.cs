public class ScriptureReference
{
    private string _book;
    private int _startVerse;
    private int _endVerse;
    private int _chapter;
    private bool _hideBook;
    private bool _hideChapter;
    private bool _hideVerses;
    private Random _random = new Random();

    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void HideRandomPart()
    {
        int choice = _random.Next(3); // 0 = book, 1 = chapter, 2 = verses

        switch (choice)
        {
            case 0: _hideBook = true; break;
            case 1: _hideChapter = true; break;
            case 2: _hideVerses = true; break;
        }
    }

    public bool IsFullyHidden()
    {
        return _hideBook && _hideChapter && _hideVerses;
    }

    public string GetDisplayText()
    {
        string book = _hideBook ? new string('_', _book.Length) : _book;
        string chapter = _hideChapter ? "__" : _chapter.ToString();

        string verses = (_startVerse == _endVerse)
            ? (_hideVerses ? "__" : _startVerse.ToString())
            : (_hideVerses ? "__-__" : $"{_startVerse}-{_endVerse}");

        return $"{book} {chapter}:{verses}";
    }
}
