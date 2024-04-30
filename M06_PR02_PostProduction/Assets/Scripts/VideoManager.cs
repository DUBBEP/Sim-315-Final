using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;


public class VideoManager : MonoBehaviour
{
    public UnityEvent OnVideoEnd;

    private VideoPlayer _videoPlayer;

    private void Awake()
    {
        _videoPlayer = gameObject.GetComponent<VideoPlayer>();
    }

    private void Start()
    {
        if (OnVideoEnd == null)
            OnVideoEnd = new();

        if (_videoPlayer != null)
            _videoPlayer.loopPointReached += DetectVideoEnd;
    }

    private void DetectVideoEnd(VideoPlayer vp)
    {
        OnVideoEnd.Invoke();
    }
}
