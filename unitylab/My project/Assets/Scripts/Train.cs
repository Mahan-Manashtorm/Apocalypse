using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    public TrainCar _engine;
    public bool strt = false;
    public void Start()
    {
        
    }

    public void MoveTrain()
    {
        strt=true;
    }
    public void AddCarriage(TrainCar newCar)
    {
        TrainCar currentCar = _engine;

        
        while (currentCar._nextCar != null)
        {
            currentCar = currentCar._nextCar;
        }
        currentCar.SetNextCar(newCar);
        newCar.transform.position = currentCar.transform.position + new Vector3(4f, 0f, 0f);
    }
    public void Add(TrainCar newCar)
    {
        TrainCar newCarriage = Instantiate(newCar, Vector3.zero, Quaternion.identity);
        AddCarriage(newCarriage);
    }
    public void Update()
    {
        if (strt == true)
        {
            _engine.Move();
        }
    }
}