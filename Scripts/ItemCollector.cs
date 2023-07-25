using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int count = 0;
    [SerializeField] Text coinsText;

    [SerializeField] AudioSource collectionSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            count++;
            collectionSound.Play();
            coinsText.text = "Coins:" + count;
        }
    }
}
