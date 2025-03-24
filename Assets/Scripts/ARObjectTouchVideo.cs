using UnityEngine;
using UnityEngine.Video;

public class ARObjectTouchVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (touch.phase == TouchPhase.Began && Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    if (videoPlayer != null)
                    {
                        videoPlayer.Play();
                    }
                }
            }
        }
    }
}
