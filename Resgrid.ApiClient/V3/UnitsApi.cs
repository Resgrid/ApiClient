using System.Collections.Generic;
using System.Threading.Tasks;
using Resgrid.ApiClient.V3.Models;

namespace Resgrid.ApiClient.V3
{
	/// <summary>
	/// Operations to perform against units in a department. A Unit can be an Apparatus or piece of equipment or groups of personnel
	/// </summary>
	public class UnitsApi
	{
		/// <summary>
		/// Will get basic, top level, information about a department in the Resgrid system
		/// </summary>
		/// <param name="departmentId">Non-negative DepartmentId to get</param>
		/// <returns>A list populated with the department data object. Depending on the departmentId passed in could also be BadRequest or Unauthorized http status codes.</returns>
		public static async Task<List<Unit>> Get(int departmentId)
		{
			return await ResgridV3ApiClient.Get<List<Unit>>($"Units/GetUnitsForDepartment?departmentId={departmentId}");
		}
	}
}
