using UnityEngine;

public class Trap : MonoBehaviour
{
    public static int pointForKill = 100;

    private bool inTrap = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (inTrap == false)
        {
            collision.transform.position = transform.position;
            collision.GetComponent<PlayerMovement>().enabled = false;
            inTrap = true;
        }        
    }
}
