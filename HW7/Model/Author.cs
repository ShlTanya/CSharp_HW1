using Microsoft.EntityFrameworkCore;
using System;

namespace HW7.Model
{
    [Index(nameof(FirstName), nameof(LastName), IsUnique = true)]
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Description { get; set; }
    }
}