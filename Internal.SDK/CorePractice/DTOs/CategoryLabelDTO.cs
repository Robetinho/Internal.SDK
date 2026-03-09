using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class CategoryLabelDTO
    {
        public required string Identifier { get; init; }

        public string? Name { get; init; }

        public string? Description { get; init; }

        public string? Icon { get; init; }

        public int? Order { get; init; }

        public bool? IsActive { get; init; }

        public bool? IsDeleted { get; init; }

        public string? Type { get; init; }
    }
}
