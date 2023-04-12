using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreightCar : TrainCar
{
    public override void Move()
    {
        transform.position += new Vector3(-0.01f, 0f, 0f);
        if (_nextCar != null)
        {
            _nextCar.Move();
        }
    }
}
