namespace ProductMatch
{
	internal class AppConfig : IAppConfig
	{
		public string TokenBaseUri { get; set; }
		public string GrantType { get; set; }
		public string ClientId { get; set; }
		public string ClientSecret { get; set; }
		public string Scope { get; set; }
		public string ProductBaseUri { get; set; }
	}
}
