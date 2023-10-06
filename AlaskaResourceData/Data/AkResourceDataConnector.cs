using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MySqlConnector;
using AlaskaResourceData.Models;

namespace AlaskaResourceData.Data
{
    public class AkResourceDataConnector
    {
        public Task<AkResourceData[]> GetResourceLocations()
        {
            List<AkResourceData> list = new List<AkResourceData>();
            using (MySqlConnection connector = SqlHelper.GetConnection())
            {
                connector.Open();
                using (MySqlCommand cmd = new MySqlCommand("akResDataGet", connector))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new AkResourceData()
                            {
                                ArdfNum = reader.GetString("ArdfNum"),
                                MrdsNum = reader.GetString("MrdsNum"),
                                Site = reader.GetString("Site"),
                                Latitude = reader.GetFloat("Latitude"),
                                Longitude = reader.GetFloat("Longitude"),
                                Location = reader.GetString("Location"),
                                Quad250 = reader.GetString("Quad250"),
                                Quad63360 = reader.GetString("Quad63360"),
                                CommMain = reader.GetString("CommMain"),
                                CommOther = reader.GetString("CommOther"),
                                Ore = reader.GetString("Ore"),
                                Gangue = reader.GetString("Gangue"),
                                SiteType = reader.GetString("SiteType"),
                                Status = reader.GetString("Status"),
                                Production = reader.GetString("Production"),
                                DepModel = reader.GetString("DepModel"),
                                GeolDesc = reader.GetString("GeolDesc"),
                                WorkExpl = reader.GetString("WorkExpl"),
                                Comments = reader.GetString("Comments"),
                                ExpandRef = reader.GetString("ExpandRef"),
                                ReptNames = reader.GetString("ReptNames"),
                                ReptDate = reader.GetString("ReptDate"),
                                Age = reader.GetString("Age"),
                                ReptAff = reader.GetString("ReptAff"),
                                ModelCode = reader.GetString("ModelCode"),
                                Alteration = reader.GetString("Alteration"),
                                ProdNotes = reader.GetString("ProdNotes"),
                                Reserves = reader.GetString("Reserves"),
                                PrimeRef = reader.GetString("PrimeRef")
                            });
                        }
                    }
                }
            }
            return Task.FromResult(list.ToArray());
        }
    }
}