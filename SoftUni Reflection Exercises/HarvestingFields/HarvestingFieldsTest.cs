 using System.Linq;
 using System.Reflection;

namespace P01_HarvestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type harvestingClass = typeof(HarvestingFields);
            FieldInfo[] allFields = harvestingClass.GetFields(BindingFlags.Instance |
                                                              BindingFlags.Public |
                                                              BindingFlags.NonPublic);
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "HARVEST") break;
                else
                    ReceiveAndPrint(allFields, input);
            }

            Console.ReadLine();
        }

        private static void ReceiveAndPrint(FieldInfo[] fields, string type)
        {
            string[] result = new string[] { };
            switch (type)
            {
                case "private":
                    result = fields.Where(x => x.IsPrivate)
                        .Select(f => $"{type} {f.FieldType.Name} {f.Name}")
                        .ToArray();
                    break;
                case "protected":
                    result = fields.Where(x => x.IsFamily)
                        .Select(f => $"{type} {f.FieldType.Name} {f.Name}")
                        .ToArray();
                    break;
                case "public":
                    result = fields.Where(x => x.IsPublic)
                        .Select(f => $"{type} {f.FieldType.Name} {f.Name}")
                        .ToArray();
                    break;
                case "all":
                    result = fields.Select(f => $"{CantBeArsed(f.Attributes)} {f.FieldType.Name} {f.Name}")
                        .ToArray();
                    break;
                default:
                    break;
            }

            foreach (string field in result)
            {
                Console.WriteLine(field);
            }
        }
        private static string CantBeArsed(FieldAttributes attributes)
        {
            string attr = attributes.ToString();
            if (attr == "Public")
                return "public";
            else if (attr == "Family")
                return "protected";
            else
                return "private";
        }
    }
}
