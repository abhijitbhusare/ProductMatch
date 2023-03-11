using RestEase;
using System.Net.Mime;
using System.Text.Encodings.Web;

namespace ProductMatch
{
	
	public interface IBannerProductProvider 
	{
		[Get("products/json")]
		public Task<string> GetProductsAsJson([Header("authorization")] string authToken);
	}

	public interface IRSHughesProductProvider
	{
		[Get("products/xml")]
		public Task<string> GetProductsAsXml([Header("authorization")] string authToken);
	}

	public interface IAuthinthicator
	{
		[Post("realms/ctesting/protocol/openid-connect/token")]
		public Task<string> GetAuthToken([Body(BodySerializationMethod.UrlEncoded)] IDictionary<string, string> tokenApiInput);
	}

	public interface IProductProvider 
	{
		public Products GetProducts();
	}
}