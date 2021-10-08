using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysHolder : MonoBehaviour
{
    [SerializeField] private List<DoorType> keys = new List<DoorType>();
    public bool isHaveKey(DoorType keyType)
    {
        //checking if we have the right key
        foreach (var key in keys)
        {
            if (key == keyType)
            {
                return true;
            }
        }
        return false;
    }

    public void AddKey(DoorType keyType)
    {
        //checking if we have the same key in list
        foreach (var key in keys)
        {
            if (key == keyType)
            {
                return;
            }
        }
        keys.Add(keyType);
    }
}
