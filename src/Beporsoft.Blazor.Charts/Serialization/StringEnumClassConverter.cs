using Beporsoft.Blazor.Charts.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Serialization
{
    internal class JsonStringEnumClassConverter : JsonConverter<StringEnumClass>
    {
        private static readonly Type[] _stringParameterArray = new[] { typeof(string) };
        private static readonly ConcurrentDictionary<Type, ConstructorInfo> _constructorCache = new ConcurrentDictionary<Type, ConstructorInfo>();

        public override StringEnumClass ReadJson(JsonReader reader, Type objectType, [AllowNull] StringEnumClass existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                case JsonToken.Undefined:
                    return null;
                case JsonToken.String:
                    ConstructorInfo constructor = _constructorCache.GetOrAdd(objectType, GetStringConstructor);

                    return (StringEnumClass)constructor.Invoke(new[] { reader.Value });
                default:
                    throw new NotSupportedException($"Deserializing StringEnums from token type '{reader.TokenType}' isn't supported.");
            }
        }

        public override void WriteJson(JsonWriter writer, StringEnumClass value, JsonSerializer serializer)
        {
            // Note: value won't be null (json.net wouldn't call this method if it were null)
            // ToString was overwritten by StringEnum -> safe to just print the string representation
            writer.WriteValue(value.Value);
        }

        private ConstructorInfo GetStringConstructor(Type type) =>
            type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, _stringParameterArray, null);
    }
}
