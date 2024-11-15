using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UniversitiesManagerEvaluation.Infrastructure.Contracts.APIEntities
{
    public class UniversitiesListAPIEntity
    {
        [JsonPropertyName("property1")]
        public List<UniversityAPIEntity>? Property1 { get; set; }
    }
    public class UniversityAPIEntity
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("alpha_two_code")]
        public string? Alpha_two_code { get; set; }
        [JsonPropertyName("domains")]
        public List<string>? Domains { get; set; }
        [JsonPropertyName("stateprovince")]
        public object? Stateprovince { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("web_pages")]
        public List<string>? Web_pages { get; set; }
    
    }
}


