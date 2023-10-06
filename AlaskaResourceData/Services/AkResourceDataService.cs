using System.Threading.Tasks;
using AlaskaResourceData.Data;
using AlaskaResourceData.Models;

namespace AlaskaResourceData.Services
{
    public class AkResourceDataService
    {
        static readonly AkResourceDataConnector ObjUsers = new AkResourceDataConnector();

        public static async Task<AkResourceData[]> GetResourceLocations()
        {
            var resMinesObjs = await ObjUsers.GetResourceLocations();
            return resMinesObjs;
        }
    }
}
