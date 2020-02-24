﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_1 : MonoBehaviour
{
    [SerializeField] AudioSource Sound_1;
    [SerializeField] AudioSource Sound_2;
    [SerializeField] AudioSource Sound_3;

    [SerializeField] GameObject btn_1;
    [SerializeField] GameObject btn_2;
    [SerializeField] GameObject btn_3;

    [SerializeField] GameObject btn_stop;

    [SerializeField] GameObject Spot_light;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Btn1()
    {
        sound_effect.Play();

        Sound_1.volume = 1.0f;
        Sound_2.volume = 0.0f;
        Sound_3.volume = 0.0f;

        btn_1.SetActive(false);
        btn_2.SetActive(true);
        btn_3.SetActive(true);

        btn_stop.SetActive(true);

        Spot_light.SetActive(true);
    }
}
