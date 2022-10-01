using UnityEngine;
/// <summary>
/// Item slot class.
/// Store reference to the object inside slot.
/// </summary>
public class UIDropSlot : MonoBehaviour
{
    // Reference to the item inside slot.
    public UIDragItem currentItem;
    // Tells if slot is filled by other item.
    public bool SlotFilled => currentItem;
}