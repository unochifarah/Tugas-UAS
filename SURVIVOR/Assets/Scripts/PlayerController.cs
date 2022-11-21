using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public PlayerController player;
	Rigidbody2D rb2d;
	public int runSpeed;
	Animator anim;
	public bool isGameOver = false;
	public GameObject GameOverPanel;
	public Text scoreText;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
    	if(!isGameOver)
    	{
    		transform.position = Vector3.right * runSpeed * Time.deltaTime + transform.position;
    		scoreText.text = "Score " + Mathf.Floor(player.transform.position.x);
    	}

		if (Input.GetKeyDown ("r"))
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}

		if(Input.GetKeyDown(KeyCode.Space) && !isGameOver)
		{
			Jump();
		}

    }

    private void Jump()
    {
    		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200f);
    		anim.SetTrigger("jump");
    }

    public void GameOver()
    {
    	isGameOver = true;
    	anim.SetTrigger("death");

    	StartCoroutine("ShowGameOverPanel");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    	if (collision.gameObject.CompareTag("BottomDetector"))
    	{
    		GameOver();
    	}
    }

    IEnumerator ShowGameOverPanel()
    {
    	yield return new WaitForSeconds(0.5f);
    	GameOverPanel.SetActive(true);
    }
}