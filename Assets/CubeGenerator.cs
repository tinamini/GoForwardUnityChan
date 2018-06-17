using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>

/// </summary>
public class CubeGenerator : MonoBehaviour
{
	#region Fields
	public GameObject CubePrefab;
	#endregion

	#region Properties
	public float Delta { get; private set; } = 0;

	public float Span { get; private set; } = 1.0f;

	public float GeneratePosisionX { get; private set; } = 12.0f;

	public float OffsetY { get; private set; } = 0.3f;

	public float SpaceY { get; private set; } = 6.9f;

	public float OffsetX { get; private set; } = 0.5f;

	public float SpaceX { get; private set; } = 0.4f;

	public int MaxBlockNum { get; private set; } = 4;
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
		this.Delta += Time.deltaTime;
		if (this.Delta > this.Span)
		{
			this.Delta = 0;
			int num = Random.Range(1, MaxBlockNum + 1);

			// 指定した数だけキューブを生成
			for(int i = 0; i < num; i++)
			{
				var gameObject = Instantiate(CubePrefab) as GameObject;
				gameObject.transform.position = new Vector2(this.GeneratePosisionX, i * this.SpaceY + this.OffsetY);
			}
			// 次のキューブまでの生成時間を決める
			this.Span = this.OffsetX + this.SpaceX * num;
		}
	}
	#endregion
}
