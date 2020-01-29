using System.Collections.Generic;
using System.Threading.Tasks;
using Resgrid.ApiClient.V3.Models;

namespace Resgrid.ApiClient.V3
{
	/// <summary>
	/// For retrieving and creating calls (Dispatches)
	/// </summary>
	public class CallsApi
	{
		/// <summary>
		/// Create and Dispatch a call
		/// </summary>
		/// <param name="call">Fully populated call object</param>
		/// <returns>Call created in the Resgrid system</returns>
		public static async Task<Call> AddNewCall(Call call)
		{
			return await ResgridV3ApiClient.Post<Call>("Calls/AddCall", call);
		}

		/// <summary>
		/// Gets all active calls for the supplied department
		/// </summary>
		/// <param name="departmentId">Non-negative DepartmentId to get</param>
		/// <returns>A list populated with calls from the Resgrid API. Depending on the departmentId passed in could also be BadRequest or Unauthorized http status codes.</returns>
		public static async Task<List<Call>> GetActiveCalls(int departmentId)
		{
			return await ResgridV3ApiClient.Get<List<Call>>($"Calls/GetActiveCallsForDepartment?departmentId={departmentId}");
		}
	}
}
