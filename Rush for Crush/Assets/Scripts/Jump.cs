using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    CharMove charMove; //CharMove scriptini charMove olarak bu scriptte çağırılmasını sağlar.
    void Start()
    {
        charMove = transform.root.gameObject.GetComponent<CharMove>();
    }//Oyun başladığında bu scriptin en üst objesine çıkar ve onu charMove'a atar.

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ground") charMove.isJumping = false;
    }//Karakter yere değiyorsa CharMove scriptindeki isJumping değişkenini false yapar.
}
