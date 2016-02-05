using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VictorsVisualizer
{
    public class StreamSerializer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="outgoingData"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Stream ObjectToStream(Stream outgoingData, object data)
        {
            if (outgoingData == null)
                outgoingData = new MemoryStream();

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(outgoingData, data);

            return outgoingData;
        }
         /// <summary>
         /// 
         /// </summary>
         /// <param name="outgoingData"></param>
         /// <returns></returns>
        public static object StreamToObject(Stream outgoingData)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(outgoingData);
        }
    }
}