class Scripture
{
    private Reference reference;
    private List<Word> words = new List<Word>();

    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference(referenceText);
        words.AddRange(scriptureText.Split(' ').Select(word => new Word(word)));
    }

    public void HideRandomWord()
    {
        List<Word> unhiddenWords = words.Where(word => !word.Hidden).ToList;
        if (unhiddenWords.Count > 0)
        {
            Word WordToHide = unhiddenWords[New Random().Next(unhiddenWords.Count)];
            wordToHide.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.Hidden);
    }

    public override string ToString()
    {
        return $"{reference}\n"{string.join(" ", words)};
    }
}