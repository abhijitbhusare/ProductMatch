using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ProductMatch
{
	[XmlRoot(ElementName = "ProductsResponse")]
	public class Products
	{

		[XmlElement(ElementName = "product")]
		[JsonPropertyName("products")]
		public List<Product> products { get; set; }
	}
}
