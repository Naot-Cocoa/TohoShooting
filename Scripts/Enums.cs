/// <summary>
/// 列挙型の管理空間
/// </summary>
namespace Enums
{
    /// <summary>
    /// 弾の種類
    /// </summary>
    enum BulletType
    {
        Straight,
        Spread,
        Homing,
        Random
    }

    /// <summary>
    /// シーンの状態
    /// </summary>
    enum SceneState
    {
        Title,
        InGame,
        Result,
        Option
    }

    /// <summary>
    /// ゲームプレイの状態
    /// </summary>
    enum InGameState
    {
        Play,
        Pause
    }

    /// <summary>
    /// ステージの状態
    /// </summary>
    enum StageState
    {
        First,
        Second,
        Third,
        Forth,
        Fifth,
        Sixth,
        Extra
    }
}