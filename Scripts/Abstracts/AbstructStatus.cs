using UniRx;
using UnityEngine;

/// <summary>
/// 抽象化ステータスクラス
/// </summary>
public abstract class AbstractStatus : MonoBehaviour, IStatus
{
    protected IntReactiveProperty lifeRP;
    public IntReactiveProperty Life { get { return lifeRP; } private set { } }

    protected FloatReactiveProperty powerRP;
    public FloatReactiveProperty Power { get { return powerRP; } private set { } }
}
