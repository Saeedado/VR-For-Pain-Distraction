using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSecondsVFX : MonoBehaviour
{

    private float lifeTime =2f;


    /// <summary>
    /// Start is called before the first frame update
    /// Destroys GameObject lifetime seconds after it has been instantiated.
    /// </summary>
    void Start()
    {
        Destroy(gameObject, lifeTime);
        
    }
}
