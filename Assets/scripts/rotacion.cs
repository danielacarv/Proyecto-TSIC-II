using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{
    public float velocidad = 4.0f;
    public float velRotacion = 80.0f;

    public float x, y;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidad);

    }
}
