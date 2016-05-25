using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace JaCotei.Api.V1.Model {

  /// <summary>
  /// O resultado de uma validaÃ§Ã£o de oferta.
  /// </summary>
  [DataContract]
  public class OfferRejected {
    
    
    [DataMember(Name="offer", EmitDefaultValue=false)]
    public Offer Offer { get; set; }

    
    
    [DataMember(Name="validationErrors", EmitDefaultValue=false)]
    public List<Error> ValidationErrors { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferRejected {\n");
      
      sb.Append("  Offer: ").Append(Offer).Append("\n");
      
      sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}
