using System.Threading.Tasks;
using Resgrid.ApiClient.V3.Models;

namespace Resgrid.ApiClient.V3
{
    public class CallPrioritiesApi
	{
	    public static async Task<CallPriority> GetAllCallPriorites(int departmentId)
	    {
		    return await ResgridV3ApiClient.Get<CallPriority>($"CallPriorities/GetAllCallPrioritesForDepartment?departmentId={departmentId}");
	    }
    }
}
