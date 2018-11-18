using UnityEngine;

/// <summary>
/// MonoBehaviourのシングルトン実装クラス
/// </summary>
/// <typeparam name="T"></typeparam シングルトンを実装するクラス>
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T m_instance;  // 自分のインスタンス

    /// <summary>
    /// インスタンスの生成
    /// </summary>
    public static T Instance
    {
        get
        {
            // 自分のインスタンスが存在しない場合
            if(m_instance == null)
            {
                // 自分のインスタンスを生成
                m_instance = (T)FindObjectOfType(typeof(T));

                // エラー
                if(m_instance == null)
                {
                    Debug.Log(typeof(T) + "is nothing");
                }
            }

            return m_instance;
        }
    }
}
