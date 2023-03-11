using Newtonsoft.Json.Linq;
using RestEase;

namespace ProductMatch
{
	public class TokenGenerator : ITokenGenerator
	{
		private readonly IAuthinthicator _provider;
		private readonly string _baseUri;
		private readonly string _grantType;
		private readonly string _clientId;
		private readonly string _clientSecret;
		private readonly string _scope;

		public TokenGenerator(string baseUri, string grantType, string clientId, string clientSecret, string scope)
		{
			_baseUri = baseUri;
			_grantType = grantType;
			_clientId = clientId;
			_clientSecret = clientSecret;
			_scope = scope;
			var uri = new Uri(_baseUri);
			_provider = RestClient.For<IAuthinthicator>(uri);
			_clientSecret = clientSecret;
			_scope = scope;
		}

		public string Generate()
		{
			var input = new Dictionary<string, string> {
				{ "grant_type", _grantType},
				{ "client_id", _clientId},
				{ "client_secret", _clientSecret},
				{ "scope", _scope}
			};
			var jObject = JObject.Parse (_provider.GetAuthToken(input).Result);
			var token = jObject["access_token"].ToString();
			return $"Bearer {token}";
		}
	}
}
