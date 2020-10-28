using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Assignment2_3.Models {
public class Child : Person {
    
    [JsonPropertyName("childInterests")]
    public List<ChildInterest> ChildInterests { get; set; }
    [JsonPropertyName("pets")]
    public List<Pet> Pets { get; set; }

    public void Update(Child toUpdate) {
        base.Update(toUpdate);
        ChildInterests = toUpdate.ChildInterests;
        Pets = toUpdate.Pets;
    }

}
}