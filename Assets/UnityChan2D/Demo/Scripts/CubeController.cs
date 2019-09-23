using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{
	// キューブのPrefab
	public GameObject cubePrefab;

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// 地面の位置
	private float groundLevel = -3.0f;

	AudioSource audioSource;

	public AudioClip block;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		// キューブを移動させる
		transform.Translate(this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine)
		{
			Destroy(gameObject);
		}

		

	}

	//キューブが地面に接触またはキューブ同士が接触したら音を鳴らす
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Cube")
		{
			GetComponent<AudioSource>().Play();

			//Debug.Log("接触");
		}
	}
}

