using UniversitiesManagerEvaluation.Infrastructure.Contracts.APIEntities;

namespace UniversitiesManagerEvaluation.Library.Contracts
{
    public interface IUniversitiesManagerServices
    {
        Task<UniversitiesListAPIEntity>? RetriveListOfUniversitiesFromAPI();
    }
}