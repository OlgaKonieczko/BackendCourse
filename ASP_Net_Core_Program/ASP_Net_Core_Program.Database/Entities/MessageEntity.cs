namespace ASP_Net_Core_Program.Database.Entities
{
    public class MessageEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public string FirstNameAuthor { get; set; }
        public string LastNameAuthor { get; set; }
    }
}
