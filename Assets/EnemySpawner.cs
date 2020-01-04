using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public Transform spawner;
    public GameObject enemy;
    private IEnumerator timer;

    private void Start()
    {
        timer = spawn(15f);
        StartCoroutine(timer);
    }

    private IEnumerator spawn(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Instantiate(enemy, spawner.position, spawner.rotation);
            
        }
    }
}
