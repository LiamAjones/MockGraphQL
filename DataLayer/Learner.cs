namespace MockGraphQL.DataLayer
{
    public class Learner
    {
        public Classroom Classroom { get; set; }
        public int ClassroomId { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }

        public Learner(int id, string firstName, string lastName, int classroomId)
        {
            ClassroomId = classroomId;
            FirstName = firstName;
            Id = id;
            LastName = lastName;
        }
    }
}