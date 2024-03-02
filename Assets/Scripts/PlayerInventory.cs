using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCoins { get; private set;}
    public UnityEvent<PlayerInventory> OnCoinsCollected;

    public void CoinCollected()
    { 
        NumberOfCoins++;
        OnCoinsCollected.Invoke(this);
    }

}
