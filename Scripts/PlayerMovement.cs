using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 LookPos;
    public GameObject Bullet;

    private void Update()
    {
        #region Movement
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            LookPos = hit.point;
        }

        if (LookPos.x < 2.2f && LookPos.x > -2.2f)
        {
            Vector3 SmoothedPosition = Vector3.Lerp(transform.position, LookPos, 20 * Time.deltaTime);
            transform.position = new Vector3(SmoothedPosition.x, 0.75f, -8);
        }
        else if (LookPos.x > 2.2f)
        {
            Vector3 RightPosition = new Vector3(2.2f, 0.75f, -8);
            Vector3 SmoothedPosition = Vector3.Lerp(transform.position, RightPosition, 20 * Time.deltaTime);
            transform.position = RightPosition;
        }
        else if (LookPos.x < -2.2f)
        {
            Vector3 LeftPosition = new Vector3(-2.2f, 0.75f, -8);
            Vector3 SmoothedPosition = Vector3.Lerp(transform.position, LeftPosition, 20 * Time.deltaTime);
            transform.position = LeftPosition;
        }
        #endregion

        #region Shooting
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Bullet, transform);
        }
        #endregion
    }
}
