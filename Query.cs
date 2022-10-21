using MockGraphQL.DataLayer;

namespace MockGraphQL
{
    public class Query
    {
        private readonly IClassroomRepository _classroomRepository;
        private readonly ILearnerRepository _learnerRepository;

        public Query(ILearnerRepository learnerRepository, IClassroomRepository classroomRepository)
        {
            _learnerRepository = learnerRepository;
            _classroomRepository = classroomRepository;
        }

        public Task<List<Classroom>> GetClassrooms() => _classroomRepository.GetClassrooms();

        public Task<Learner> GetLearnerById(int id) => _learnerRepository.GetLearnerById(id);

        public Task<List<Learner>> GetLearners() => _learnerRepository.GetLearners();
    }
}