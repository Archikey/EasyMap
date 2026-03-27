

namespace EasyMap.FactoryObjects
{

    /// <summary>
    /// Defines a contract for creating custom objects from a set of key-value pairs.
    /// </summary>
    /// <remarks>Implementations of this interface can use the provided key-value pairs to construct objects
    /// with dynamic or configurable properties. The specific type and structure of the created object depend on the
    /// implementation.</remarks>
    public interface IObjectFactory
    {
        object CreateCustomObject(Dictionary<string, object?> keyValuePairs);


    }
}
