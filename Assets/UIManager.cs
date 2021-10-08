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
    [SerializeField] private TextMeshProUGUI cantFindKeyText;
    [SerializeField] private TextMeshProUGUI lockText;
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

    public void CantFindRightKeyMessage()
    {
        StopCoroutine(CantFindRightKeyRoutine());
        StartCoroutine(CantFindRightKeyRoutine());
    }
    
    public void ShowKeyPickupMessage(DoorType keytype)
    {
        StopCoroutine(PickedupMessageRoutine());
        keyText.text = $"You picked up {keytype.ToString()} key";
        StartCoroutine(PickedupMessageRoutine());
    }

    public void ShowLockMessage()
    {
        StopCoroutine(LockTheDoorRoutine());
        StartCoroutine(LockTheDoorRoutine());
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

    IEnumerator CantFindRightKeyRoutine()
    {
        cantFindKeyText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        cantFindKeyText.gameObject.SetActive(false);
    }

    IEnumerator LockTheDoorRoutine()
    {
        lockText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        lockText.gameObject.SetActive(false);
    }
}
