using CaprarSalajan_AnaCezara_Lab2.Models.ViewModels;

namespace CaprarSalajan_AnaCezara_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
