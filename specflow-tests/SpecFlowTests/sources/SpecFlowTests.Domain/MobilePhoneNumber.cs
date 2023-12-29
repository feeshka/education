using SpecFlowTests.Common;
using SpecFlowTests.Domain.Types;

namespace SpecFlowTests.Domain;

/// <summary>
/// Value-object мобильного номера телефона.
/// </summary>
public class MobilePhoneNumber
{
    private readonly string _value;

    /// <summary>
    /// Инициализирует новый экземпляр value-object-а номера телефона.
    /// </summary>
    /// <param name="mobilePhoneNumber">Номер телефона.</param>
    /// <exception cref="InvariantValidationException">Нарушено одно из бизнес правил.</exception>
    public MobilePhoneNumber(string mobilePhoneNumber)
    {
        if (string.IsNullOrWhiteSpace(mobilePhoneNumber))
        {
            throw new InvariantValidationException(InvariantViolationErrors.PhoneNumberCannotBeEmpty);
        }

        _value = mobilePhoneNumber;
    }

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="value">Сырое значение.</param>
    public static implicit operator string(MobilePhoneNumber value) => value._value;

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="mobilePhoneNumber">Сырое значение.</param>
    public static implicit operator MobilePhoneNumber(string mobilePhoneNumber) => new MobilePhoneNumber(mobilePhoneNumber);
}
