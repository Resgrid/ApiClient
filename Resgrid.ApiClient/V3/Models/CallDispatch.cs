using System;

namespace Resgrid.ApiClient.V3.Models
{
	public class CallDispatch
	{
		public int CallDispatchId { get; set; }
		public int CallId { get; set; }
		public string UserId { get; set; }
		public int? GroupId { get; set; }
		public int DispatchCount { get; set; }
		public DateTime? LastDispatchedOn { get; set; }
		public int? ActionLogId { get; set; }
	}
}
