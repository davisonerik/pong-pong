using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle paddle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(ball);
        Instantiate(paddle);

        Paddle paddle1 = Instatiate(paddle) as Paddle;
        Paddle paddle = Instatiate(paddle) as Paddle;
        paddle1.Init(true);
        paddle2.Init(true);
    }

   
}
