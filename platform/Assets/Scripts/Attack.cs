using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    float speed = 5f;
    public bool timerRunning = true;
    int i;
    float tenSec = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    
    void Update()
    {
        if (timerRunning)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
            tenSec -= Time.smoothDeltaTime;
            if (tenSec >= 0)
            {
                Debug.Log(i++);
            }
            else
            {
                Debug.Log("Done");
                timerRunning = false;
                tenSec = 5;
            }
        }

        if (!timerRunning)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
           

            tenSec -= Time.smoothDeltaTime;
            if (tenSec >= 0)
            {
                Debug.Log(i++);
            }
            else
            {
                Debug.Log("Done");
                timerRunning = true;
                tenSec = 5;
            }
        }
        if (GameObject.FindGameObjectsWithTag("enemy").Length == 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }






    }
    public void OnCollisionEnter(Collision node)
    {
        if (node.gameObject.tag == "enemy")
        {
            ScoreScript.ScoreValue += 10;
            Destroy(node.gameObject);
            



        }
    }
}
