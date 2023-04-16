using System;
using KooFrame.Managers;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KooFrame
{
    /// <summary>
    /// GameRoot是一个单例Mono类
    /// </summary>
    public class GameRoot : KooPortalManager
    {
        public GameObject KooCanvas;


        public bool IsLaunchStartPanel = false;

        public bool IsLaunchInventoryPanel = false;

// #if UNITY_EDITOR //此为宏定义标签 UNITY_EDITOR表示这段代码只在Editor模式下执行 发布后剔除
//         [MenuItem("CONTEXT/UIOpen/LaunchLoginPanel")]
//         public static void NewContext2(MenuCommand command)
//         {
//             UIOpen script = (command.context as UIOpen);
//             if (script.IsLaunchStartPanel == false)
//             {
//                 script.IsLaunchStartPanel = true;
//                 Debug.Log("LoginPanel Launch");
//             }
//             else
//             {
//                 script.IsLaunchStartPanel = false;
//                 Debug.Log("LoginPanel Close");
//             }
//         }
// #endif
        private new void Awake()
        {
            //让GameRoot过场不销毁
            DontDestroyOnLoad(this);
            //获取到GameRoot中的组件
            KooCanvas = GameObject.Find("KooCanvas");
        }

        private void Start()
        {
            if (IsLaunchStartPanel)
            {
                UIMgr.Instance.OpenPanel<LoginPanel>("LoginPanel", UIMgr.E_UI_Layer.Bottom, (panel) => { });
            }

            // CinemachineManager cinemachineManager = GameObject.Find("CameraManager").GetComponent<CinemachineManager>();
            //设置当前初始摄像机为看向人物的第三人称相机
            PerspectiveManager.Instance.OpenCMCameraBySetActive("3rdCameraCtrl"); 
            EventCenter.Instance.EventTrigger<bool>("Player第三人称控制",true);
        }

        private void Update()
        {
            if (Keyboard.current.jKey.isPressed)
            {
                Debug.Log("testJ");
            }
        }

        protected override void LaunchInDevelopingMode()
        {
            throw new System.NotImplementedException();
        }

        protected override void LaunchInTestingMode()
        {
            throw new System.NotImplementedException();
        }

        protected override void LaunchInProductionMode()
        {
            throw new System.NotImplementedException();
        }
    }
}