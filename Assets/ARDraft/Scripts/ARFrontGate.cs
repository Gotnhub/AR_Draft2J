using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class ARFrontGate : MonoBehaviour
{

    public GameObject panelVideo;
    public GameObject buttonVideo;

    public bool isPlayingVideo = false;

    // Start is called before the first frame update
    void Start()
    {
        CloseVideo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SwitchVideo()
    {
        if(isPlayingVideo)
        {
            CloseVideo();
        }
        else
        {
            OpenVideo();
        }
    }


    public void OpenVideo()
    {
        isPlayingVideo = true;
        panelVideo.SetActive(true);

        //Init
        panelVideo.transform.DOScale(0, 0);
        panelVideo.transform.position = buttonVideo.transform.position;

        //Animation
        panelVideo.transform.DOLocalMove(new Vector3(350, 160, 0), 1);
        panelVideo.transform.DOScale(1, 1);
    }

    public void CloseVideo()
    {
        isPlayingVideo = false;
        //panelVideo.transform.DOScale(1, 0);

        //Callback
        panelVideo.transform.DOScale(0, 1).OnComplete(
            () => {
            panelVideo.SetActive(false);
            }
        );
        panelVideo.transform.DOMove(buttonVideo.transform.position, 1);
    }
    


}
