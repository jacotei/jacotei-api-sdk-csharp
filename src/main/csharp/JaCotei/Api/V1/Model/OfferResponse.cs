using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace JaCotei.Api.V1.Model {

  /// <summary>
  /// A resposta para uma requisiÃ§Ã£o de atualizaÃ§Ã£o de ofertas.
  /// </summary>
  [DataContract]
  public class OfferResponse {
    
    /* quantidade de ofertas aceitas */
    [DataMember(Name="acceptedOffersCount", EmitDefaultValue=false)]
    public long? AcceptedOffersCount { get; set; }

    
    /* quantidade total de ofertas enviadas */
    [DataMember(Name="totalOffersCount", EmitDefaultValue=false)]
    public long? TotalOffersCount { get; set; }

    
    /* lista de ofertas rejeitadas */
    [DataMember(Name="offersRejected", EmitDefaultValue=false)]
    public List<OfferRejected> OffersRejected { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferResponse {\n");
      
      sb.Append("  AcceptedOffersCount: ").Append(AcceptedOffersCount).Append("\n");
      
      sb.Append("  TotalOffersCount: ").Append(TotalOffersCount).Append("\n");
      
      sb.Append("  OffersRejected: ").Append(OffersRejected).Append("\n");
      
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
