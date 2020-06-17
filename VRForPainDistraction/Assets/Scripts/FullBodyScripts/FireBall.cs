using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    Vector3 startingPosition;
    Quaternion startingRotation;
    [SerializeField]
    int damage;
    public GameObject fireBall;
    public GameObject explosionVFX;


    /// <summary>
    /// Start is called before the first frame update
    /// Storing the starting position and rotation of a fireball
    /// </summary>
    private void Start()
    {
        startingPosition = gameObject.transform.position;
        startingRotation = gameObject.transform.rotation;
    }



    /// <summary>
    /// If this FireBall collides with objects tag Wall or Target
    /// Create a VFX explosion
    /// Spawn a new Fire Ball at the original location
    /// And destroy the current fire ball
    /// </summary>
    /// <param name="collision"> the gameobject that was hit against the gameobject this script is applied to </param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Target")
        {
            Explode();
            SpawnFireBall();
            //Destroys the current gameObject
            Destroy(gameObject);
            // if hit has a tag "Target" then get it's Health
            if (collision.gameObject.tag == "Target")
            {
                TargetHealth targetHealth = collision.gameObject.GetComponent<TargetHealth>();

                // If the "hit" gameobject has a component "TargetHealth" then that gameobject takes damage
                if (targetHealth != null)
                {
                    targetHealth.TakeDamage(damage);
                }
            }
        }
    }



   
    /// <summary>
    /// Spawns a FireBall at the starting location
    /// </summary>
    public void SpawnFireBall()
    {
        Instantiate(gameObject, startingPosition, startingRotation);
    }



    /// <summary>
    /// Instantiates a VFX explosion
    /// </summary>
    public void Explode()
    {
        Instantiate(explosionVFX, gameObject.transform.position, gameObject.transform.rotation);
    }
}
