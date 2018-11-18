using UniRx;

/// <summary>
/// ステータス情報のインタフェース
/// </summary>
public interface IStatus
{
    IntReactiveProperty Life { get; }
    FloatReactiveProperty Power { get; }
}
