using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector2 initPos;

    void Start()
    {
        initPos = gameObject.transform.position;
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void ResetPosition()
    {
        gameObject.transform.position = initPos;
        Launch();
    }
}
