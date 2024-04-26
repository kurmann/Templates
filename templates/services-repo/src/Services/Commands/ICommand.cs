using CSharpFunctionalExtensions;

namespace NamespacePlaceholder.ProjectName.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}