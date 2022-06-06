﻿using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private float width; // 배경의 가로 길이

    private void Awake() // Start보다 실행시점이 한 프레임 빠름
    {
        // 가로 길이를 측정하는 처리
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }

    private void Update()
    {
        // 현재 위치가 원점에서 왼쪽으로 width 이상 이동했을때 위치를 리셋
        if(transform.position.x <= -width)
        {
            Reposition();
        }
    }

    // 위치를 리셋하는 메서드, 현재위치에서 얼마나 밀어낼까
    private void Reposition()
    {
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;

    }
}