using UnityEngine;

public class sponer : MonoBehaviour
{
    public GameObject prifap;
    public float interval=2f;
    public int maksSpoons=10;
    public Vector3 range=new Vector3(5,0,5);
    int count=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() =>InvokeRepeating(nameof(spoon),1f,interval);
    
  void spoon(){

    if(count++>=maksSpoons){
        CancelInvoke();
        return;
    } 
    Vector3 pos=transform.position+new Vector3(
        Random.Range(-range.x,range.x),
        Random.Range(-range.y,range.y),
        Random.Range(-range.z,range.z)
        );
    Instantiate(prifap,pos,Quaternion.identity);
      }
    // Update is called once per frame
    void Update()
    { 
        
    }
}
