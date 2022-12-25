using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  //Değişken Tanımlama Başlangıç.
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait, spawnMostWait, spawnLessWait;
    public int startWait;
    public bool stop;
    private int randEnemy;
  //Değişken Tanımlama Bitiş.

    void Start()
    {
        this.StartCoroutine(this.SpawnerE());
    }

    void FixedUpdate()
    {
        if (spawnLessWait > 0.5f) spawnLessWait -= 0.00002f;
        else if (spawnMostWait > 1.0f) spawnMostWait -= 0.0001f;
        this.spawnWait = Random.Range(this.spawnLessWait, this.spawnMostWait);
    }/*Spawnera verilen nesneleri spawnlamak için süreleri ayarlar
    ve zaman geçtikçe hızı arttırır.*/

    private IEnumerator SpawnerE()
  {
    Spawner spawner = this;
    yield return (object) new WaitForSeconds((float) spawner.startWait);
    while (!spawner.stop)
    {
      spawner.randEnemy = Random.Range(0, spawner.enemies.Length);
      Vector3 vector3 = new Vector3(Random.Range(-spawner.spawnValues.x, spawner.spawnValues.x), Random.Range(-spawner.spawnValues.y, spawner.spawnValues.y), Random.Range(-spawner.spawnValues.z, spawner.spawnValues.z));
      Object.Instantiate<GameObject>(spawner.enemies[spawner.randEnemy], vector3 + spawner.transform.TransformPoint(0.0f, 0.0f, 0.0f), spawner.gameObject.transform.rotation);
      yield return (object) new WaitForSeconds(spawner.spawnWait);
    }
  }//Oyun motorundan elle girilen değerlere göre rastgele nesne üretir.
}
