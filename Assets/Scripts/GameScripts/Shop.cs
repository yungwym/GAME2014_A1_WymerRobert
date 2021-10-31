using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    private float money = 500;

    private float singleMissileCost = 50;
    private float doubleMissileCost = 120;
    private float greenCannonCost = 300;
    private float redCannonCost = 500;

    private TileManager tileManager;


    [SerializeField] GameObject singleMissilePrefab;
    [SerializeField] GameObject doubleMissilePrefab;
    [SerializeField] GameObject greenCannonPrefab;
    [SerializeField] GameObject redCannonPrefab;

    // Start is called before the first frame update
    void Start()
    {
        tileManager = TileManager.tileManagerInstance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney(int amount)
    {

    }

    public void SubtractMoney(int amount)
    {

    }


    public void SingleMissileDefenceSelected()
    {
        tileManager.ShowActiveTiles();


        tileManager.SetSelectedDefence(singleMissilePrefab);
    }

    public void DoubleMissileDefenceSelected()
    {
        tileManager.ShowActiveTiles();

        tileManager.SetSelectedDefence(doubleMissilePrefab);
    }

    public void GreenCannonDefenceSelected()
    {
        tileManager.ShowActiveTiles();

        tileManager.SetSelectedDefence(greenCannonPrefab);
    }

    public void RedCannonDefenceSelected()
    {
        tileManager.ShowActiveTiles();

        tileManager.SetSelectedDefence(redCannonPrefab);
    }

}
