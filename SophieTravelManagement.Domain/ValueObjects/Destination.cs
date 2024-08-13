using SophieTravelManagement.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SophieTravelManagement.Domain.ValueObjects
{
    public record Destination(string City, string Country)
    {

        public static Destination Create(string value)
        {
            var splitData = value.Split(',');
            return new Destination(splitData[0], splitData[1]);
        }

        public override string ToString()
            => $"{City},{Country}";
    }
}
