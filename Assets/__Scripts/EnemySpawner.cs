using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject player;

    [SerializeField]
    private GameObject sceleton;
    [SerializeField]
    private string enemyTag;
    [SerializeField]
    private int minEnemyCount;
    [SerializeField]
    private float interval = 1f;
    [SerializeField]
    private float minXPosition;
    [SerializeField]
    private float maxXPosition;
    [SerializeField]
    private float maxEnemyCount;



    void Start()
    {
        StartCoroutine(spawnEnemy());

    }



    private IEnumerator spawnEnemy()
    {

        yield return new WaitForSeconds(interval);
        if (maxEnemyCount > 0)
        {
            if (GameObject.FindGameObjectsWithTag(enemyTag).Length <= minEnemyCount)
            {
                float positionX = Random.Range(minXPosition, maxXPosition);
                if (player.transform.position.x == positionX)
                {
                    positionX += 2f;
                }
                GameObject newEnemy = Instantiate(sceleton, new Vector3(positionX, -5.31f, 0), Quaternion.identity);
                newEnemy.GetComponent<EnemyMovement>().target = player.transform;
            }
            StartCoroutine(spawnEnemy());
            maxEnemyCount--;
        }
    }
}
