using KooFrame.BaseSystem;
using UnityEngine;
using UnityEditor;

namespace KooFrame
{
    [CustomEditor(typeof(UnityEditor.DefaultAsset))]
    public class ExDefaultAsset : Editor
    {
        public override void OnInspectorGUI()
        {
            string path = AssetDatabase.GetAssetPath(target);
            GUI.enabled = true;
            if (path.EndsWith(string.Empty))
            {
                if (path.Equals("Assets/KooFrame"))
                {
                    GUILayout.Label("这里是Koo工具集框架文件夹\n这里面包含了很多开发过程中可以用到的简单工具集\n 背包系统还没整好 有点问题 背包系统在SubSystem文件夹下");
                    GUILayout.Label($"框架版本:{KooFrameInstance.FrameInfo.Version}");

                }
                if (path.Equals("Assets/KooFrame") && GUILayout.Button("输出框架名称"))
                {
                    Debug.Log(KooFrameInstance.GetFrameworkFileName(isAddVersion: true));
                }

                if (path.Equals("Assets/KooFrame") && GUILayout.Button("打包出框架UnityPackage"))
                {
                    KooUtils.CallMenuItem("生成框架UnityPackage");
                }
            }
        }
    }
}