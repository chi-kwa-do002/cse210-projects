using System.Collections.Generic;

public class Video
{
    public string title;
    public string author;
    public int lengthInSeconds;

    private List<Comment> comments = new List<Comment>();

    public Video(string videoTitle, string videoAuthor, int videoLength)
    {
        title = videoTitle;
        author = videoAuthor;
        lengthInSeconds = videoLength;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}

