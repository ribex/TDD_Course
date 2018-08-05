using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Course
{
    public class NaiveCanonicalizer
    {
        public static string GetCanonicalForm(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                throw new ArgumentNullException("searchTerm");
            return searchTerm
                .Split(new[] { ' ' })
                .Select(x => x.ToUpper())
                .OrderBy(x => x)
                .Aggregate((x, y) => x + " " + y);
        }
    }
}
