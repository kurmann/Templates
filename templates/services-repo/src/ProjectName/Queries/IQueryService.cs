using CSharpFunctionalExtensions;

namespace RootNamespace.ProjectName.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}