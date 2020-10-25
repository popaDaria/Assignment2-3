using System.Text.Json.Serialization;

namespace Assignment2_3.Models {
public class ChildInterest {
    public int ChildId { get; set; }
    [JsonIgnore]
    public Child Child { get; set; }
    
    public string InterestId { get; set; }
    [JsonIgnore]
    public Interest Interest { get; set; }

    public override bool Equals(object? obj) {
        ChildInterest ci = ((ChildInterest) obj);
        if (ci.Child.Equals(Child) && ci.Interest.Equals(Interest)) return true;
        return base.Equals(obj);
    }
}
}