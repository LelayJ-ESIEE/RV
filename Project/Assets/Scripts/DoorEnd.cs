using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnd : MonoBehaviour
{
    [SerializeField] Counter counter;
    [SerializeField] List<GameObject> indicators;
    [SerializeField] Material inactiveMaterial;
    [SerializeField] Material activeMaterial;

    public void refresh()
    {
        int i = 0;
        foreach(GameObject indicator in indicators)
        {
            Light l = indicator.GetComponentInChildren<Light>();
            if(i < counter.count)
            {
                indicator.GetComponent<MeshRenderer>().material = activeMaterial;
                l.intensity = 0.5f;
            } else
            {
                indicator.GetComponent<MeshRenderer>().material = inactiveMaterial;
                l.intensity = 0f;
            }
            i++;
        }

        if(counter.count == 4)
        {
            this.open();
        }
    }

    public void open()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
