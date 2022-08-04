using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private GameObject _player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _player.transform.position = transform.position;
        _player.GetComponent<PlayerMovement>().enabled = false;
    }
}
