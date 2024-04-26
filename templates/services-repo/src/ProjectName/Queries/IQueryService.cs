using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.ProjectName.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}