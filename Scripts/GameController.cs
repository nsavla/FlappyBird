using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static GameController instance;
	public GameObject gameOverText;
	public bool gameOver = false ;
	public float scrollSpeed = -1.5f;
	public Text scoreText;
	public float score = 0.0f;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != null) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void BirdScored()
	{
		if (gameOver) {
			return;
		} else {
			score++;
			scoreText.text = "Score : " + score.ToString();
		}
	}

	public void birdDied()
	{
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
