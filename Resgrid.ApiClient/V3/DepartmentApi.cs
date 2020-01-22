using System.Collections.Generic;
using System.Threading.Tasks;
using Resgrid.ApiClient.V3.Models;

namespace Resgrid.ApiClient.V3
{
	/// <summary>
	/// General department level options
	/// </summary>
	public class DepartmentApi
	{
		/// <summary>
		/// Will get basic, top level, information about a department in the Resgrid system
		/// </summary>
		/// <param name="departmentId">Non-negative DepartmentId to get</param>
		/// <returns>A list populated with the department data object. Depending on the departmentId passed in could also be BadRequest or Unauthorized http status codes.</returns>
		public static async Task<List<Department>> Get(int departmentId)
		{
			return await ResgridV3ApiClient.Get<List<Department>>($"Department/Get?departmentId={departmentId}");
		}

		/// <summary>
		/// Will get optional department information about a department in the Resgrid system
		/// </summary>
		/// <param name="departmentId">Non-negative DepartmentId to get</param>
		/// <returns>A list populated with the department options object. Depending on the departmentId passed in could also be BadRequest or Unauthorized http status codes.</returns>
		public static async Task<List<DepartmentOption>> GetOptions(int departmentId)
		{
			return await ResgridV3ApiClient.Get<List<DepartmentOption>>($"Department/GetDepartmentOptions?departmentId={departmentId}");
		}
	}
}
