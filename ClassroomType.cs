using MockGraphQL.DataLayer;

namespace MockGraphQL
{
    public class ClassroomType : ObjectType<Classroom>
    {
        private readonly ILearnerRepository _learnerRepository;

        public ClassroomType(ILearnerRepository learnerRepository)
        {
            _learnerRepository = learnerRepository;
        }

        protected override void Configure(IObjectTypeDescriptor<Classroom> descriptor)
        {
            descriptor.Field(a => a.Id).Type<IdType>();
            descriptor.Field("learners").Resolve(async (context, _) =>
            {
                return (await _learnerRepository.GetLearners()).Where(c =>
                    c.ClassroomId == context.Parent<Classroom>().Id);
            });
        }
    }
}
