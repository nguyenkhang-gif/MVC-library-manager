namespace final_project.Models
{
    public class EFPersonRepository : IPersonRepository
    {
        private readonly TestDbContext ctx;

        public EFPersonRepository(TestDbContext ctx){
            this.ctx = ctx;
        }

        public IQueryable<Person> Persons => ctx.Persons;

    }
}