using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Canovar = "Oyundaki bizi öldüren canavarımız";
public class CanovarMove : MonoBehaviour
{
    //Değişken Tanımlama Başlangıç.
    public GameObject resume, pause, playAgain, pauseBackground;
    public float moveSpeed = 5f;
    public bool checkLocation = false;
    //Değişken Tanımlama Bitiş.

    void FixedUpdate()
    {
        if (checkLocation == false)
        {
            Vector3 movement = new Vector3(-1.5f,0f,0f);
            transform.position += movement * Time.deltaTime * moveSpeed;
            if (transform.position.x <= -8.25f)
            {
                checkLocation = true;
            }
        }


        if (checkLocation == true)
        {
            Vector3 movement = new Vector3(+1.5f,0f,0f);
            transform.position += movement * Time.deltaTime * moveSpeed;
            if (transform.position.x >= 8.25f)
            {
                checkLocation = false;
            }
        }
    }/*Her kare değişiminde Canovar'ın yerini tespit eder
    ve yerini X ekseninde verilen değer kadar değiştirir değiştirir.*/

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "eforMan")
        {
            pauseBackground.SetActive(true);
            resume.SetActive(false);
            pause.SetActive(false);
            playAgain.SetActive(true);
            Time.timeScale = 0f;
        }
    }//Canovar'ın "eforMan" etiketli nesneye değdiğinde tetiklenecek aktivite.
}
