namespace MockGraphQL.DataLayer
{
    public interface ILearnerRepository
    {
        Task<Learner> GetLearnerById(int id);
        Task<List<Learner>> GetLearners();
    }
}