using UnityEngine;

public class fly : MonoBehaviour
{ public float amp =0.5f;
   public float speed =2f;
   bool isPlaying=false;
   float FlyForce=5f;
   Rigidbody2D rb;
    Vector3 start;
    bool isDead;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { start=transform.position;
     rb=GetComponent<Rigidbody2D>();
      rb.isKinematic=true;  
      animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying){
            float newY=start.y+Mathf.Sin(Time.time*speed)*amp;
            transform.position=new Vector3(start.x,newY,start.z);

            if(Input.GetMouseButtonDown(0) &&!isDead|| Input.touchCount>0)
            {
                isPlaying=true; 
                rb.isKinematic=false;
                animator.SetBool("isFlying",true);
                Fly();
            }
            else{

                animator.SetBool("isFlying",false);
            }
        }
            else{
                if(Input.GetMouseButtonDown(0)&&!isDead || Input.touchCount>0)
                {
                    Fly();
                    animator.SetBool("isFlying",true);
                }
            }

}
 
    void Fly(){
        rb.linearVelocity=new Vector2(rb.linearVelocity.x,0f);
        rb.AddForce(Vector2.up*FlyForce,ForceMode2D.Impulse);
    }void OnCollisionEnter2D(Collision2D col){
        isDead=true;
    }

}