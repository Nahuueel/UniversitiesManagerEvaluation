using UniversitiesManagerEvaluation.Infrastructure.Contracts.APIEntities;
using UniversitiesManagerEvaluation.Infrastructure.Contracts.Repositories;
using UniversitiesManagerEvaluation.Library.Contracts;

namespace UniversitiesManagerEvaluation.Library.Impl
{
    public class UniversitiesManagerServices : IUniversitiesManagerServices
    {
        private readonly IUniversitiesAPIRepository? _UniversitiesAPIRepository;

        public UniversitiesManagerServices(IUniversitiesAPIRepository? universitiesAPIRepository)
        {
            _UniversitiesAPIRepository = universitiesAPIRepository;
        }

        public async Task<UniversitiesListAPIEntity>? RetriveListOfUniversitiesFromAPI()
        {
            return await _UniversitiesAPIRepository.GetListOfUniversitiesInAPIs();
        }
    }
}
