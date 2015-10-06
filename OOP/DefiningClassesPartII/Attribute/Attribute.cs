/*Task 11
 * Create a [Version] attribute that can be applied to structures, classes, interfaces,
 * enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
 * Apply the version attribute to a sample class and display its version at runtime.
 */

using System;

public class VersionDemo
{
    static void Main()
    {
        Type type = typeof(SampleClass);

        foreach (var attr in type.GetCustomAttributes(false))
        {
            if (attr is VersionAttribute)
            {
                Console.WriteLine("This is version {0} of the {1} class.",
                    (attr as VersionAttribute).Version, typeof(SampleClass).FullName);
            }
        }
    }
}

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
    AllowMultiple = false)]
public class VersionAttribute : Attribute
{
    public string Version { get; set; }

    public VersionAttribute(string version)
    {
        Version = version;
    }
}

[Version("2.3")]
public class SampleClass
{

}

