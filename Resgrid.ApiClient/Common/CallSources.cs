namespace Resgrid.ApiClient.Common
{
	/// <summary>
	/// The ways calls get created (added) in the Resgrid system
	/// </summary>
	public enum CallSources
	{
		/// <summary>
		/// A user manually created this call, via the website or apps
		/// </summary>
		User = 1,

		/// <summary>
		/// The call was created via an email import process
		/// </summary>
		EmailImport = 2,

		/// <summary>
		/// The call was created via the Resgrid.Relay (Resgrid.Audio) system
		/// </summary>
		AudioImport = 3
	}
}