﻿// Simple Sprite Animation Plugin by Elendow
// http://elendow.com
// https://github.com/Elendow/Unity-Simple-Sprite-Animation-Plugin
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteAnimator : BaseAnimator
{
    private SpriteRenderer spriteRenderer;

    protected override void Awake()
    {
        base.Awake();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected override void ChangeFrame(Sprite frame)
    {
        spriteRenderer.sprite = frame;
    }
}