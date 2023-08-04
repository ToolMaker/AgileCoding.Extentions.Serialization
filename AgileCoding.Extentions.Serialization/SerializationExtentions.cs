namespace AgileCoding.Extentions.Serialization
{
    using System;
    using AgileCoding.Extentions.Generics;
    using Newtonsoft.Json;

    public static class SerializationExtentions
    {
        public static string JSONSerialization<TypeToCopy>(this TypeToCopy self, TypeNameHandling typeNameHandling = TypeNameHandling.All)
        {
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = typeNameHandling
            };

            self.ThrowIfNull<TypeToCopy, ArgumentNullException>($"{nameof(JSONSerialization)} extention method received a null object to serialize. Please guve a valid object.");

            return JsonConvert.SerializeObject(self, settings);
        }

        public static DeserializedType JSONDeserialize<DeserializedType>(this DeserializedType self, string jsonSerializedString, TypeNameHandling typeNameHandling = TypeNameHandling.All)
        {
            if (string.IsNullOrEmpty(jsonSerializedString))
            {
                throw new ArgumentNullException($"{nameof(JSONDeserialize)} extention method received a null or empty string to deserialize");
            }

            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = typeNameHandling
            };

            var deserializedObj = JsonConvert.DeserializeObject<DeserializedType>(jsonSerializedString);
            if (deserializedObj == null)
            {
                throw new ArgumentNullException($"{nameof(JSONDeserialize)} extention method received a null object after deserialization. Please guve a valid object.");
            }
            return deserializedObj;
        }
    }
}
