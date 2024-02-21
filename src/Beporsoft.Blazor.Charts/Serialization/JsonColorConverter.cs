using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Serialization
{
    internal class JsonColorConverter : JsonConverter<Color>
    {
        public override Color ReadJson(JsonReader reader, Type objectType, Color existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readedValue = Convert.ToString(reader.Value);
            if (string.IsNullOrWhiteSpace(readedValue))
            {
                return new Color();
            }
            Color color = ColorTranslator.FromHtml(readedValue);
            return color;
        }

        public override void WriteJson(JsonWriter writer, Color value, JsonSerializer serializer)
        {
            writer.WriteValue(ColorTranslator.ToHtml(value));
        }
    }
}
