using System.Threading.Tasks;
using Resgrid.ApiClient.V3.Models;

namespace Resgrid.ApiClient.V3
{
	public class HealthApi
	{
		public static async Task<HealthResult> GetApiHealth()
		{
			return await ResgridV3ApiClient.Get<HealthResult>("Health/GetCurrent");
		}
	}
}
