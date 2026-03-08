using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ListLocationAvailabilitySlotsResponseDTO 
    {
        public string Identifier { get; init; }

        public string? Title { get; init; }

        public DateTime StartUtc { get; init; }

        public DateTime Start { get; init; }

        public DateTime End { get; init; }

        public string PracticeId { get; init; }

        public string PractitionerId { get; init; }

        public int AvailableDuration { get; init; }

        public int SegmentIndex { get; init; }

        public int Priority { get; init; }

        public string PractitionerName { get; init; }

        public string PracticeName { get; init; }

        public DateTime Date { get; init; }
    }
}
