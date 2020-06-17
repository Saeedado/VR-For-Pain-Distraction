using UnityEngine;

public class Gun : MonoBehaviour
{
    int damage = 1;
    float range = 400;
    public Camera fpsCam;
    public OVRInput.Button shootButton;


    /// <summary>
    /// Updates every frame
    /// If shoot button is pressed on a controller
    /// Shoot with raycast
    /// </summary>
    void Update()
    {
        if (OVRInput.GetDown(shootButton))
        {
            Shoot();
        }
    }


    /// <summary>
    /// Shoots out a raycast to damage targets
    /// </summary>
    void Shoot()
    {
        RaycastHit hit;
     
        // If the raycast hits a gameobject, that gameobject information is stored in "hit"
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            // if hit has a tag "Target" then get it's Health
            if (hit.transform.tag == "Target")
            {
                TargetHealth targetHealth = hit.transform.GetComponent<TargetHealth>();

                // If the "hit" gameobject has a component "TargetHealth" then that gameobject takes damage
                if(targetHealth != null)
                {
                    targetHealth.TakeDamage(damage);
                }
            }
        }
    }
}
