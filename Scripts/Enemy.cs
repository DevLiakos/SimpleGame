using UnityEngine;

public class Enemy : MonoBehaviour
{
    private CanvasManager Canvas;

    private void Start()
    {
        transform.parent = null;

        Canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<CanvasManager>();
    }

    private void Update()
    {
        transform.position += new Vector3(0, 0, -15 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EnemyFinish")
        {
            Destroy(gameObject);
            Canvas.LosePlusOne();
        }

        if(other.tag == "Bullet")
        {
            Destroy(gameObject);
            Canvas.ScorePlusOne();
        }
    }
}
