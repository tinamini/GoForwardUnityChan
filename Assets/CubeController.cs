using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>

/// </summary>
public class CubeController : MonoBehaviour
{
	#region Fields
	#endregion

	#region Properties
	/// <summary>
	/// キューブ移動速度
	/// </summary>
	public float Speed { get; private set; } = -0.2f;

	/// <summary>
	/// 消滅位置
	/// </summary>
	public float DeadLine { get; } = -10;
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
		// キューブ移動
		transform.Translate(this.Speed, 0, 0);

		if(transform.position.x < this.DeadLine)
		{
			Destroy(gameObject);
		}
	}
	#endregion
}
