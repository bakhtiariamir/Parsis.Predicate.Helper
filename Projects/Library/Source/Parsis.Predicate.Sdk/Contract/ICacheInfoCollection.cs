namespace Parsis.Predicate.Sdk.Contract;

public interface ICacheInfoCollection<TObjectInfo>
{
    TObjectInfo InitCache(string objectType, TObjectInfo value);
    bool TryRemove(string objectType, out TObjectInfo? value);
    bool RemoveCache(string objectType);

    bool TryGet(string objectType, out IDatabaseObjectInfo? value);

    string GetKey(string objectType);
}