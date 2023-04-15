#if ENABLE_INPUT_SYSTEM


using Cinemachine;
using System.Collections.Generic;
using KooFrame;
using UnityEngine;
using UnityEngine.InputSystem;

public class CinemachineManager : MonoBehaviour
{

	public GameObject MainCamera;
	public CinemachineBrain CMBrain;
	
	public static Dictionary<string, GameObject> CMcameras = new Dictionary<string, GameObject>();


	private void Awake()
	{
		MainCamera = Camera.main.gameObject;
		CMBrain = MainCamera.GetComponent<CinemachineBrain>();
		foreach (Transform child in this.transform)
		{
			CMcameras.Add(child.gameObject.name, child.gameObject);
		}
	}
	private void Start()
	{
		Debug.Log(CMcameras.Keys.Count);
	}

	private void Update()
	{
		Change3rdTo1st();
		OrderChangeCamera();

	}


	private void SetLiveCMCamera(CinemachineVirtualCamera cm)
	{
		
	}


	private void Change3rdTo1st()
	{
		//从第三人称转到第一人称
		if (CMcameras["3rdCameraCtrl"].GetComponent<CinemachineVirtualCamera>()
								  .GetCinemachineComponent<Cinemachine3rdPersonFollow>()
								  .CameraDistance <= 1
		&& CMcameras["1stCameraCtrl"].GetComponent<CameraCtrl_1st>().Input.currentActionMap.name == "Camera3rdCtrl")
		{
			Changeto1stCtrl();
		}
	}

	public static void OpenCMCamera(string CameraName)
	{
		CMcameras[CameraName].SetActive(false);
		CMcameras[CameraName].SetActive(true);
	}

	public void Changeto1stCtrl()
	{
		OpenCMCamera("1stCameraCtrl");
		CMcameras["1stCameraCtrl"].GetComponent<CinemachineVirtualCamera>().Follow = GameObject.Find("PlayerCameraRoot").transform;
		//UIMgr.Instance.OpenPanel<ControllerPanel_1st>("ControllerPanel_1st", UIMgr.E_UI_Layer.Middle);
	}

	private void OrderChangeCamera()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			OpenCMCamera("1stCameraCtrl");
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			OpenCMCamera("HoldCameraCtrl");
			CameraInput.SetCursorState(false);
			Cursor.visible = true;
			UIMgr.Instance.ClosePanel("ControllerPanel_1st");
			UIMgr.Instance.ClosePanel("ControllerPanel_Free");
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			OpenCMCamera("3rdCameraCtrl");
		}
	}

	private void SwitchCamera()
	{
		
	}

}
#endif