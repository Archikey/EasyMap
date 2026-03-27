using System;
using System.Collections.Generic;
using System.Text;

namespace EasyMap
{

    /// <summary>
    /// Defines a contract for mapping objects from a source type to a destination type.
    /// </summary>
    /// <remarks>Implementations of this interface provide a way to transform or project data from one object
    /// type to another, typically for scenarios such as data transfer, object adaptation, or DTO mapping.</remarks>
    /// <typeparam name="TSource">The type of the source object to map from. Must be a reference type.</typeparam>
    /// <typeparam name="TDestination">The type of the destination object to map to. Must be a reference type with a parameterless constructor.</typeparam>
    public interface IMapData<TSource, TDestination>
        where TSource : class
        where TDestination : class, new()
    {


        TDestination Map(TSource source);
    }
}
