using UnityEngine;

public class TargetHealth : MonoBehaviour
{
    [SerializeField]
    int targetHealth;

    /// <summary>
    /// Makes the target take a certain amount of damage
    /// </summary>
    /// <param name="damage"> int, The target takes this amaount of damage</param>
    public void TakeDamage(int damage)
    {
        targetHealth -= damage;
        if(targetHealth <= 0)
        {
            DestroyTarget();
        }
    }

    /// <summary>
    /// The target is destroyed and the score is increased
    /// </summary>
    void DestroyTarget()
    {
        Destroy(gameObject);
        GameObject.Find("GameManager").GetComponent<ScoreSystem>().IncrementScore();
    }

}
