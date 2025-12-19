using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrashCounter : BaseCounter {


    public static event EventHandler OnAnyOjbectTrashed;

    public override void Interact(Player player) {
        if (player.HasKitchenObject()) {
            player.GetKitchenObject().DestroySelf();

            OnAnyOjbectTrashed?.Invoke(this, EventArgs.Empty);
        }
    }
}
