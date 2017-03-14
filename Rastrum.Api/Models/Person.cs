namespace Rastrum.Api.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }  // Check for control characters
        public string ShortName { get; set; } // Check for control characters
        public byte[] PgpKey { get; set; }
    }
}
