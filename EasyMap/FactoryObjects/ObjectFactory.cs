using System.Dynamic;


namespace EasyMap.FactoryObjects
{
    public class ObjectFactory : IObjectFactory
    {

        /// <summary>
        /// Creates a dynamic object with properties and values defined by the specified key-value pairs.
        /// </summary>
        /// <remarks>The returned object is an ExpandoObject, allowing dynamic access to the properties
        /// defined by the input dictionary. Property names are case-sensitive and must be valid identifiers for dynamic
        /// access.</remarks>
        /// <param name="keyValuePairs">A dictionary containing property names and their corresponding values to be added to the dynamic object.
        /// Each key represents a property name; keys cannot be null, empty, or whitespace.</param>
        /// <returns>An object representing a dynamic type with properties set according to the provided key-value pairs.</returns>
        /// <exception cref="ArgumentNullException">Thrown if keyValuePairs is null.</exception>
        /// <exception cref="ArgumentException">Thrown if any key in keyValuePairs is null, empty, or consists only of whitespace.</exception>
        public object CreateCustomObject(Dictionary<string, object?> keyValuePairs)
        {
            if (keyValuePairs is null)
                throw new ArgumentNullException(nameof(keyValuePairs));

            IDictionary<string, object?> expando = new ExpandoObject();

            foreach (var pair in keyValuePairs)
            {
                if (string.IsNullOrWhiteSpace(pair.Key))
                    throw new ArgumentException("Key cannot be null or empty.", nameof(keyValuePairs));

                expando[pair.Key] = pair.Value;
            }

            return (ExpandoObject)expando;
        }
    }
}
