using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    public Sprite floor_0;
    public Sprite floor_1;
    public SpriteRenderer SR;

    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }


    public void Start_josuck()
    {
        SR.sprite = floor_1;
    }

    public void End_josuck()
    {
        SR.sprite = floor_0;
    }

    
}
