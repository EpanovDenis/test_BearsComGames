using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "PlayerBlue")
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1f);

            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].name == "PlayerRed")
                {
                    Debug.Log("ѕобеда, все дела, + 300 очков, следующий уровень.");
                }
            }
        }
    }
}
