using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySasha : MonoBehaviour
{
    public TMPro.TextMeshProUGUI PointsText;
    private int points = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sasha"))
        {
            PointsText.text = $"{++points}";
            collision.gameObject.SetActive(false);
        }
    }
}
