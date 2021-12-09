using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarNombres : MonoBehaviour
{
    public GameObject texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Muestra()
    {
        texto.gameObject.SetActive(true);
    }
}
