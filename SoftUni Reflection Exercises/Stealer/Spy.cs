using System;
using System.Linq;
using System.Reflection;
using System.Text;


public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
                                                                            | BindingFlags.NonPublic 
                                                                            | BindingFlags.Public);
        StringBuilder builder = new StringBuilder();
        Object classInstance = Activator.CreateInstance(classType, new object[] { });
        builder.AppendLine($"Class under investigation: {investigatedClass}");
        foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
        {
            builder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }
        return builder.ToString().Trim();
    }

    public string AnalyzeAccessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type classType = Type.GetType(className);
        FieldInfo[] fields = classType.GetFields(BindingFlags.Instance |
                                                 BindingFlags.Static |
                                                 BindingFlags.Public);
        MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Instance |
                                                          BindingFlags.NonPublic);
        MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Instance |
                                                            BindingFlags.Public);
        foreach (FieldInfo field in fields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (MethodInfo privateMethod in privateMethods.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{privateMethod.Name} have to be public!");
        }
        foreach (MethodInfo publicMethod in publicMethods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{publicMethod.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type classType = Type.GetType(className);
        MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Instance |
                                                           BindingFlags.NonPublic);
        sb.AppendLine($"All Private Methods of Class: {classType.Name}");
        sb.AppendLine($"Base class: {classType.BaseType.Name}");
        foreach (MethodInfo method in privateMethods)
        {
            sb.AppendLine($"{method.Name}");
        }

        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type classType = Type.GetType(className);
        MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance |
                                                       BindingFlags.Public |
                                                       BindingFlags.NonPublic);
        foreach (MethodInfo method in methods.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }
        foreach (MethodInfo method in methods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return sb.ToString().Trim();
    }
}
