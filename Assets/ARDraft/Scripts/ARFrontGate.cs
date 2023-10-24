using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class ARFrontGate : MonoBehaviour
{

    public GameObject panelVideo;
    public GameObject buttonVideo;
    Vector3 originalPositionVideo;

    public bool isPlayingVideo = false;

    // Start is called before the first frame update
    void Start()
    {
        originalPositionVideo = panelVideo.transform.position;
        panelVideo.SetActive(false);
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
        panelVideo.transform.DOMove(originalPositionVideo, 0.5f);
        panelVideo.transform.DOScale(1, 0.5f);
    }

    public void CloseVideo()
    {
        isPlayingVideo = false;
        //panelVideo.transform.DOScale(1, 0);

        //Callback
        panelVideo.transform.DOScale(0, 0.5f).OnComplete(
            () => {
            panelVideo.SetActive(false);
            }
        );
        panelVideo.transform.DOMove(buttonVideo.transform.position, 0.5f);
    }
    


}
