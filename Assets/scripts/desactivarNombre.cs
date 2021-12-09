using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivarNombre : MonoBehaviour
{
    public GameObject texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Desactiva()
    {

        texto.gameObject.SetActive(false);
    }
}
