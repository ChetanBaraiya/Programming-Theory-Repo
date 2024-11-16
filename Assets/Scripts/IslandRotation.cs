using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandRotation : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void LateUpdate()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}