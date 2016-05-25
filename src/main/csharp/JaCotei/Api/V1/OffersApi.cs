using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using JaCotei.Api.V1.Client;
using JaCotei.Api.V1.Model;

namespace JaCotei.Api.V1 {
  

  public interface IOffersApi {
    
    /// <summary>
    /// MÃ©todo de atualizaÃ§Ã£o de ofertas 
    /// </summary>
    /// <param name="Offers">offerUpdateRequest</param>
    /// <returns>OfferResponse</returns>
    OfferResponse UpdateOffersUsingPOST (OfferRequest Offers);

    /// <summary>
    /// MÃ©todo de atualizaÃ§Ã£o de ofertas 
    /// </summary>
    /// <param name="Offers">offerUpdateRequest</param>
    /// <returns>OfferResponse</returns>
    Task<OfferResponse> UpdateOffersUsingPOSTAsync (OfferRequest Offers);
    
    /// <summary>
    /// Consulta de ofertas por sku 
    /// </summary>
    /// <param name="Sku">sku</param>
    /// <returns>Offer</returns>
    Offer GetOfferUsingGET (string Sku);

    /// <summary>
    /// Consulta de ofertas por sku 
    /// </summary>
    /// <param name="Sku">sku</param>
    /// <returns>Offer</returns>
    Task<Offer> GetOfferUsingGETAsync (string Sku);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class OffersApi : IOffersApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="OffersApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public OffersApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OffersApi"/> class.
    /// </summary>
    /// <returns></returns>
    public OffersApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// MÃ©todo de atualizaÃ§Ã£o de ofertas 
    /// </summary>
    /// <param name="Offers">offerUpdateRequest</param>
    /// <returns>OfferResponse</returns>
    public OfferResponse UpdateOffersUsingPOST (OfferRequest Offers) {

      
      // verify the required parameter 'Offers' is set
      if (Offers == null) throw new ApiException(400, "Missing required parameter 'Offers' when calling UpdateOffersUsingPOST");
      

      var path = "/offers";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Offers); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateOffersUsingPOST: " + response.Content, response.Content);
      }
      return (OfferResponse) apiClient.Deserialize(response.Content, typeof(OfferResponse));
    }
	
	 /// <summary>
    /// MÃ©todo de atualizaÃ§Ã£o de ofertas 
    /// </summary>
    /// <param name="Offers">offerUpdateRequest</param>
    /// <returns>OfferResponse</returns>
    public async Task<OfferResponse> UpdateOffersUsingPOSTAsync (OfferRequest Offers) {

      
          // verify the required parameter 'Offers' is set
          if (Offers == null) throw new ApiException(400, "Missing required parameter 'Offers' when calling UpdateOffersUsingPOST");
      

      var path = "/offers";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Offers); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateOffersUsingPOST: " + response.Content, response.Content);
      }
      return (OfferResponse) apiClient.Deserialize(response.Content, typeof(OfferResponse));
    }
    
    /// <summary>
    /// Consulta de ofertas por sku 
    /// </summary>
    /// <param name="Sku">sku</param>
    /// <returns>Offer</returns>
    public Offer GetOfferUsingGET (string Sku) {

      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling GetOfferUsingGET");
      

      var path = "/offers/{sku}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GetOfferUsingGET: " + response.Content, response.Content);
      }
      return (Offer) apiClient.Deserialize(response.Content, typeof(Offer));
    }
	
	 /// <summary>
    /// Consulta de ofertas por sku 
    /// </summary>
    /// <param name="Sku">sku</param>
    /// <returns>Offer</returns>
    public async Task<Offer> GetOfferUsingGETAsync (string Sku) {

      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling GetOfferUsingGET");
      

      var path = "/offers/{sku}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GetOfferUsingGET: " + response.Content, response.Content);
      }
      return (Offer) apiClient.Deserialize(response.Content, typeof(Offer));
    }
    
  }  
  
}
