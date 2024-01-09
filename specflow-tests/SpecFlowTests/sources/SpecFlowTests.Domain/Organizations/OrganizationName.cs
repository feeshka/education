using SpecFlowTests.Common;
using SpecFlowTests.Domain.Types;

namespace SpecFlowTests.Domain.Organizations;

/// <summary>
/// Value-object наименования организации.
/// </summary>
public class OrganizationName
{
    private readonly string _value;

    /// <summary>
    /// Инициализирует новый экземпляр value-object-а наименования организации.
    /// </summary>
    /// <param name="organizationName">Наименование организации.</param>
    /// <exception cref="InvariantValidationException">Нарушено одно из бизнес правил.</exception>
    public OrganizationName(string organizationName)
    {
        if (string.IsNullOrWhiteSpace(organizationName))
        {
            throw new InvariantValidationException(InvariantViolationErrors.OrganizationNameCannotBeEmpty);
        }

        _value = organizationName;
    }

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="value">Сырое значение.</param>
    public static implicit operator string(OrganizationName value) => value._value;

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="organizationName">Сырое значение.</param>
    public static implicit operator OrganizationName(string organizationName) => new OrganizationName(organizationName);
}
