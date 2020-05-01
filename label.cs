using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class label : MonoBehaviour
{
    
    GameObject target, cameraPosition;
    public GameObject labelObject;


    void Start(){ target = GameObject.Find("finder"); }

    void Update() // Label Look At Camera 
    {    
        // Quaternion.LookRotation(target.transform.position - transform.position);

        // Vector3 targetPosition = new Vector3 (
        //     target.transform.position.x,
        //     transform.position.y,
        //     target.transform.position.z
        //     );


        transform.LookAt(target.transform);
        
    }

    public void ExitApp(){  Application.Quit();  }
    public void ResetApp(){ SceneManager.LoadScene("main"); }
    public void lableToggle()
    {
        if ( !labelObject.activeInHierarchy ) { labelObject.SetActive(true); }
        else { labelObject.SetActive(false); }

    }

}
