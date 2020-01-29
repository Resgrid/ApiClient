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
		/// Will get all the units for a department
		/// </summary>
		/// <param name="departmentId">Non-negative DepartmentId to get</param>
		/// <returns>A list populated with the units for a department. Depending on the departmentId passed in could also be BadRequest or Unauthorized http status codes.</returns>
		public static async Task<List<Unit>> GetUnitsForDepartment(int departmentId)
		{
			return await ResgridV3ApiClient.Get<List<Unit>>($"Units/GetUnitsForDepartment?departmentId={departmentId}");
		}
	}
}
