using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CharMove : MonoBehaviour
{
    //Değişken Tanımlama Başlangıç.
    public int score = 0;
    public float moveSpeed = 5f;
    public TextMeshProUGUI scoreText;
    private int health = 3;
    public GameObject health1, health2, health3, playAgain, pause, resume, pauseBackground;
    private Rigidbody2D jump;
    public bool isJumping = false;
    //Değişken Tanımlama Bitiş.
    void Start()
    {
        jump = GetComponent<Rigidbody2D>();
    }//Oyun başladığında jump değişkenine Rigidbody2D'nin Componentlerini ekler.

    void Update()
    {
        if (isJumping == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                isJumping = true;
                jump.AddForce(Vector2.up*225f);
            }
        }
    }//Oyuncu W, Space veya Yukarı yön tuşuna basınca karakterin zıplamasını sağlar.
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }//Oyuncunun karakteri X ekseninde hareket ettirmesini sağlar.

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "solEngel")
        {
            transform.position = new Vector3(7.957699f,transform.position.y,0f);
        }//Karakter "solEngel" etiketine sahip bir nesneye dokunursa belirtilen kordinatlara ışınlanır.

        else if(other.gameObject.tag == "sagEngel")
        {
            transform.position = new Vector3(-7.950358f,transform.position.y,0f);
        }//Karakter "sagEngel" etiketine sahip bir nesneye dokunursa belirtilen kordinatlara ışınlanır.

        else if(other.gameObject.tag == "eCoin")
        {
            score+=5;
            scoreText.SetText("Score: " + score);
            {
                Destroy(other.gameObject);
            }
        }

        else if(other.gameObject.tag == "youtHub")
        {
            score+=3;
            scoreText.SetText("Score: " + score);
            {
                Destroy(other.gameObject);
            }
        }

        else if(other.gameObject.tag == "like")
        {
            score+=1;
            scoreText.SetText("Score: " + score);
            {
                Destroy(other.gameObject);
            }
        }

        else if(other.gameObject.tag == "disLike")
        {
            score-=1;
            scoreText.SetText("Score: " + score);
            {
                Destroy(other.gameObject);
            }
        }

        else if(other.gameObject.tag == "bomb")
        {
            Destroy(other.gameObject);
            health--;
            if (health == 2)
            {
                health3.SetActive(false);
            }
            else if (health == 1)
            {
                health2.SetActive(false);
            }
            else if (health == 0)
            {
                health1.SetActive(false);
                pauseBackground.SetActive(true);
                resume.SetActive(false);
                pause.SetActive(false);
                playAgain.SetActive(true);
                Time.timeScale = 0f;
            }
        }

        else if(other.gameObject.tag == "suspend")
        {
            pauseBackground.SetActive(true);
            resume.SetActive(false);
            pause.SetActive(false);
            playAgain.SetActive(true);
            Time.timeScale = 0f;
        }

        else if(other.gameObject.tag == "bigDislike")
        {
            score-=10;
            scoreText.SetText("Score: " + score);
            {
                Destroy(other.gameObject);
            }
        }

        if (score < 0)
        {
            pauseBackground.SetActive(true);
            resume.SetActive(false);
            pause.SetActive(false);
            playAgain.SetActive(true);
            Time.timeScale = 0f;
        }//Puan sıfırın altına düşerse oyunu bitirir.
    }//Özel açıklama yapılmayanlar, karaktere dokunan nesnenin tagına göre durumları tetikler.
}
