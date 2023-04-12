using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TrainCar : MonoBehaviour
{
    public TrainCar _nextCar;

    public void SetNextCar(TrainCar car)
    {
        _nextCar = car;
    }

    public abstract void Move();
}

