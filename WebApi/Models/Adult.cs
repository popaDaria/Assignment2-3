using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment2_3WebApi.Models {
public class Adult : Person {
    [JsonPropertyName("jobTitle")]
    public string JobTitle { get; set; }

    public override string ToString() {
        return JsonSerializer.Serialize(this);
    }

    public void Update(Adult toUpdate) {
        JobTitle = toUpdate.JobTitle;
        base.Update(toUpdate);
    }

    public override bool Equals(object? obj)
    {
        Adult ci = ((Adult) obj);
        if (ci.Id==Id) return true;
        return base.Equals(obj);
    }
}
}