namespace MockGraphQL.DataLayer
{
    public interface IClassroomRepository
    {
        Task<Classroom> GetClassroomById(int id);
        Task<List<Classroom>> GetClassrooms();
    }
}