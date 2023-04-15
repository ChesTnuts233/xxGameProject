using System;
using UnityEngine;

namespace KooFrame.BaseSystem.Singleton
{
    /// <summary>
    /// Koo提供的Mono单例类
    /// 前缀Koo，这是框架提供的单例类
    /// </summary>
    /// <typeparam name="T">单例泛型</typeparam>
    public class KooSingletonMono<T> : MonoBehaviour where T : KooSingletonMono<T>
    {
        public static T Instance;

        public void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;    
            }
        }
    }
}