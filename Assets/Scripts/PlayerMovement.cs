using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeedPlayer;
    [SerializeField] private bool _inverted;

    private Rigidbody2D PlayerRB;
    private Vector2 moveInputX;
    private Vector2 moveInputY;

    private void Awake()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveInputX.x = Input.GetAxisRaw("Horizontal");        
        moveInputY.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {                     
        if (moveInputY.y == 0)
        {
            if (_inverted)
            {
                PlayerRB.MovePosition(PlayerRB.position - moveInputX * _movementSpeedPlayer * Time.fixedDeltaTime);
            }
            else
            {
                PlayerRB.MovePosition(PlayerRB.position + moveInputX * _movementSpeedPlayer * Time.fixedDeltaTime);
            }
        }
        if (moveInputX.x == 0)
        {
            PlayerRB.velocity = moveInputY * _movementSpeedPlayer;
        }        
    }
}
