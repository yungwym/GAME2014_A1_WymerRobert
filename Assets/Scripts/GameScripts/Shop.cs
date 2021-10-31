using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] GameObject singleMissilePrefab;
    [SerializeField] GameObject doubleMissilePrefab;
    [SerializeField] GameObject greenCannonPrefab;
    [SerializeField] GameObject redCannonPrefab;

    private float money = 200;

    private float singleMissileCost = 50;
    private float doubleMissileCost = 120;
    private float greenCannonCost = 300;
    private float redCannonCost = 500;

    private TileManager tileManager;

    // Start is called before the first frame update
    void Start()
    {
        tileManager = TileManager.tileManagerInstance;
    }

    public void AddMoney(float amount)
    {
        money += amount;
    }

    public void SubtractMoney(float amount)
    {
        money -= amount;
    }

    public float GetMoneyAmount()
    {
        return money;
    }


    public void SingleMissileDefenceSelected()
    {
        tileManager.ShowActiveTiles();

        if (CanBuy(singleMissileCost))
        {
            SubtractMoney(singleMissileCost);
            tileManager.SetSelectedDefence(singleMissilePrefab);
        }
    }

    public void DoubleMissileDefenceSelected()
    {
        tileManager.ShowActiveTiles();

        if (CanBuy(doubleMissileCost))
        {
            SubtractMoney(doubleMissileCost);
            tileManager.SetSelectedDefence(doubleMissilePrefab);
        }
    }

    public void GreenCannonDefenceSelected()
    {
        tileManager.ShowActiveTiles();

        if (CanBuy(greenCannonCost))
        {
            SubtractMoney(greenCannonCost);
            tileManager.SetSelectedDefence(greenCannonPrefab);
        }
    }

    public void RedCannonDefenceSelected()
    {
        tileManager.ShowActiveTiles();

        if (CanBuy(redCannonCost))
        {
            SubtractMoney(redCannonCost);
            tileManager.SetSelectedDefence(redCannonPrefab);
        }
    }

    public bool CanBuy(float cost)
    {
        if (money >= cost)
        {
            return true;
        }
        else
        {
            tileManager.SetSelectedDefenceToNull();
            return false;
        }
    }
}
