using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectFireBall : MonoBehaviour
{
    GameObject gameManager;

    /// <summary>
    /// Start is called before the first frame update
    /// Finds the "GameManager" object in the current scene
    /// </summary>
    private void Start()
    {
        gameManager = GameObject.Find("GameManager");

    }


    /// <summary>
    /// If game object collides with a Gameobject with a tag "FireBall"
    /// Destroy this gameobject and increase score
    /// </summary>
    /// <param name="collision"> the gameobject that was hit against the gameobject this script is applied to</param>
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "FireBall")
        {
            gameManager.GetComponent<ScoreSystem>().IncrementScore();
            Destroy(gameObject);
        }
    }


}
