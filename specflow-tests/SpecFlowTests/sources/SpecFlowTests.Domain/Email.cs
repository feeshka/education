using SpecFlowTests.Common;
using SpecFlowTests.Domain.Types;

namespace SpecFlowTests.Domain;

/// <summary>
/// Value-object электронного адреса.
/// </summary>
public class Email
{
    private readonly string _value;

    /// <summary>
    /// Инициализирует новый экземпляр value-object-а электронного адреса.
    /// </summary>
    /// <param name="email">Электронный адрес пользователя.</param>
    /// <exception cref="InvariantValidationException">Нарушено одно из бизнес правил.</exception>
    public Email(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new InvariantValidationException(InvariantViolationErrors.EmailCannotBeEmpty);
        }

        _value = email;
    }

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="value">Сырое значение.</param>
    public static implicit operator string(Email value) => value._value;

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="email">Сырое значение.</param>
    public static implicit operator Email(string email) => new Email(email);
}