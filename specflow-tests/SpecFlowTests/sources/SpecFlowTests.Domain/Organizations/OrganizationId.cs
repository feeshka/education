using SpecFlowTests.Common;
using SpecFlowTests.Domain.Types;

namespace SpecFlowTests.Domain.Organizations;

/// <summary>
/// Value-object идентификатора организации.
/// </summary>
/// <remarks>
/// record struct - для того, чтобы запретить наследование и сравнивать по значению.
/// Такой подход следует использовать только для идентификаторов.
/// </remarks>
public readonly record struct OrganizationId
{
    private readonly Guid _value;

    /// <summary>
    /// Инициализирует новый экземпляр value-object-а идентификатора организации.
    /// </summary>
    /// <param name="id">Значение идентификатора.</param>
    /// <exception cref="InvariantValidationException">Нарушено одно из бизнес правил.</exception>
    public OrganizationId(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new InvariantValidationException(InvariantViolationErrors.EntityIdentifierCannotBeEmpty);
        }

        _value = id;
    }

    /// <summary>
    /// Технический конструктор.
    /// </summary>
    /// <remarks>
    /// Используется, чтобы запретить пользователю создавать структуру со значениями по умолчанию.
    /// </remarks>
    /// <exception cref="ArgumentException">Для создания экземпляра следует использовать конструктор с параметром.</exception>
    public OrganizationId()
    {
        throw new ArgumentException($"You must use another constructor");
    }

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="value">Сырое значение.</param>
    public static implicit operator Guid(OrganizationId value) => value._value;

    /// <summary>
    /// Приведение типов для удобства написания кода.
    /// </summary>
    /// <param name="id">Сырое значение.</param>
    public static implicit operator OrganizationId(Guid id) => new OrganizationId(id);
}
