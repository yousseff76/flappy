using UnityEngine;

public class move : MonoBehaviour
{ float speed =3f;
    public bool start=true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    { 
        if(!start&&Input.GetMouseButtonDown(0)){
            start=true;
        }
        if(start){
            movee();
        }

        
        
    }
    void movee(){
        if(start==false){
            start=true;
        }
        transform.Translate(Vector2.left*speed*Time.deltaTime);
        
    }
}
