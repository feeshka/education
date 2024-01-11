namespace SpecFlowTests.Common;

/// <summary>
/// Базовый тип корня агрегации с хранимым состоянием.
/// </summary>
/// <typeparam name="TStateData">Тип хранимого состояния.</typeparam>
public abstract class AggregateRoot<TStateData> where TStateData : new()
{
    protected TStateData State { get; private set; } = new();

    /// <summary>
    /// Получить текущее хранимое состояние агрегата.
    /// </summary>
    /// <returns></returns>
    public TStateData GetState() => State;

    /// <summary>
    /// Установить новое хранимое состояние агрегата.
    /// </summary>
    /// <param name="newState">Новое хранимое состояние.</param>
    /// <exception cref="ArgumentNullException">Новое хранимое состояние не задано.</exception>
    public void SetState(TStateData newState) => State = newState ?? throw new ArgumentNullException(nameof(newState));
}
