namespace SpecFlowTests.Common;

/// <summary>
/// Класс ошибки, описывающий нарушение бизнес правил для инварианта.
/// </summary>
public class InvariantValidationException : Exception
{
    /// <summary>
    /// Инициализирует новый экземпляр класса ошибки.
    /// </summary>
    /// <param name="errorCode">Код ошибки.</param>
    /// <param name="message">Поясняющее сообщение.</param>
    public InvariantValidationException(string errorCode, string? message = default)
        : base(message ?? $"An aggregate invariant broken with error code {errorCode}.")
    {
        ErrorCode = errorCode;
    }

    public string ErrorCode { get; }

}
