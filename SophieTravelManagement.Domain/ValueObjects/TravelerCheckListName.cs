using SophieTravelManagement.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SophieTravelManagement.Domain.ValueObjects
{
    public record TravelerCheckListName
    {
        public string Name { get; }

        public TravelerCheckListName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new TravelerCheckListNameException();
            Name = name; 
        }

        public static implicit operator string(TravelerCheckListName name) => name.Name;
        public static implicit operator TravelerCheckListName(string name) => new(name);
    }
}
