using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partycle : MonoBehaviour, IPartycle
{
    private IDataPartycle dataPartycle;
    private float timeLifeNow = 0;
    private bool isActive = false;

    public event Action<IPartycle> eventActive;
    public event Action<IPartycle> eventFinishMove;

    public bool IsActive
    {
        get
        {
            return isActive;
        }
        set
        {
            isActive = value;
            if (isActive) SetActive();
            else SetInactive();
        }
    }

    public GameObject GameObject => gameObject;

    public void Initialize(IDataPartycle dataPartycle)
    {
        this.dataPartycle = dataPartycle;
        var mesh = GetComponent<MeshRenderer>();
        mesh.material = dataPartycle.Material;
    }

    private void Update()
    {
        TimeNow();
        Move();
    }

    private void Move()
    {
        if(IsActive)
        {
            transform.position += transform.forward * dataPartycle.Speed * Time.deltaTime;
        }
    }

    public void SetActive()
    {
        timeLifeNow = 0;
        gameObject.SetActive(true);
        eventActive?.Invoke(this);
    }

    public void SetInactive()
    {
        gameObject.SetActive(false);        
    }

    public void TimeNow()
    {
        timeLifeNow += Time.deltaTime;
        if(timeLifeNow > dataPartycle.TimeLife)
        {
            timeLifeNow = 0;
            eventFinishMove?.Invoke(this);            
        }
    }
}
