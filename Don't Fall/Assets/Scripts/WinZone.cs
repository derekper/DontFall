using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("ThirdPersonController").SendMessage("Finish");
        //SceneManager.LoadScene("Menus");
        
    }

}
