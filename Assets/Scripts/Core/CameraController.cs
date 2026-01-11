using UnityEngine;

namespace PULGSS.Core
{
    /// <summary>
    /// カメラコントローラー
    /// 補足仕様書1.1: ドラッグ（PC）またはスティック（Gamepad）による360度回転
    /// 垂直方向（Pitch）にはクランプ（-60度〜+60度）を設ける
    /// </summary>
    public class CameraController : MonoBehaviour
    {
        #region Constants
        private const float c_MinPitch = -60f;
        private const float c_MaxPitch = 60f;
        private const float c_MouseSensitivity = 2f;
        #endregion

        #region Private Fields
        [SerializeField] private float m_MouseSensitivity = c_MouseSensitivity;
        [SerializeField] private float m_MinPitch = c_MinPitch;
        [SerializeField] private float m_MaxPitch = c_MaxPitch;
        [SerializeField] private bool m_IsDragging = false;
        private float m_CurrentYaw = 0f;
        private float m_CurrentPitch = 0f;
        #endregion

        #region Unity Lifecycle
        private void Start()
        {
            Vector3 eulerAngles = transform.eulerAngles;
            m_CurrentYaw = eulerAngles.y;
            m_CurrentPitch = eulerAngles.x;

            // Pitchを-180～180の範囲に正規化
            if (m_CurrentPitch > 180f)
            {
                m_CurrentPitch -= 360f;
            }
        }

        private void Update()
        {
            HandleMouseInput();
            HandleGamepadInput();
        }
        #endregion

        #region Private Methods
        private void HandleMouseInput()
        {
            if (Input.GetMouseButtonDown(0))
            {
                m_IsDragging = true;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                m_IsDragging = false;
            }

            if (m_IsDragging)
            {
                float mouseX = Input.GetAxis("Mouse X") * m_MouseSensitivity;
                float mouseY = Input.GetAxis("Mouse Y") * m_MouseSensitivity;

                m_CurrentYaw += mouseX;
                m_CurrentPitch -= mouseY;

                // Pitchをクランプ
                m_CurrentPitch = Mathf.Clamp(m_CurrentPitch, m_MinPitch, m_MaxPitch);

                transform.rotation = Quaternion.Euler(m_CurrentPitch, m_CurrentYaw, 0f);
            }
        }

        private void HandleGamepadInput()
        {
            float gamepadX = Input.GetAxis("RightStickHorizontal");
            float gamepadY = Input.GetAxis("RightStickVertical");

            if (Mathf.Abs(gamepadX) > 0.1f || Mathf.Abs(gamepadY) > 0.1f)
            {
                m_CurrentYaw += gamepadX * m_MouseSensitivity;
                m_CurrentPitch -= gamepadY * m_MouseSensitivity;

                // Pitchをクランプ
                m_CurrentPitch = Mathf.Clamp(m_CurrentPitch, m_MinPitch, m_MaxPitch);

                transform.rotation = Quaternion.Euler(m_CurrentPitch, m_CurrentYaw, 0f);
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// カメラの回転をリセット
        /// </summary>
        public void ResetRotation()
        {
            m_CurrentYaw = 0f;
            m_CurrentPitch = 0f;
            transform.rotation = Quaternion.identity;
        }
        #endregion
    }
}
