using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    public GameObject cubito;

    public void ClonarCubo()
    {
        int i = 0;
        while (i < 3)
        {
            Instantiate(cubito);
            i++;
        }
    }
}
