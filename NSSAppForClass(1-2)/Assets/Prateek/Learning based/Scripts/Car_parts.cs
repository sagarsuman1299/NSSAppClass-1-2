using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_parts : MonoBehaviour
{
    public GameObject car;
    public GameObject bike;
    public GameObject cycle;

    public GameObject car_light;
    public GameObject[] car_wheels;
    public GameObject[] doors;
    public GameObject[] windows;

    public GameObject bike_light;
    public GameObject[] bike_wheels;
    public GameObject bike_seat;
    public GameObject bike_engine;
    public GameObject bike_tank;
    public GameObject bike_handle;
    public GameObject bike_silencer;

    public GameObject[] cycle_wheel;
    public GameObject cycle_seat;
    public GameObject cycle_handle;
    public GameObject cycle_padle;

    ///// Car
    
    public void Car_headlight()
    {
        car_light.SetActive(true);

        StartCoroutine(Wait_time());
    }

    public void Car_wheels()
    {
        car_wheels[0].SetActive(true);
        car_wheels[1].SetActive(true);

        StartCoroutine(Wait_time());
    }
    public void Car_doors()
    {
        doors[0].SetActive(true);
        doors[1].SetActive(true);

        StartCoroutine(Wait_time());
    }

    public void Car_windows()
    {
        windows[0].SetActive(true);
        windows[1].SetActive(true);

        StartCoroutine(Wait_time());
    }

    ///// Bike

    public void Bike_headlight()
    {
        bike_light.SetActive(true);

        StartCoroutine(Wait_time());
    }

    public void Bike_wheels()
    {
        bike_wheels[0].SetActive(true);
        bike_wheels[1].SetActive(true);

        StartCoroutine(Wait_time());
    }
    public void Bike_seat()
    {
        bike_seat.SetActive(true);

        StartCoroutine(Wait_time());
    }

    public void Bike_engine()
    {
        bike_engine.SetActive(true);

        StartCoroutine(Wait_time());
    }
    public void Bike_tank()
    {
        bike_tank.SetActive(true);

        StartCoroutine(Wait_time());
    }

    public void Bike_handle()
    {
        bike_handle.SetActive(true);

        StartCoroutine(Wait_time());
    }
    public void Bike_silencer()
    {
        bike_silencer.SetActive(true);

        StartCoroutine(Wait_time());
    }

    ///// Cycle

    public void Cycle_wheels()
    {
        cycle_wheel[0].SetActive(true);
        cycle_wheel[1].SetActive(true);

        StartCoroutine(Wait_time());
    }
    public void Cycle_seat()
    {
        cycle_seat.SetActive(true);

        StartCoroutine(Wait_time());
    }
    public void Cycle_handle()
    {
        cycle_handle.SetActive(true);

        StartCoroutine(Wait_time());
    }
    public void Cycle_pedal()
    {
        cycle_padle.SetActive(true);

        StartCoroutine(Wait_time());
    }

    IEnumerator Wait_time()
    {
        Debug.Log("Change2");

        yield return new WaitForSeconds(2);

        for (int i = 0; i < car.transform.childCount; i++)
        {
            var child = car.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }

        for (int i = 0; i < bike.transform.childCount; i++)
        {
            var child = bike.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }

        for (int i = 0; i < cycle.transform.childCount; i++)
        {
            var child = cycle.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
    }
}
