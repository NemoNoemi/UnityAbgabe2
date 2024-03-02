using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{

    public GameObject winTextObject;

    public int NumberOfCoins { get; private set;}
    public UnityEvent<PlayerInventory> OnCoinsCollected;
    
    public void Start(){winTextObject.SetActive(false);}

    public void CoinCollected()
    { 
        NumberOfCoins++;
        OnCoinsCollected.Invoke(this);
        
        if (NumberOfCoins >= 5)
       {
           winTextObject.SetActive(true);
       }
    }
}
