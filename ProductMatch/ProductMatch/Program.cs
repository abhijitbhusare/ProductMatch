// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using ProductMatch;
using System.Reflection;

public class Program
{
	private static IAppConfig GetAppConfig()
	{
		var appConfigPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AppConfig.json");
		var appConfig = JsonConvert.DeserializeObject<AppConfig>(File.ReadAllText(appConfigPath));
		return appConfig;
	}

	public static void Main()
	{
		var appConfig = GetAppConfig();
		var tokenGenertor = new TokenGenerator(appConfig.TokenBaseUri, appConfig.GrantType, appConfig.ClientId, appConfig.ClientSecret, appConfig.Scope);
		var authToken = tokenGenertor.Generate();
		var bannerProductProvider = new BannerProductProvider(appConfig.ProductBaseUri, authToken);
		var bannerProducts = bannerProductProvider.GetProducts();
		var RSHughesProductProvider = new RSHughesProductProvider(appConfig.ProductBaseUri, authToken);
		var rshughesProducts = RSHughesProductProvider.GetProducts();
		var productMatcher = new ProductMatcherService();
		var matchingProducts = productMatcher.GetMatchingProduct(bannerProducts.products, rshughesProducts.products);
		var productPrinter = new ProductPrinterService();
		productPrinter.PrintMatchingProducts(matchingProducts);
	}
}
