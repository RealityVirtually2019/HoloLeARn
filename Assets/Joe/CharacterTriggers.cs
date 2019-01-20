using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTriggers : MonoBehaviour {

    Animator anim;
    AudioSource audioSource;
    public AudioClip greetings, letsGo, stage1_1, stage1_2, stage2_1, stage2_2, stage2_3, positive, negative, noSpeech;

    // Use this for initialization
    void Awake () {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        greetings   = Resources.Load<AudioClip>("Audio/1Greetings");
        letsGo      = Resources.Load<AudioClip>("Audio/2LetsGo");
        stage1_1    = Resources.Load<AudioClip>("Audio/3Stage1_1");
        stage1_2    = Resources.Load<AudioClip>("Audio/4Stage1_2");
        stage2_1    = Resources.Load<AudioClip>("Audio/5Stage2_1");
        stage2_2    = Resources.Load<AudioClip>("Audio/6Stage2_2");
        stage2_3    = Resources.Load<AudioClip>("Audio/7Stage2_3");
        positive    = Resources.Load<AudioClip>("Audio/8Positive");
        negative    = Resources.Load<AudioClip>("Audio/9Negative");
        noSpeech    = Resources.Load<AudioClip>("Audio/10NoSpeech");

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Backflip();
        }
    }

    public void PlayClipCall(string name)
    {
        StartCoroutine(PlayClip(name));
    }
    IEnumerator PlayClip(string name)
    {
        audioSource.clip = Resources.Load(name) as AudioClip;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
    }

    public void Backflip()
    {
        anim.SetTrigger("backflip");
    }
    public void CartWheel()
    {
        anim.SetTrigger("cartwheel");
    }
    public void Charge()
    {
        anim.SetTrigger("charge");
    }
    public void Defeat()
    {
        anim.SetTrigger("defeat");
    }
    public void Frontflip()
    {
        anim.SetTrigger("frontflip");
    }
    public void HandsForwardGesture()
    {
        anim.SetTrigger("handsForwardGesture");
    }
    public void HappyIdle()
    {
        anim.SetTrigger("happyIdle");
    }
    public void HeadNodYes()
    {
        anim.SetTrigger("headNodYes");
    }
    public void MacarenaDance()
    {
        anim.SetTrigger("macarenaDance");
    }
    public void ThoughtfulHeadShake()
    {
        anim.SetTrigger("thoughtfulHeadShake");
    }
    public void VictoryIdle()
    {
        anim.SetTrigger("victoryIdle");
    }
    public void Wave()
    {
        anim.SetTrigger("wave");
    }
    public void Yelling()
    {
        anim.SetTrigger("yelling");
    }
}
