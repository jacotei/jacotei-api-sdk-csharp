using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace JaCotei.Api.V1.Model {

  /// <summary>
  /// Uma oferta do Lojista
  /// </summary>
  [DataContract]
  public class Offer {
    
    /* Produto disponÃ­vel */
    [DataMember(Name="available", EmitDefaultValue=false)]
    public bool? Available { get; set; }

    
    /* cÃ³digo de barras do produto da oferta */
    [DataMember(Name="barcode", EmitDefaultValue=false)]
    public string Barcode { get; set; }

    
    /* Imagens dos produtos da oferta */
    [DataMember(Name="images", EmitDefaultValue=false)]
    public List<string> Images { get; set; }

    
    /* cÃ³digo de barras do livro */
    [DataMember(Name="isbn", EmitDefaultValue=false)]
    public string Isbn { get; set; }

    
    /* link para a pÃ¡gina da oferta */
    [DataMember(Name="link", EmitDefaultValue=false)]
    public string Link { get; set; }

    
    /* preÃ§os da oferta */
    [DataMember(Name="prices", EmitDefaultValue=false)]
    public List<OfferPrice> Prices { get; set; }

    
    /* CÃ³digo de identificaÃ§Ã£o da oferta */
    [DataMember(Name="sku", EmitDefaultValue=false)]
    public string Sku { get; set; }

    
    /* DescriÃ§Ã£o da oferta */
    [DataMember(Name="title", EmitDefaultValue=false)]
    public string Title { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Offer {\n");
      
      sb.Append("  Available: ").Append(Available).Append("\n");
      
      sb.Append("  Barcode: ").Append(Barcode).Append("\n");
      
      sb.Append("  Images: ").Append(Images).Append("\n");
      
      sb.Append("  Isbn: ").Append(Isbn).Append("\n");
      
      sb.Append("  Link: ").Append(Link).Append("\n");
      
      sb.Append("  Prices: ").Append(Prices).Append("\n");
      
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      
      sb.Append("  Title: ").Append(Title).Append("\n");
      
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
