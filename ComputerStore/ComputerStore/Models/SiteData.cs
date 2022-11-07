namespace ComputerStore.Models
{
    public class SiteData
    {
        public Decimal tax { get; set; }

        public Decimal setup { get; set; }

        public String email { get; set; }

        public SiteData()
        {
            tax = (Decimal).07;
            setup = (Decimal)100;
            email = "helpdesk @computerstore.com";
        }
    }
}
