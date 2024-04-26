using CSharpFunctionalExtensions;

namespace NamespacePlaceholder.ProjectName.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}