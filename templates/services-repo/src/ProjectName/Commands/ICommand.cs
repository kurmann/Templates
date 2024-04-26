using CSharpFunctionalExtensions;

namespace RootNamespace.ProjectName.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}