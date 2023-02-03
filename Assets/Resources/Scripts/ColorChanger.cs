using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Camera cam;
    void Start()
    {
        cam.backgroundColor = Color.blue;
    }

    public void _ChangeColorToGreen()
    {
        cam.backgroundColor = Color.green;
    }

    public void _ChangeColorToBlue()
    {
        cam.backgroundColor = Color.blue;
    }
}
