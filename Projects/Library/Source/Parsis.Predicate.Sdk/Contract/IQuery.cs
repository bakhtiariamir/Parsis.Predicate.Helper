﻿using Parsis.Predicate.Sdk.Query;

namespace Parsis.Predicate.Sdk.Contract;

public interface IQuery<TObject, TQueryResult> where TObject : class 
{
    QueryObject<TObject> ObjectQuery
    {
        get;
    }

    Task<TQueryResult> Build();
}
