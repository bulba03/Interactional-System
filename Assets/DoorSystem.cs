using DG.Tweening;
using UnityEngine;

public enum DoorState
{
    Opened,
    Closed,
    Locked
}

public enum DoorType
{
    Red,
    Blue,
    Green
}

public class DoorSystem : MonoBehaviour
{
    [SerializeField] private DoorType doorType;

    [SerializeField] private DoorState doorState = DoorState.Locked;

    [SerializeField] private Transform door;

    private void OpenTheDoor()
    {
        door.DORotate(Vector3.up * -90, 0.2f);
        ChangeState(DoorState.Opened);
    }

    private void ChangeState(DoorState state)
    {
        doorState = state;
    }

    private void CloseTheDoor()
    {
        door.DORotate(Vector3.zero, 0.2f);
        ChangeState(DoorState.Closed);
    }

    private void LockTheDoor()
    {
        ChangeState(DoorState.Locked);
    }

    private void UnLockTheDoor()
    {
        UIManager.I.ShowUnlockedMessage();
        ChangeState(DoorState.Closed);
    }

    private void ShowLockedMessage()
    {
        UIManager.I.ShowLockedMessage();
    }

    public void Interact()
    {
        switch (doorState)
            {
                case DoorState.Closed:
                    OpenTheDoor();
                    break;
                case DoorState.Opened:
                    CloseTheDoor();
                    break;
                case DoorState.Locked:
                    ShowLockedMessage();
                    break;
            }
    }
    public void Open(KeysHolder keysHolder)
    {
        switch (doorState)
                {
                    case DoorState.Closed:
                        LockTheDoor();
                        break;
                    
                    case DoorState.Locked:
                        if (keysHolder.isHaveKey(doorType))
                        {
                            UnLockTheDoor();
                        } 
                        break;
                }
    }
}
