using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EasyMap
{
    public class MapData<TSource, TDestination> : IMapData<TSource, TDestination>
      where TSource : class
      where TDestination : class, new()
    {

        /// <summary>
        /// Creates a new instance of the destination type by copying matching property values from the specified source
        /// object.
        /// </summary>
        /// <remarks>Only properties that have the same name and type in both the source and destination
        /// types, and that are readable on the source and writable on the destination, are copied. Other properties are
        /// ignored.</remarks>
        /// <param name="source">The source object from which to copy property values. Cannot be null.</param>
        /// <returns>A new instance of the destination type with property values copied from the source object. Only properties
        /// with matching names and types are copied.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> is null.</exception>
        public TDestination Map(TSource source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            PropertyInfo[] sourceProperties = typeof(TSource).GetProperties();
            PropertyInfo[] destinationProperties = typeof(TDestination).GetProperties();

            var destination = new TDestination();

            foreach (var sourceProperty in sourceProperties)
            {
                var destinationProperty = destinationProperties.FirstOrDefault(p =>
                    p.Name == sourceProperty.Name &&
                    p.PropertyType == sourceProperty.PropertyType &&
                    p.CanWrite);

                if (destinationProperty == null || !sourceProperty.CanRead)
                    continue;

                var value = sourceProperty.GetValue(source);
                destinationProperty.SetValue(destination, value);
            }

            return destination;
        }
    }
}
