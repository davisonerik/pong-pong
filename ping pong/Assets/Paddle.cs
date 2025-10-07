using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Initi(boll isRightPadd) {

    Vector2 pos = Vector2.zero;

        if(isRightPadadd){
            pos = new Vector2(GameMamager.topRigght.x,0);
        }
        else{}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
