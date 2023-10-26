using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
    //public GameObject efecto;
    public GameObject winnerPanel;
    public GameObject player;
    

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //Instantiate(efecto, transform.position, Quaternion.identity);
            
            
            Destroy(gameObject);
            Destroy(player);
            winnerPanel.SetActive(true);
            AudioManager.Instance.PlaySFX("Win");

        }
    }
}
