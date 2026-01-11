using UnityEngine;

namespace PULGSS.Core
{
    /// <summary>
    /// ナビゲーションノード
    /// 移動可能な地点を表すGameObjectにアタッチ
    /// </summary>
    public class NavNode : MonoBehaviour
    {
        #region Private Fields
        [SerializeField] private string m_NodeID;
        [SerializeField] private bool m_IsAccessible = true;
        #endregion

        #region Public Properties
        public string NodeID => m_NodeID;
        public bool IsAccessible => m_IsAccessible;
        public Vector3 Position => transform.position;
        #endregion

        #region Unity Lifecycle
        private void Awake()
        {
            InitializeNode();
        }

        private void OnValidate()
        {
            if (string.IsNullOrEmpty(m_NodeID))
            {
                m_NodeID = gameObject.name;
            }
        }
        #endregion

        #region Private Methods
        private void InitializeNode()
        {
            if (string.IsNullOrEmpty(m_NodeID))
            {
                m_NodeID = gameObject.name;
            }

            // Colliderが存在しない場合は追加
            if (GetComponent<Collider>() == null)
            {
                BoxCollider collider = gameObject.AddComponent<BoxCollider>();
                collider.isTrigger = true;
                Debug.LogWarning($"NavNode '{gameObject.name}' has no Collider. Added BoxCollider as trigger.");
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// ノードのアクセス可能性を設定
        /// </summary>
        public void SetAccessible(bool _accessible)
        {
            m_IsAccessible = _accessible;
        }
        #endregion

        #if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            Gizmos.color = m_IsAccessible ? Color.green : Color.red;
            Gizmos.DrawWireSphere(transform.position, 0.5f);
        }
        #endif
    }
}
