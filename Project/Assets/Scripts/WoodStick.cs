using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodStick : MonoBehaviour
{
    [SerializeField]
    GameObject Firezone;

    bool inFire;
    // Start is called before the first frame update
    void Start()
    {
        inFire = true;
        extinguishFire();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void lightFire()
    {
        if (!inFire)
        {
            inFire = true;
            Firezone.SetActive(true);
            Debug.Log(inFire);
        }
      
    }
    private void extinguishFire()
    {
        if (inFire)
        {
            inFire = false;
            Firezone.SetActive(false);
            Debug.Log(inFire);
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col);
        if (col.gameObject.tag == "TorchWithoutFire")
        {
            Debug.Log("TorchWithoutFire");
            lightFire();
        }
    }
}
