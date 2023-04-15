﻿using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using KooFrame;
using UnityEngine;

public class InventoryPanel : BasePanel
{
	protected override void Awake()
	{
		base.Awake();
	}
	public override void OpenMe()
	{
		base.OpenMe();
	}
	public override void ShowMe()
	{
		Debug.Log("Show");
		this.transform.DOLocalMove(Vector3.zero, 1f);
	}
	public override void HideMe()
	{
		Debug.Log("HideMe");
		//this.transform.DOLocalMove(new Vector3(0, -400, 0), 1f);
	}
}
