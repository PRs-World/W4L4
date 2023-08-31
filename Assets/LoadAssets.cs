using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class NewBehaviourScript : MonoBehaviour
public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;

    [SerializeField] private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redObj, new Vector3(2f, 0f, 0f), Quaternion.identity);
        Instantiate(blueObj, new Vector3(-2f, 0f, 0f), Quaternion.identity);

        // Make the game run as fast as possible
        Application.targetFrameRate = -1;
        // Limit the framerate to 60
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
