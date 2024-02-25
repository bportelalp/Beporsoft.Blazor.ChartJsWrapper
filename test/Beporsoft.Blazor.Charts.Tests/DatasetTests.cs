using Beporsoft.Blazor.Charts.Datasets;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Beporsoft.Blazor.Charts.Tests
{
    public class DatasetTests
    {
        [Fact]
        public void DataPoint_ShouldSerialize()
        {
            var point = new DataPoint<double>(1, 3);

            var pointSerializer = JsonSerializer.Serialize(point);
        }
    }
}