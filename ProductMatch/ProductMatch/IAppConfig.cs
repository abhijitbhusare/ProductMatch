namespace ProductMatch
{
	internal interface IAppConfig
	{
		string GrantType { get; set; }
		string ClientId { get; set; }
		string ClientSecret { get; set; }
		string ProductBaseUri { get; set; }
		string Scope { get; set; }
		string TokenBaseUri { get; set; }
	}
}