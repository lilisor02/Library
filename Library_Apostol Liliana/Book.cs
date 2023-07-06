namespace Library_Apostol_Liliana
{
    public class Book
    {
        public Book(string Name, string ISBN, float Price) 
        {
            this.Name = Name;
            this.ISBN = ISBN;
            this.Price = Price;
        }

        public string Name { get; set; }

        public string ISBN { get; set; }

        public float Price { get; set; }

        public bool IsBorrowed { get; set; }

        public string ClientName { get; set; }
    }
}
