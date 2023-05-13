using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHeal : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            col.GetComponent<Tank_Health>().AddHeal(healthValue);
            gameObject.SetActive(false);
        }
    }
}
