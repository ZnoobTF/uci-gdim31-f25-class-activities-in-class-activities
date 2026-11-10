using System;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed=5f;
    private Boolean _inRange=false;
    [SerializeField] private Transform cat;

    private void Update()
    {
        if (_inRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, cat.position, _speed * Time.deltaTime);
        }
    }
    public void StartChase() {
        _inRange = true;
    }

    public void StopChase()
    {
        _inRange = false;
    }

}
