class reference
{
    public string referenceText { get; }

    public Reference(string referenceText)
    {
        ReferenceText = referenceText;
    }

    public override ToString()
    {
        return ReferenceText;
    }

}