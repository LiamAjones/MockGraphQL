namespace MockGraphQL.DataLayer
{
    public class Classroom
    {
        public int Id { get; set; }
        public ICollection<Learner> Learners { get; set; }
        public string Name { get; set; }

        public Classroom(int id, string name)
        {
            Id = id;
            Name = name;
            Learners = new HashSet<Learner>();
        }
    }
}
