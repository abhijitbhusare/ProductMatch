namespace ProductMatch
{
	public class ProductPrinterService
	{
		public void PrintMatchingProducts(List<List<Product>> products)
		{
			for (int contour = 0; contour < products[0].Count; contour++)
			{
				Console.WriteLine("------------------------------------------------------");
				Console.WriteLine($"UPC {products[0][contour].Upc}");
				Console.WriteLine($"ItemCode from Banner {products[0][contour].ItemCode}");
				Console.WriteLine($"ItemCode from RSHughes {products[1][contour].ItemCode}");
			}
		}
	}
}
