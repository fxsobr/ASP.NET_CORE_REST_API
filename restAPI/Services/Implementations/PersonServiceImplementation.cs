using restAPI.Model;

namespace restAPI.Services.Implementations;

public class PersonServiceImplementation : IPersonService
{
    private volatile int _count;
    
    public Person Create(Person person)
    {
        return person;
    }

    public Person FindByID(long id)
    {
        return new Person
        {
            Id = IncrementAndGet(),
            FirstName = "Marcelo",
            LastName = "Ceolin",
            Address = "Rio do Sul, Santa Catarina",
            Gender = "Masculino"
        };
    }

    public List<Person> FindAll()
    {
        List<Person> persons = new List<Person>();
        for (int i = 0; i < 8; i++)
        {
            Person person = MockPerson(i);
            persons.Add(person);
        }
        return persons;
    }

    public Person Update(Person person)
    {
        return person;
    }

    public void Delete(long id)
    {
        
    }
    
    private Person MockPerson(int i)
    {
        return new Person
        {
            Id = IncrementAndGet(),
            FirstName = "Person name" + i,
            LastName = "Person lastname" + i,
            Address = "Person some address" + i,
            Gender = "Masculino"
        };
    }

    private long IncrementAndGet()
    {
        return Interlocked.Increment(ref _count);
    }
}