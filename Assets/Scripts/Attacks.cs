using UnityEngine;

public class Attacks : MonoBehaviour
{
    public Score score;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {            
            Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.4f);

            for (int i = 0; i < collider.Length; i++)
            {
                if (collider[i].tag == "Trap")
                {
                    Destroy(collider[i].gameObject);
                    score.ScoreHit(Trap.pointForKill); 
                }
                if (collider[i].tag == "Enemy")
                {
                    Destroy(collider[i].gameObject);
                    score.ScoreHit(Enemy.pointForKill);
                }
                if (collider[i].name == "PlayerBlue" || collider[i].name == "PlayerRed")
                {
                    collider[i].GetComponent<PlayerMovement>().enabled = true;
                }
            }
        }
    }
}
