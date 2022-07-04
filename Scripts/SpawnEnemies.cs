using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject Enemy;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(0.3f);
        transform.position = new Vector3(Random.Range(-2f, 2f), transform.position.y, transform.position.z);
        Instantiate(Enemy, transform);
        StartCoroutine(SpawnEnemy());
    }
}
