using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeetProjectile : MonoBehaviour
{
    public float speed;
    public float destroyDelay;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyDelay);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
