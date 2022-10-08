using Mewlist.MassiveClouds;
using UnityEngine;

public class SkyTimer : MonoBehaviour
{

    public AtmosPad atmosPad;
    public float time;
    
    public void Update()
    {
        float deltaTime = Time.deltaTime;
        this.time += deltaTime / 30;

        if (this.atmosPad.Hour > 24)
        {
            this.time = 0;
        }
        
        this.atmosPad.SetHour(this.time);
    }
}
