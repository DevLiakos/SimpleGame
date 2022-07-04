using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DestroyObject());
        transform.parent = null;
    }

    private void Update()
    {
        transform.position += new Vector3(0, 0, 10 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}
