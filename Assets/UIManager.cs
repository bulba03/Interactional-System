using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject lockedText;
    [SerializeField] private TextMeshProUGUI keyText;
    [SerializeField] private TextMeshProUGUI unlockText;
    public static UIManager I;
    
    private void Awake()
    {
        I = this;
    }

    public void ShowLockedMessage()
    {
        StopCoroutine(LockedMessageRoutine());
        StartCoroutine(LockedMessageRoutine());
    }

    public void ShowUnlockedMessage()
    {
        StopCoroutine(UnLockedMessageRoutine());
        StartCoroutine(UnLockedMessageRoutine());
    }

    public void ShowKeyPickupMessage(DoorType keytype)
    {
        StopCoroutine(PickedupMessageRoutine());
        keyText.text = $"You picked up {keytype.ToString()} key";
        StartCoroutine(PickedupMessageRoutine());
    }

    IEnumerator LockedMessageRoutine()
    {
        lockedText.SetActive(true);
        yield return new WaitForSeconds(1f);
        lockedText.SetActive(false);
    }
    IEnumerator UnLockedMessageRoutine()
    {
        unlockText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        unlockText.gameObject.SetActive(false);
    }

    IEnumerator PickedupMessageRoutine()
    {
        keyText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        keyText.gameObject.SetActive(false);
    }
}
