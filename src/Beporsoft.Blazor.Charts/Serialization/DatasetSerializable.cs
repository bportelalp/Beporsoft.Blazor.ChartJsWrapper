using Beporsoft.Blazor.Charts.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Serialization
{
    internal class DatasetSerializable
    {
        public DatasetSerializable(IChartDataset dataset)
        {
            Label = dataset.Title;
            Data = dataset.GetData();
        }

        [JsonProperty("label")]
        public string Label { get; }

        [JsonProperty("data")]
        public List<object?> Data { get; }

        [JsonProperty("borderColor")]
        public string? BorderColor { get; }

        [JsonProperty("backgroundColor")]
        public string? BackgroundColor { get; }
    }
}
