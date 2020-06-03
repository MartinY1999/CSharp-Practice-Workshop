using System.Collections.Generic;
using System.Linq;

namespace IntegrationTests.Models
{
    public class Category
    {
        private HashSet<User> users;
        private HashSet<Category> subcategories;

        public string Name { get; private set; }
        public IReadOnlyCollection<User> Users
            => this.users.ToList().AsReadOnly();
        public IReadOnlyCollection<Category> Subcategories
            => this.subcategories.ToList().AsReadOnly();
        

        public Category(string name)
        {
            this.Name = name;
            this.subcategories = new HashSet<Category>();
            this.users = new HashSet<User>();
        }

        public void AssignToParentCategory(Category parent)
        {
            parent.subcategories.Add(this);
        }

        public void RemoveSubcategory(Category child)
        {
            this.subcategories.Remove(child);
        }

        public void AssignUserToCategory(User user)
        {
            this.users.Add(user);
        }
    }
}
