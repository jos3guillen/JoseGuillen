using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruirfueralimite : MonoBehaviour
{
    private float bottomLimit = -70;
  

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
            Debug.Log("Perdiste");
        }
    }
}
