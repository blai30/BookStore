using System.Collections.Generic;

namespace BookStore.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        // Entity framework relations
        public IEnumerable<Book> Books { get; set; }
    }
}
