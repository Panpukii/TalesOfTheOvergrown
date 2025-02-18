using UnityEngine;

public class BillboardSprite : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}
