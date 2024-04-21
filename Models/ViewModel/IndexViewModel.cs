namespace eTickets.Models.ViewModel
{
    public class IndexViewModel
    {
        public List<Hero> Heroes { get; set; }
        public string SearchQuery { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
    }
}
