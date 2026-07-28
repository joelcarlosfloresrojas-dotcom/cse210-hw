public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments= new List<Comment>();


    public int NumberComments()
    {

        return _comments.Count();;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Video's title:{_title} ");
        Console.WriteLine($"Author:{_author} ");
        Console.WriteLine($"Length of the Video(in seconds):{_length} ");
        Console.WriteLine($"Number of comments:{NumberComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment._name}: {comment._text}");
        }
    }

}