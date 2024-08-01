
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rg;
    [SerializeField] private float random;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Awake(){
        rg = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        rg.velocity = new Vector3(0, -1, 0) * speed;
    }

    private void updateDirection(GameObject player){
        Vector2 ballPos = transform.position;
        Vector2 playerPos = player.transform.position;

        float xDirection, yDirection;

        // dao chieu cua qua bong khi va cham 
        if(ballPos.y < 0) yDirection = 1;
        else yDirection = -1;

        // tính khoảng cách từ tâm bóng đến tâm player, sau đó chia cho chiều dài player để đc gtri trong (-1, 1)
        xDirection = (ballPos.x - playerPos.x) / player.GetComponent<Collider2D>().bounds.size.x;

        if(xDirection == 0){
            xDirection = Random.Range(-0.25f, 0.25f);
        }

        rg.velocity = new Vector2(xDirection, yDirection) * speed;
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            updateDirection(other.gameObject);
        }        
    }

    public void reserBall(){
        transform.position = new Vector3(0,0,0);
        rg.velocity = new Vector3(0, -1, 0) * speed;
    }
}
