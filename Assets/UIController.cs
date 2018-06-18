using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>

/// </summary>
public class UIController : MonoBehaviour
{
	#region Fields
	#endregion

	#region Properties
	/// <summary>
	/// ゲームオーバーテキスト コンポーネント
	/// </summary>
	public GameObject GameOverText { get; private set; }

	/// <summary>
	/// 走行距離テキスト コンポーネント
	/// </summary>
	public GameObject RunLengthText { get; private set; }

	/// <summary>
	/// 走行距離
	/// </summary>
	public float Length { get; private set; } = 0.0f;

	/// <summary>
	/// 走行速度
	/// </summary>
	public float Speed { get; private set; } = 0.03f;

	/// <summary>
	/// ゲームオーバー判定
	/// </summary>
	public bool IsGameOver { get; private set; } = false;
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
	void Start()
	{
		this.GameOverText = GameObject.Find("GameOver");
		this.RunLengthText = GameObject.Find("RunLength");
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		if (this.IsGameOver)
		{
			this.SceneChange();
		}
		else
		{
			this.Length += this.Speed; // 走行距離更新
			this.RunLengthText.GetComponent<Text>().text = "Distance: " + Length.ToString("F2") + "m"; // 走行距離表示
		}
	}

	/// <summary>
	/// GameOver処理
	/// </summary>
	public void GameOver()
	{
		this.GameOverText.GetComponent<Text>().text = "GameOver";
		this.IsGameOver = true;
	}

	/// <summary>
	/// シーンチェンジ処理
	/// </summary>
	private void SceneChange()
	{
		if (Input.GetMouseButtonDown(0))
		{
			SceneManager.LoadScene("GameScene");
		}
	}
	#endregion
}
