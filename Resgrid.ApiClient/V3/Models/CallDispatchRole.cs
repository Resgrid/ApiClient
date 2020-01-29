using System;

namespace Resgrid.ApiClient.V3.Models
{
	public class CallDispatchRole
	{
		public int CallDispatchRoleId { get; set; }
		public int CallId { get; set; }
		public int RoleId { get; set; }
		public int DispatchCount { get; set; }
		public DateTime? LastDispatchedOn { get; set; }
	}
}
