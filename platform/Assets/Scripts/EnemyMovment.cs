using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovment : MonoBehaviour
{

    public GameManager gameManager;
    public float speed;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);


    }
    public void OnCollisionEnter(Collision node)
    {
        if (node.gameObject.tag == "Player")
        {
            ScoreScript.ScoreValue = 0;
            gameManager.GameOver();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);



        }
    }
}
