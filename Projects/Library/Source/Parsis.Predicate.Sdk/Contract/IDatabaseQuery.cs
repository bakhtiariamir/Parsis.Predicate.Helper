﻿using Parsis.Predicate.Sdk.Builder.Database;

namespace Parsis.Predicate.Sdk.Contract;
public interface IDatabaseQuery<TObject> : IQuery<TObject, DatabaseQueryPartCollection> where TObject : class
{
    Task GenerateColumn();

    Task GenerateWhereClause();

    Task GeneratePagingClause();

    Task GenerateOrderByClause();

    Task GenerateJoinClause();

    Task GenerateGroupByClause();

}
