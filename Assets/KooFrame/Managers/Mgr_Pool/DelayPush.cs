using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDelayPush : MonoBehaviour
{
    public void OnEnable()
    {
        Invoke("Push", 2f);
    }
    void Push()
    {
        PoolMgr.Instance.PushObj(this.gameObject.name, this.gameObject);
    }
}
