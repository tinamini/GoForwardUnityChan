using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>

/// </summary>
public class UnityChanController : MonoBehaviour
{
	#region Fields
	#endregion

	#region Properties
	/// <summary>
	/// 地面位置
	/// </summary>
	public float GroundLevel { get; } = -3.0f;

	/// <summary>
	/// アニメータコンポーネント
	/// </summary>
	public Animator Animator { get; private set; }

	/// <summary>
	/// Rigidbodyコンポーネント
	/// </summary>
	public Rigidbody2D Rigidbody2D { get; private set; }

	/// <summary>
	/// ジャンプ落下速度
	/// </summary>
	public float DumpSpeed { get; private set; } = 0.8f;

	/// <summary>
	/// ジャンプ速度
	/// </summary>
	public float JumpVelocity { get; private set; } = 60f;
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
		this.Animator = GetComponent<Animator>();
		this.Rigidbody2D = GetComponent<Rigidbody2D>();
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update ()
	{
		this.Animator.SetFloat("Horizontal", 1);

		bool isGround = (transform.position.y > this.GroundLevel) ? false : true;
		this.Animator.SetBool("isGround", isGround);

		if (Input.GetMouseButtonDown(0) && isGround)
		{
			this.Rigidbody2D.velocity = new Vector2(0, this.JumpVelocity);
		}

		if (Input.GetMouseButtonDown(0) == false)
		{
			if(this.Rigidbody2D.velocity.y > 0)
			{
				this.Rigidbody2D.velocity *= this.DumpSpeed;
			}
		}
	}
	#endregion
}
