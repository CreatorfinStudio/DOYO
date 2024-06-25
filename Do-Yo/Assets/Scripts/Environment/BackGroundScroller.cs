using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float tileSizeY;

    private Vector3 startPosition;

    public bool isHaveGround = false;
    void Start()
    {
        startPosition = transform.position;

        GameManager.Instance.startScroll += ScrollBackGround;      
    }

    private void ScrollBackGround()
    {
        StartCoroutine(CorScrollBackGround());
    }
    IEnumerator CorScrollBackGround()
    {
        while (true) // 무한 루프를 사용하여 계속해서 스크롤
        {
            if (isHaveGround && this.transform.position.y < -5)
            {
                if (transform.childCount > 0)
                {
                    this.transform.GetChild(0).gameObject.SetActive(false);
                }
                isHaveGround = false;
            }

            float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeY);
            transform.position = startPosition + Vector3.down * newPosition;

            yield return null; 
        }
    }

}
