# jacotei-api-sdk-csharp
SDK para acesso da API de publicação JáCotei

## Compilando ##

``` 
compile.bat
``` 

A dll *JaCotei.Api.V1.Client.dll* será gerada no diretório *bin*

## Exemplo de Utilização ##

Importe as libs
``` CSharp
using System;
using System.Collections.Generic;

using JaCotei.Api.V1;
using JaCotei.Api.V1.Client;
using JaCotei.Api.V1.Model;
```

### POST offers ###

Faça uma chamada com 1000 ofertas
```CSharp
Configuration.apiKey.Add ("client_id","xxxx");
Configuration.apiKey.Add ("access_token","xxxx");

ApiClient apiClient = new ApiClient("https://webapisb.jacotei.com.br/publisher/v1");

OffersApi offersApi = new OffersApi (apiClient);

List<Offer> offerList = new List<Offer> ();
for(int i = 0; i < 1000 ; i++){
	Offer offer1 = new Offer ();
	offer1.Available = true;
	//offer1.Barcode  = "9788573089127";
	//offer1.Isbn     = "9788573089127";
	offer1.Link     = "http://aasdfaf.com/asdflasdf";


	OfferPrice offerPrice = new OfferPrice ();
	offerPrice.Price = 30.60;
	offerPrice.Installment = 1;
	offerPrice.InstallmentValue = 1;

	List<OfferPrice> offerPriceList = new List<OfferPrice> ();
	offerPriceList.Add (offerPrice);
	offer1.Prices = offerPriceList;

	List<String> images = new List<String> ();
	images.Add ("http://asdfaf.com/asdfasdf");
	offer1.Images = images;

	offer1.Sku      = ""+i;
	offer1.Title = "Oferta " + i;
	offerList.Add (offer1);
}

OfferRequest request = new OfferRequest ();
request.Offers = offerList;

OfferResponse response = offersApi.UpdateOffersUsingPOST (request);

Console.WriteLine (response);
``` 


### GET offer ###

Obtenha 1 oferta
```CSharp
Configuration.apiKey.Add ("client_id","xxxx");
Configuration.apiKey.Add ("access_token","xxxx");

ApiClient apiClient = new ApiClient("https://webapisb.jacotei.com.br/publisher/v1");

OffersApi offersApi = new OffersApi (apiClient);

try{
	Offer offer = offersApi.GetOfferUsingGET("4624793");
	Console.WriteLine (offer.ToJson());
}catch (ApiException e) {
	Console.Write (e.Message);
}
```

### Informações Adicionais ###

Acesse https://desenvolvedores.jacotei.com.br
- Códigos de Erros: https://desenvolvedores.jacotei.com.br/api-portal/node/5
