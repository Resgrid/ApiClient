using Resgrid.ApiClient.V3.Models;
using System.Threading.Tasks;

namespace Resgrid.ApiClient.V3
{
	public class EmailApi
	{
		public static async Task<Call> ImportEmail(Call call)
		{
			return await ResgridV3ApiClient.Post<Call>("AddCall", call);
		}
	}
}
