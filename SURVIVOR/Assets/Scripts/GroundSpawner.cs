using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
	public GameObject Ground1, Ground2, Ground3, Ground4;
	bool hasGround = true;

    void Start()
    {
        
    }

    void Update()
    {
        if(!hasGround)
        {
        	SpawnGround();
        	hasGround = true;
        }

        if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isGameOver)
        {
        	StopCoroutine("SpawnGround");
        }
    }

    public void SpawnGround()
    {
    	int randomNum = Random.Range(1, 4);

    	if(randomNum == 1)
    	{
    		Instantiate(Ground1, new Vector3(transform.position.x + 4, 0, 0), Quaternion.identity);
    	}

    	if(randomNum == 2)
    	{
    		Instantiate(Ground2, new Vector3(transform.position.x + 5, 0, 0), Quaternion.identity);
    	}

    	if(randomNum == 3)
    	{
    		Instantiate(Ground3, new Vector3(transform.position.x + 6, 0, 0), Quaternion.identity);
    	}

    	if (randomNum == 4)
    	{
    		Instantiate(Ground4, new Vector3(transform.position.x + 5, 0, 0), Quaternion.identity);
    	}

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    	if(collision.gameObject.CompareTag("Ground"))
    	{
    		hasGround = true;
    	}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
    	if(collision.gameObject.CompareTag("Ground"))
    	{
    		hasGround = false;
    	}
    }
}

/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
	public GameObject Ground1, Ground2, Ground3, Ground4, Ground5, Ground6;
	bool hasGround = true;

    void Start()
    {
        
    }

    void Update()
    {
        if(!hasGround)
        {
        	SpawnGround();
        }
    }

    public void SpawnGround()
    {
    	int randomNum = Random.Range(1, 7);

    	if(randomNum == 1)
    	{
    		Instantiate(Ground1, new Vector3(transform.position.x + 3, -4, 0), Quaternion.identity);
    	}

    	if(randomNum == 2)
    	{
    		Instantiate(Ground4, new Vector3(transform.position.x + 3, -1.5f, 0), Quaternion.identity);
    	}

    	if(randomNum == 3)
    	{
    		Instantiate(Ground2, new Vector3(transform.position.x + 3, -4, 0), Quaternion.identity);
    	}

    	if(randomNum == 4)
    	{
    		Instantiate(Ground3, new Vector3(transform.position.x + 3, -4, 0), Quaternion.identity);
    	}

    	if(randomNum == 5)
    	{
    		Instantiate(Ground5, new Vector3(transform.position.x + 3, -4, 0), Quaternion.identity);
    	}

    	if(randomNum == 6)
    	{
    		Instantiate(Ground6, new Vector3(transform.position.x + 3, -4, 0), Quaternion.identity);
    	}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    	if(collision.gameObject.CompareTag("Ground"))
    	{
    		hasGround = true;
    	}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
    	if(collision.gameObject.CompareTag("Ground"))
    	{
    		hasGround = false;
    	}
    }
}


*/