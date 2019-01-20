using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTriggers : MonoBehaviour {

    Animator anim;
    AudioSource audioSource;
    AudioClip greetings, letsGo, stage1_1, stage1_2, stage2_1, stage2_2, stage2_3, positive, negative, noSpeech;

    // Use this for initialization
    void Start () {
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
	void Update () {

    }

    IEnumerator PlayClip(AudioClip audio)
    {
        audioSource.clip = audio;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
    }

    void Backflip()
    {
        anim.SetTrigger("backflip");
    }
    void CartWheel()
    {
        anim.SetTrigger("cartwheel");
    }
    void Charge()
    {
        anim.SetTrigger("charge");
    }
    void Defeat()
    {
        anim.SetTrigger("defeat");
    }
    void Frontflip()
    {
        anim.SetTrigger("frontflip");
    }
    void HandsForwardGesture()
    {
        anim.SetTrigger("handsForwardGesture");
    }
    void HappyIdle()
    {
        anim.SetTrigger("happyIdle");
    }
    void HeadNodYes()
    {
        anim.SetTrigger("headNodYes");
    }
    void MacarenaDance()
    {
        anim.SetTrigger("macarenaDance");
    }
    void ThoughtfulHeadShake()
    {
        anim.SetTrigger("thoughtfulHeadShake");
    }
    void VictoryIdle()
    {
        anim.SetTrigger("victoryIdle");
    }
    void Wave()
    {
        anim.SetTrigger("wave");
    }
    void Yelling()
    {
        anim.SetTrigger("yelling");
    }
}
