using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace JaCotei.Api.V1.Model {

  /// <summary>
  /// Um preÃ§o de uma oferta.
  /// </summary>
  [DataContract]
  public class OfferPrice {
    
    /* Quantidade de parcelas */
    [DataMember(Name="installment", EmitDefaultValue=false)]
    public int? Installment { get; set; }

    
    /* valor de cada parcela */
    [DataMember(Name="installmentValue", EmitDefaultValue=false)]
    public double? InstallmentValue { get; set; }

    
    /* preÃ§o total do produto */
    [DataMember(Name="price", EmitDefaultValue=false)]
    public double? Price { get; set; }

    
    /* Forma de pagamento */
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferPrice {\n");
      
      sb.Append("  Installment: ").Append(Installment).Append("\n");
      
      sb.Append("  InstallmentValue: ").Append(InstallmentValue).Append("\n");
      
      sb.Append("  Price: ").Append(Price).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
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
