using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{

    public float transformSpeed = 0.5f;

    void Start()
    {

    }

    void Update()
    {
        moveTransformToTop();
    }

    void moveTransformToTop()
    {
        transform.Translate(0, transformSpeed, 0);
    }
}
