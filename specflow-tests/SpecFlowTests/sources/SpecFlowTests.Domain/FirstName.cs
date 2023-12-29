using SpecFlowTests.Common;
using SpecFlowTests.Domain.Types;

namespace SpecFlowTests.Domain;

/// <summary>
/// Value-object имени.
/// </summary>
public class FirstName
{
    private readonly string _value;

    /// <summary>
    /// Инициализирует новый экземпляр value-object-а имени.
    /// </summary>
    /// <param name="firstName">Имя.</param>
    /// <exception cref="InvariantValidationException">Нарушено одно из бизнес правил.</exception>
    public FirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new InvariantValidationException(InvariantViolationErrors.EmailCannotBeEmpty);
        }

        _value = firstName;
    }

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="value">Сырое значение.</param>
    public static implicit operator string(FirstName value) => value._value;

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="firstName">Сырое значение.</param>
    public static implicit operator FirstName(string firstName) => new FirstName(firstName);
}
