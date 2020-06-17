using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour
{

    /// <summary>
    /// Start is called before the first frame update
    /// Plays the current particle system this script is attached to
    /// </summary>
    void Start()
    {
        GetComponent<ParticleSystem>().Play();
    }
}
