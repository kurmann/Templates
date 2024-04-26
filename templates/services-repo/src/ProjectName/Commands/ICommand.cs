using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.ProjectName.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}