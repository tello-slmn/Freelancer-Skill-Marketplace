namespace FSM.Models
{
    public class Message
    {
            public int Id { get; set; }
            public string MessageSender { get; set; }
            public string MessageRecipient { get; set; }
            public string Content { get; set; }
            public DateTime Timestamp { get; set; }
    }
}
