namespace Logic
{
    public class PersonService
    {
        private readonly AppDbContext _context = new AppDbContext();

        public void Create(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var person = _context.People.SingleOrDefault(p => p.Id == id);
            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Person Read(int id)
        {
            return _context.People.SingleOrDefault(p => p.Id == id);
        }

        public Person Read(string firstname, string lastname)
        {
            return _context.People.FirstOrDefault(p => p.FirstName == firstname && p.LastName == lastname);
        }

        public Person ReadByAge(int age)
        {
            return _context.People.FirstOrDefault(p => p.Age == age);
        }

        public List<Person> ReadAll()
        {
            return _context.People.ToList();
        }
    }
}
