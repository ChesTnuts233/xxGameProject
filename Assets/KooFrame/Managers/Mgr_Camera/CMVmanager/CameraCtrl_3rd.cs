#if ENABLE_INPUT_SYSTEM


using Cinemachine;
using UnityEngine;
using MyUtils;
using UnityEngine.InputSystem;

public class CameraCtrl_3rd : MonoBehaviour
{
	//Cinemachine
	private float _cinemachineTargetYaw;
	private float _cinemachineTargetPitch;
	private const float _threshold = 0.01f;     //相机控制阈值

	public float cameraDistance = 6;
	private CinemachineVirtualCamera virtualCamera3rd;
	private Cinemachine3rdPersonFollow cmv3rd;

	[Tooltip("Range limit of distance.")]
	public Range distanceRange = new Range(1, 10);
	[Tooltip("Settings of mouse button, pointer and scrollwheel.")]
	public MouseSettings mouseSettings = new MouseSettings(1, 10, 10);



	#region 摄像机控制相关
	[Header("CameraController About")]
	[Tooltip("The follow target set in the Cinemachine Virtual Camera that the camera will follow\n虚拟相机的跟踪点")]
	public GameObject CinemachineCameraTarget;

	[Tooltip("How fast the character turns to face movement direction\n角色转向方向所需时间 ")]
	[Range(0.0f, 0.3f)]
	public float RotationSmoothTime = 0.12f;

	[Tooltip("How far in degrees can you move the camera up\n最大限制高度")]
	public float TopClamp = 70.0f;

	[Tooltip("How far in degrees can you move the camera down\n最小限制高度")]
	public float BottomClamp = -30.0f;

	[Tooltip("Additional degress to override the camera. Useful for fine tuning camera position when locked\n相机绕注视点旋转角度")]
	public float CameraAngleOverride = 0.0f;

	[Tooltip("Sensitivity of mouse pointer\n鼠标灵敏度")]
	[Range(0.0f, 2.0f)]
	public float PointerSensitivity = 1.0f;

	[Tooltip("For locking the camera position on all axis\n锁定相机")]
	public bool LockCameraPosition = false;
	#endregion

	/// <summary>
	/// Damper for for scrollwheel
	/// </summary>
	[Tooltip("Damper for scrollwheel.")]
	[Range(0, 10)]
	public float damper = 5;

	public static bool is3rdCtrl = true;


	public PlayerInput Input;
	public CameraInput CameraInput;
	public Transform CameraPlayer;
	CameraCtrl CameraCtrl;
	public CinemachineManager CMmanager;

	private bool IsCurrentDeviceMouse
	{
		get
		{
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
			return Input.currentControlScheme == "Camera_KeyboardAndMouse";
#else
				return false;
#endif
		}
	}

	private void Awake()
	{
		//Cinemachine3rd
		virtualCamera3rd = this.GetComponent<CinemachineVirtualCamera>();
		cmv3rd = virtualCamera3rd.GetCinemachineComponent<Cinemachine3rdPersonFollow>();
		cmv3rd.ShoulderOffset = new Vector3(1.0f, 0.18f, 0);
		cmv3rd.Damping = new Vector3(0.1f, 0.25f, 0.3f);

	}

	private void OnEnable()
	{
		CameraInput.SetCursorState(true);
		Input.SwitchCurrentActionMap("Camera3rdCtrl");
		CinemachineCameraTarget = GameObject.Find("PlayerCameraRoot");
		Debug.Log(Input.currentActionMap.name);
	}


	private void LateUpdate()
	{
		ScrollController();
		CameraRotationController();
	}
	#region 摄像机鼠标控制
	/// <summary>
	/// 鼠标滚轮控制
	/// </summary>
	private void ScrollController()
	{
		//Mouse scrollwheel.
		cameraDistance -= CameraInput.ScrollScale.y * mouseSettings.wheelSensitivity;
		cameraDistance = Mathf.Clamp(cameraDistance, distanceRange.min, distanceRange.max);
		cmv3rd.CameraDistance = Mathf.Lerp(cmv3rd.CameraDistance, cameraDistance, damper * Time.deltaTime);

	}
	/// <summary>
	/// 摄像机控制
	/// </summary>
	private void CameraRotationController()
	{
		// if there is an input and camera position is not fixed //当看向方向的根号模长大于阈值的时候
		if (CameraInput.Look3rd.sqrMagnitude >= _threshold && !LockCameraPosition)
		{
			//Don't multiply mouse input by Time.deltaTime;
			float deltaTimeMultiplier = IsCurrentDeviceMouse ? PointerSensitivity : Time.deltaTime;

			_cinemachineTargetYaw += CameraInput.Look3rd.x * 1/*deltaTimeMultiplier*/;
			_cinemachineTargetPitch += CameraInput.Look3rd.y * 1/*deltaTimeMultiplier*/;
		}

		// clamp our rotations so our values are limited 360 degrees
		_cinemachineTargetYaw = ClampAngle(_cinemachineTargetYaw, float.MinValue, float.MaxValue);
		_cinemachineTargetPitch = ClampAngle(_cinemachineTargetPitch, BottomClamp, TopClamp);

		// Cinemachine will follow this target
		CinemachineCameraTarget.transform.rotation = Quaternion.Euler(_cinemachineTargetPitch + CameraAngleOverride,
			_cinemachineTargetYaw, 0.0f);
	}

	private static float ClampAngle(float lfAngle, float lfMin, float lfMax)
	{
		if (lfAngle < -360f) lfAngle += 360f;
		if (lfAngle > 360f) lfAngle -= 360f;
		return Mathf.Clamp(lfAngle, lfMin, lfMax);
	}
	#endregion
}
#endif