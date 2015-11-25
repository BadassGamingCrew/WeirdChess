// auto-generated />
namespace WeirdChess.Interfaces
{
    /// <summary>
    /// Interface for Factory objects, used for creating ISerialisationTool objects.
    /// </summary>
    /// <typeparam name="T">An ISavable object, specifying the type of objects that we want to serialise/deserialise</typeparam>
    public interface ISerialisationToolFactory<T> where T : ISavable
    {
        /// <summary>
        /// The factory method for creating ISerialisationTool objects.
        /// </summary>
        /// <param name="filePath">The path for the file that's to be used in the ISerialiser/IDeserialiser objects</param>
        /// <returns>An ISerialisationTool object</returns>
        ISerialisationTool<T> CreateTool(string filePath);
    }
}
