using JsonConditional.Core.Models;
using JsonConditional.Core.Models.Audio;
using JsonConditional.Core.Models.Audiovisual;
using Newtonsoft.Json;

namespace JsonConditional.Core
{
    public class MyJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (objectType is IWork)
            {
                switch ((objectType as IWork).Type)
                {
                    case Models.Enums.EWorkType.Music:
                        return serializer.Deserialize<Music>(reader);
                    case Models.Enums.EWorkType.Podcast:
                        return serializer.Deserialize<Podcast>(reader);
                    case Models.Enums.EWorkType.Trailer:
                        return serializer.Deserialize<Trailer>(reader);
                    case Models.Enums.EWorkType.Movie:
                        return serializer.Deserialize<Movie>(reader);
                    default:
                        throw new InvalidCastException();
                }
            }
            return serializer.Deserialize(reader);
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}