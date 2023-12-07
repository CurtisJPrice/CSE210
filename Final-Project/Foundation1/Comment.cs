public class Comment
{
    //prop
    public string Commenter {get; set; }
    public string CommentText {get; set; }

    public Comment(string commenter, string commentText)
    {
        Commenter = commenter;
        CommentText = commentText;
    }

}