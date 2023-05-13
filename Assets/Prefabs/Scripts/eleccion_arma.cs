using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eleccion_arma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Transform escopetaTransform = transform.GetChild(0);
            Transform pistolaTransform = transform.GetChild(3);

            if (escopetaTransform != null && pistolaTransform != null)
            {
                GameObject escopetaObject = escopetaTransform.gameObject;
                GameObject pistolaObject = pistolaTransform.gameObject;
                // Se encontr? un hijo con el tag "Escopeta"
                escopetaObject.SetActive(false);
                pistolaObject.SetActive(true);
            }
            else
            {
                // No se encontr? ning?n hijo con el tag "Escopeta"
                Debug.Log("No se encontr? ning?n hijo con el tag 'Escopeta'");
            }
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Transform escopetaTransform = transform.GetChild(0);
            Transform pistolaTransform = transform.GetChild(3);

            if (escopetaTransform != null && pistolaTransform != null)
            {
                GameObject escopetaObject = escopetaTransform.gameObject;
                GameObject pistolaObject = pistolaTransform.gameObject;
                // Se encontr? un hijo con el tag "Escopeta"
                escopetaObject.SetActive(true);
                pistolaObject.SetActive(false);
            }
            else
            {
                // No se encontr? ning?n hijo con el tag "Escopeta"
                Debug.Log("No se encontr? ning?n hijo con el tag 'Escopeta'");
            }
        }
    }
}
