namespace Resgrid.ApiClient.V3.Models
{
	/// <summary>
	/// Definition of a call Priority for a department, including the system defaults 
	/// </summary>
	public class CallPriority
	{
		/// <summary>
		/// Id for the call Priority
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// DepartmentId the Call Priority is for
		/// </summary>
		public int DepartmentId { get; set; }

		/// <summary>
		/// Name of the Call Priority
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Color for the Call Priority
		/// </summary>
		public string Color { get; set; }

		/// <summary>
		/// Ascending Sort Order
		/// </summary>
		public int Sort { get; set; }

		/// <summary>
		/// Is this call priority deleted
		/// </summary>
		public bool IsDeleted { get; set; }

		/// <summary>
		/// Is this the default call priority
		/// </summary>
		public bool IsDefault { get; set; }

		/// <summary>
		/// Should this call priority dispatch personnel
		/// </summary>
		public bool DispatchPersonnel { get; set; }


		/// <summary>
		/// Should this call priority dispatch units
		/// </summary>
		public bool DispatchUnits { get; set; }

		/// <summary>
		/// Force notify all personnel for this call priority (all-call)
		/// </summary>
		public bool ForceNotifyAllPersonnel { get; set; }

		/// <summary>
		/// Tone Id to use for calls of this Call Priority (Push Notifications)
		/// </summary>
		public int Tone { get; set; }

		/// <summary>
		/// Is this a system supplied (i.e. default) call priority
		/// </summary>
		public bool IsSystemPriority { get; set; }
	}
}
