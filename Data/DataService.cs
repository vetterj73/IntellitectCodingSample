using System.Collections.Generic;

namespace WPFExample.Data
{
    public static class DataService
    {
        public static IEnumerable<Person> GetPeople()
        {
            yield return new Person { Name = "John", Sex = Sex.Male };
            yield return new Person { Name = "Jake", Sex = Sex.Male };
            yield return new Person { Name = "Sally", Sex = Sex.Female };
            yield return new Person { Name = "Mary", Sex = Sex.Female };
            yield return new Person { Name = "Ian", Sex = Sex.Male };
            yield return new Person { Name = "Kate", Sex = Sex.Female };
            yield return new Person { Name = "Mel", Sex = Sex.Female };
        }
    }
}