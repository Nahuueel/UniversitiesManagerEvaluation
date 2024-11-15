using UniversitiesManagerEvaluation.Infrastructure.Contracts.APIEntities;

namespace UniversitiesManagerEvaluation.Infrastructure.Contracts.Repositories
{
    public interface IUniversitiesAPIRepository
    {
        public Task<UniversitiesListAPIEntity>? GetListOfUniversitiesInAPIs();
    }
}