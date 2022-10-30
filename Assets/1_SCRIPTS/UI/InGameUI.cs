using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SafeZone;
using TMPro;
public class InGameUI : UIPanels
{
    [SerializeField] private TMP_Text hourText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHour(string hour)
    {
        hourText.text = hour;
    }
}
