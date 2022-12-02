using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{

    public TMPro.TextMeshProUGUI Text;


    // Update is called once per frame
    void Update()
    {
        Text.text = Time.time.ToString("F1");
    }
}
