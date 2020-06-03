using System.Collections.Generic;
using System.Linq;

namespace IntegrationTests.Models
{
    public class User
    {
        private HashSet<Category> categories;

        public string Name { get; private set; }
        public IReadOnlyCollection<Category> Categories 
            => this.categories.ToList().AsReadOnly();

        public User(string name)
        {
            this.Name = name;
            this.categories = new HashSet<Category>();
        }

        public void AssignToCategory(Category category)
        {
            this.categories.Add(category);
        }
    }
}
