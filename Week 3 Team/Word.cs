class word
{
    private string text;

    public bool Hidden {get; Private set; }

    public Word(string text)
    {
        this.text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public string GetText()
    {
        return text;
    }

    public bool IsHidden()
    {
        return Hidden;
    }

    public override string ToString()
    {
        return Hidden ? "______" : text;
    }
}