using System;

namespace CustomEnumAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {
        public string Type { get; private set; }
        public string Category { get; private set; }
        public string Description { get; private set; }

        public TypeAttribute(string type, string category, string description)
        {
            Type = type;
            Category = category;
            Description = description;
        }
        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}";
        }
    }
}
