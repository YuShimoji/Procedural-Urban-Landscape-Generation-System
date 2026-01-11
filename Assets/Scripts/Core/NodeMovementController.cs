using UnityEngine;
using System.Collections;

namespace PULGSS.Core
{
    /// <summary>
    /// ノード間を移動するためのコントローラー
    /// 補足仕様書 1.1 ビューポートと操作に準拠
    /// </summary>
    public class NodeMovementController : MonoBehaviour
    {
        #region Constants
        private const float c_TransitionDuration = 0.4f; // 0.3～0.5秒のトランジション
        #endregion

        #region Private Fields
        [SerializeField] private Camera m_MainCamera;
        [SerializeField] private float m_TransitionDuration = c_TransitionDuration;
        [SerializeField] private LayerMask m_NavNodeLayer;
        [SerializeField] private bool m_IsTransitioning = false;
        #endregion

        #region Public Properties
        public bool IsTransitioning => m_IsTransitioning;
        public Camera MainCamera => m_MainCamera;
        #endregion

        #region Unity Lifecycle
        private void Awake()
        {
            InitializeComponents();
        }

        private void Update()
        {
            HandleInput();
        }
        #endregion

        #region Private Methods
        private void InitializeComponents()
        {
            if (m_MainCamera == null)
            {
                m_MainCamera = Camera.main;
                if (m_MainCamera == null)
                {
                    m_MainCamera = FindFirstObjectByType<Camera>();
                }
            }

            if (m_NavNodeLayer.value == 0)
            {
                Debug.LogWarning("NavNodeLayer is not set. Please set the layer in the Inspector.");
            }
        }

        private void HandleInput()
        {
            if (m_IsTransitioning)
            {
                return;
            }

            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = m_MainCamera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, m_NavNodeLayer))
                {
                    NavNode targetNode = hit.collider.GetComponent<NavNode>();
                    if (targetNode != null)
                    {
                        StartCoroutine(MoveToNode(targetNode));
                    }
                }
            }
        }

        private IEnumerator MoveToNode(NavNode _targetNode)
        {
            m_IsTransitioning = true;

            // トランジション開始: エフェクト処理（プレースホルダー）
            // 補足仕様書1.1: モザイク処理、RGBズレ、高速ドリーを組み合わせ
            yield return StartCoroutine(TransitionEffect(true));

            // カメラ位置を移動
            Transform targetTransform = _targetNode.transform;
            m_MainCamera.transform.position = targetTransform.position;
            m_MainCamera.transform.rotation = targetTransform.rotation;

            // トランジション終了: エフェクト処理
            yield return StartCoroutine(TransitionEffect(false));

            m_IsTransitioning = false;
        }

        /// <summary>
        /// 移動時のトランジションエフェクト（プレースホルダー実装）
        /// 補足仕様書1.1に基づく: 0.3～0.5秒のトランジション
        /// </summary>
        private IEnumerator TransitionEffect(bool _isStarting)
        {
            float elapsedTime = 0f;
            float duration = m_TransitionDuration * 0.5f; // 開始と終了で半分ずつ

            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float progress = elapsedTime / duration;

                // TODO: 実際のエフェクト実装
                // - モザイク処理
                // - RGBズレ（Chromatic Aberration）
                // - 高速ドリー（カメラ前進アニメーション）
                // 現時点では時間経過のみ処理

                yield return null;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 外部からノードへの移動を開始する
        /// </summary>
        public void MoveToNodeExternal(NavNode _targetNode)
        {
            if (!m_IsTransitioning && _targetNode != null)
            {
                StartCoroutine(MoveToNode(_targetNode));
            }
        }
        #endregion
    }
}
