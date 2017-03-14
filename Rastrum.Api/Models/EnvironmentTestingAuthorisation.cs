namespace Rastrum.Api.Models
{
    public class EnvironmentTestingAuthorisation
    {
        public int Id { get; set; }
        public TestingEnvironment Environment { get; set; }
        public RequestStatus Status { get; set; }
        public string AuthorisationNumber { get; set; }
        public string Notes { get; set; }

        public enum RequestStatus
        {
            NotYetStarted,
            Pending,
            Approved,
            Declined
        }
    }
}
