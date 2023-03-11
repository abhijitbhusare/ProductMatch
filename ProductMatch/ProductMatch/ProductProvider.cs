using Newtonsoft.Json;
using RestEase;
using System.Xml.Serialization;

namespace ProductMatch
{
	public class BannerProductProvider : IProductProvider
	{
		private readonly IBannerProductProvider _provider;
		private readonly string _baseUri;
		private readonly string _authToken;

		public BannerProductProvider(string baseUri, string authToken)
		{
			_baseUri = baseUri;
			_authToken = authToken;
			var uri = new Uri(_baseUri);
			_provider = RestClient.For<IBannerProductProvider>(uri);
		}
		public Products GetProducts()
		{
			var output = _provider.GetProductsAsJson(_authToken).Result;
			var products = JsonConvert.DeserializeObject<Products>(output);
			return products;
		}
	}

	public class RSHughesProductProvider : IProductProvider
	{
		private readonly IRSHughesProductProvider _provider;
		private readonly string _baseUri;
		private readonly string _authToken;

		public RSHughesProductProvider(string baseUri, string authToken)
		{
			_baseUri = baseUri;
			_authToken = authToken;
			var uri = new Uri(_baseUri);
			_provider = RestClient.For<IRSHughesProductProvider>(uri);
		}
		public Products GetProducts()
		{
			var output = _provider.GetProductsAsXml(_authToken).Result;
			XmlRootAttribute xRoot = new XmlRootAttribute();
			var stringReader = new StringReader(output);

			var serializer = new XmlSerializer(typeof(Products), new XmlRootAttribute("ProductsResponse"));
			return (Products)serializer.Deserialize(stringReader);
		}
	}


}
