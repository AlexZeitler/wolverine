using FluentValidation.Results;

namespace Wolverine.FluentValidation;

/// <summary>
/// What do you do with a validation failure? Generally assumed to throw an
/// exception. Should be registered as a singleton when possible
/// </summary>
/// <typeparam name="T"></typeparam>
// ReSharper disable once TypeParameterCanBeVariant
public interface IFailureAction<T>
{
    void Throw(T message, IReadOnlyList<ValidationFailure> failures);
}