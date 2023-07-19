namespace Financial_Manager.Attributes;
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public class BsonCollectionNameAttribute : Attribute
{
    public string CollectionName { get; }

    public BsonCollectionNameAttribute(string collectionName)
    {
        CollectionName = collectionName;
    }
}