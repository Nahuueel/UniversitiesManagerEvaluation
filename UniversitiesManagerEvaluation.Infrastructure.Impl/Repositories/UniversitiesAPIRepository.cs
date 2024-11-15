using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UniversitiesManagerEvaluation.Infrastructure.Contracts.APIEntities;
using UniversitiesManagerEvaluation.Infrastructure.Contracts.Repositories;

namespace UniversitiesManagerEvaluation.Infrastructure.Impl.Repositories
{
    public class UniversitiesAPIRepository : IUniversitiesAPIRepository
    {
        public async Task<UniversitiesListAPIEntity>? GetListOfUniversitiesInAPIs()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://universities.hipolabs.com/search");
            string DataAsString = await response.Content.ReadAsStringAsync();
            UniversitiesListAPIEntity? Result = JsonSerializer.Deserialize<UniversitiesListAPIEntity>(DataAsString);
            return Result;
        }
    }
}
