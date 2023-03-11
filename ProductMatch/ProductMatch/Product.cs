using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ProductMatch
{
	[XmlRoot(ElementName = "product")]
	public class Product
	{

		[JsonPropertyName("itemCode")]
		[XmlElement(ElementName = "itemCode")]
		public string ItemCode { get; set; }

		[JsonPropertyName("name")]
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }

		[JsonPropertyName("manufacturer")]
		[XmlElement(ElementName = "manufacturer")]
		public string Manufacturer { get; set; }

		[JsonPropertyName("mpn")]
		public string Mpn { get; set; }

		[JsonPropertyName("upc")]
		[XmlElement(ElementName = "upc")]
		public double Upc { get; set; }

		[JsonPropertyName("price")]
		[XmlElement(ElementName = "price")]
		public double Price { get; set; }

		[JsonPropertyName("brand")]
		[XmlElement(ElementName = "brand")]
		public string Brand { get; set; }
	}
}
