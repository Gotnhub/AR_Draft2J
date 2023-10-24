using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARCollectItem : MonoBehaviour
{

    public bool hasCollected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collect()
    {
        this.hasCollected = true;
        GetComponent<Animator>().SetTrigger("Highlight");
        GetComponent<Button>().enabled = false;
    }

}
