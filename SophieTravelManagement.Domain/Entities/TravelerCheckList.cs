using SophieTravelManagement.Domain.Events;
using SophieTravelManagement.Domain.Exceptions;
using SophieTravelManagement.Domain.ValueObjects;
using SophieTravelManagement.Shared.Abstraction.Domain;

namespace SophieTravelManagement.Domain.Entities;

public class TravelerCheckList : AggregateRoot<TravelerCheckListId>
{
    public TravelerCheckListId Id { get; private set; }
    private TravelerCheckListName _name;
    private Destination _destination;


    private readonly LinkedList<TravelerItem> _items = new();

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



    public void AddItem(TravelerItem item)
    {
        var alreadyExists = _items.Any(i => i.Name == item.Name);

        if (alreadyExists)
            throw new TravelerItemAlreadyExistExceptin(_name.Name, item.Name);

        _items.AddLast(item);
        AddEvent(new TravelerItemAddedEvent(this, item));
    }


    public void AddItems(List<TravelerItem> items)
    {
        foreach (var item in items)
        {
            AddItem(item);
        }
    }

    private TravelerItem GetItem(string itemName)
    {
        var item = _items.SingleOrDefault(i => i.Name == itemName);
        if (item == null)
            throw new TravelerItemNotFoundException(itemName);

        return item;
    }

    public void TakeItem(string itemName)
    {
        var item = GetItem(itemName);
        var travelerItem = item with { IsTaken = true };

        _items.Find(item)!.Value = travelerItem;
        AddEvent(new TravelerItemTackenEvent(this, item));
    }

    public void RemoveItem(string itemName)
    {
        var item = GetItem(itemName);
        _items.Remove(item);
        AddEvent(new TravelerItemRemovedEvent(this, item));
    }
}
