using SophieTravelManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SophieTravelManagement.Domain.Entities
{
    public class TravelerCheckList
    {
        public TravelerCheckListId Id { get; private set; }
        private TravelerCheckListName _name;
        private Destination _destination;


        private readonly LinkedList<TravelerItem> _items = null;

        public TravelerCheckList()
        {

        }
        internal TravelerCheckList(TravelerCheckListId id,
            TravelerCheckListName name,
            Destination destination)
        {
            _destination = destination;
            _name = name;
            Id = id;
        }

        private TravelerCheckList(TravelerCheckListId id,
            TravelerCheckListName name,
            Destination destination,
            LinkedList<TravelerItem> items) : this(id, name, destination) 
        {
            _items = items;
        }
    }
}
