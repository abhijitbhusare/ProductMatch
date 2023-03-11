namespace ProductMatch
{
	internal class ProductMatcherService
	{
		public List<List<Product>> GetMatchingProduct(List<Product> products1, List<Product> products2)
		{
			var matchingProducts = new List<List<Product>>() { new List<Product>(), new List<Product>()};
			foreach (var product1 in products1)
			{
				foreach (var product2 in products2)
				{
					if (product1.Upc == product2.Upc)
					{
						matchingProducts[0].Add(product1);
						matchingProducts[1].Add(product2);
					}
				}
			}
			return matchingProducts;
		}
	}
}
