using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Komsu : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI text;
    float hiz = 2;
    private Rigidbody2D rb2;
    private Text metin;
    void Start()
    {

    }

    void Update()
    {
        Vector3 movement = Vector3.left * hiz * Time.deltaTime;
        transform.Translate(movement);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            sayac.timer -= 5f;
        }
    }
}
