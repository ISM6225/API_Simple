namespace API_Simple.Models
{
    public class Company
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string type { get; set; }
        public string iexId { get; set; }
        public bool isEnabled { get; set; }
    }
}
