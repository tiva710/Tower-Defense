using System;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than 1 Build Manager in Scene");
            return; 
        }
        
        instance = this; 
    }

    public GameObject standardTurretPrefab;

    private void Start()
    {
        turretToBuild = standardTurretPrefab; 
    }

    private GameObject turretToBuild;
    

    public GameObject getTurretToBuild()
    {
        return turretToBuild; 
    }
}
