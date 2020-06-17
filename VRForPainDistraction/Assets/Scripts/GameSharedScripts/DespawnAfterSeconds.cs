
using UnityEngine;

public class DespawnAfterSeconds : MonoBehaviour
{
    [SerializeField]
    float lifeTime = 7f;
    float killTime;
    float timeSpawned;
    GameObject gameManager;

    
    /// <summary>
    /// Start is called before the first frame update
    /// Collects information on what time the gameobject was spawned
    /// and calculates when it should despawn
    /// </summary>
    void Start()
    {
        
        timeSpawned = Time.time;
        killTime = timeSpawned + lifeTime;
    }

    // 
    /// <summary>
    /// Update is called once per frame
    /// When the kill time is reached kill the target
    /// and reduce the player's score
    /// </summary>
    void Update()
    {
        if(Time.time >= killTime)
        {
            KillTarget();
            ReduceScore();
        }
    }

    //Destroys a Target
    /// <summary>
    /// Destroys the gameobject this script is attached to
    /// </summary>
    void KillTarget()
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// Decrease the player's score
    /// </summary>
    void ReduceScore()
    {
        gameManager = GameObject.Find("GameManager");
        gameManager.GetComponent<ScoreSystem>().DecrementScore();
    }



}
