using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private DoorType keyType;

    public DoorType getKey()
    {
        UIManager.I.ShowKeyPickupMessage(keyType);
        return keyType;
    }
}
