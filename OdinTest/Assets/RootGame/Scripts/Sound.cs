using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Sound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [Button]
    public void AndyTheme()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Test");
    }

}
