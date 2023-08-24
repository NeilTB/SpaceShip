
using UnityEngine;

public class PlayerPickup : PlayerAbstract
{
    public virtual void ItemPickup(ItemPickupable itemPickupable)
    {
        Debug.Log("ItemPickup");

        ItemCode itemCode = itemPickupable.GetItemCode();
        if (this.playerCtrl.ShipCtrl.Inventory.AddItem(itemCode, 1))
        {
            itemPickupable.Picked();
        }
    }
}

