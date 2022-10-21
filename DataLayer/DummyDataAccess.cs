namespace MockGraphQL.DataLayer
{
    public class DummyDataAccess : IClassroomRepository, ILearnerRepository
    {
        private readonly List<Classroom> _classrooms = new()
        {
            new Classroom(1, "Electrical engineering"),
            new Classroom(2, "Computer science"),
            new Classroom(3, "Mathematics")
        };

        private readonly List<Learner> _learners = new()
        {
            new Learner(1,"Jeri","Cram", 1),
            new Learner(2,"Nikolai","Ferrotti", 1),
            new Learner(3,"Clemence","Pues", 1),
            new Learner(4,"Ron","Merryfield",2),
            new Learner(5,"Faina","Joule",2),
            new Learner(6,"Evangelia","Brattan",2),
            new Learner(7,"Archibald","Barrus",2),
            new Learner(8,"Ted","Fonzo",2),
            new Learner(9,"Nicol","Nayer",2),
            new Learner(10,"Marcela","Chatteris",2),
            new Learner(11,"Maurie","Mordanti",2),
            new Learner(12,"Maryrose","Antley",2),
            new Learner(13,"Nicki","Preble",2),
            new Learner(14,"Milli","Argont",2),
            new Learner(15,"Willi","Trenoweth",2),
            new Learner(16,"Scarlett","Cary",2),
            new Learner(17,"Candie","Argontt",2),
            new Learner(18,"Zed","Stoade",2),
            new Learner(19,"Giffard","Alvarado",3),
            new Learner(20,"Ferne","Barrs",3),
            new Learner(21,"Smith","Radcliffe",3),
            new Learner(22,"Hendrick","Blackeby",3),
            new Learner(23,"Sophey","Scurfield",3),
            new Learner(24,"Gloriana","Lockery",3),
            new Learner(25,"Cookie","Sackur",3)
        };

        public Task<Classroom> GetClassroomById(int id)
        {
            return Task.FromResult(_classrooms.First(c => c.Id.Equals(id)));
        }

        public Task<List<Classroom>> GetClassrooms()
        {
            return Task.FromResult(_classrooms);
        }

        public Task<Learner> GetLearnerById(int id)
        {
            return Task.FromResult(_learners.First(l => l.Id.Equals(id)));
        }

        public Task<List<Learner>> GetLearners()
        {
            return Task.FromResult(_learners);
        }
    }
}
