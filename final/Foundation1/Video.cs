class Video
{
    public string title;
    public string author;
    public int length;
    public List<Comment> comments;

    public Video(string videoTitle, string videoAuthor, int videoLength)
    {
        title = videoTitle;
        author = videoAuthor;
        length = videoLength;
        comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Length: " + length + " seconds");
        Console.WriteLine("Number of Comments: " + comments.Count);
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            Console.WriteLine("  - " + comment.commenterName + ": " + comment.text);
        }
        Console.WriteLine(new string('-', 40));
    }
}
