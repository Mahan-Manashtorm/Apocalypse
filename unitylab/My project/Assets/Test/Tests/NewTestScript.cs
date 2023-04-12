using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    [UnityTest]
    public IEnumerator MoveTest()
    {
        PassengerCar passengerCar = new GameObject().AddComponent<PassengerCar>();
        passengerCar.Move();
        Assert.AreEqual(new Vector3(-0.01f, 0f, 0f), passengerCar.transform.position);
        yield return null;
    }
}

