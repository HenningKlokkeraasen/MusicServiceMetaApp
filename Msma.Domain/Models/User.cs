using System.Collections.Generic;

namespace Msma.Domain.Models
{
    public class User
    {
        public string DisplayName { get; set; }

        public IEnumerable<Image> Images { get; set; }
    }
}