using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>

/// </summary>
public class BackgroundController : MonoBehaviour
{
	#region Fields
	#endregion

	#region Properties
	/// <summary>
	/// スクロール速度
	/// </summary>
	public float ScrollSpeed = -0.03f;
	
	/// <summary>
	/// 背景終了位置
	/// </summary>
	public float DeadLine = -16f;

	/// <summary>
	/// 背景開始位置
	/// </summary>
	public float StartLine = 15.8f;
	#endregion

	#region Methods
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Awake()
	{
		
	}

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start ()
	{
		
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update ()
	{
		transform.Translate(this.ScrollSpeed, 0, 0);

		// 画面外に出たら、画面右端に移動する
		if(transform.position.x < this.DeadLine)
		{
			transform.position = new Vector2(this.StartLine, 0);
		}
	}
	#endregion
}
