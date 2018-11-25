using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class menuHoverSound : MonoBehaviour, IPointerEnterHandler {

    public AudioSource sounds;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse is over text");
        sounds.Play(0);
    }
}
