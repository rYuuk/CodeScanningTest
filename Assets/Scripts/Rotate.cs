using UnityEngine;

public class Rotate : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(0f, 20f, 0f) * Time.deltaTime);
    }
}
