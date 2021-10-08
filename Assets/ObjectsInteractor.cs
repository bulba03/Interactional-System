using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsInteractor : MonoBehaviour
{
    [SerializeField] private Camera cam;

    [SerializeField] private KeysHolder keysHolder;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 4))
            {
                if (hit.collider.TryGetComponent(out DoorSystem doorSystem))
                {
                    doorSystem.Open(keysHolder);
                }
                else
                {
                    if (hit.collider.TryGetComponent(out Key key))
                    {
                        keysHolder.AddKey(key.getKey());
                    }
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 4))
            {
                if (hit.collider.TryGetComponent(out DoorSystem doorSystem))
                {
                    doorSystem.Interact();
                }
            }
        }
    }
}
