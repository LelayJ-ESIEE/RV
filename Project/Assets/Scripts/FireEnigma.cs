using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class FireEnigma : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string password;
    private string playerPassword;
    
    void Start()
    {
        EventManager.LightEnigmaFireEvent += ChangePassword;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePassword(string id)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(playerPassword + id);
        if (sb.Length != password.Length)
        {
            playerPassword = sb.ToString();
            return;
        }
        if (sb.ToString() == playerPassword)
        {
            //Event make an orb appear
            return;
        }
        playerPassword = "";
        //Event close all light
        return;

    }

    private void OnDestroy()
    {
        EventManager.LightEnigmaFireEvent -= ChangePassword;
    }

}
