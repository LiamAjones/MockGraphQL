using MockGraphQL.DataLayer;

namespace MockGraphQL
{
    public class LearnerType : ObjectType<Learner>
    {
        private readonly IClassroomRepository _classroomRepository;

        public LearnerType(IClassroomRepository classroomRepository)
        {
            _classroomRepository = classroomRepository;
        }

        protected override void Configure(IObjectTypeDescriptor<Learner> descriptor)
        {
            descriptor.Field(a => a.Id).Type<IdType>();
            descriptor.Field(a => a.FirstName).Type<StringType>();
            descriptor.Field(a => a.LastName).Type<StringType>();
            descriptor.Field("classroom").Resolve((context, _) =>
                _classroomRepository.GetClassroomById(context.Parent<Learner>().ClassroomId));
        }
    }
}
