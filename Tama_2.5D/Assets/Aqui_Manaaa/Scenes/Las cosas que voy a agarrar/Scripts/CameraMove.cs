using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform whosJugador;
    public float offset;
    public Vector2 maxLim;
    public Vector2 minLim;

    // Update is called once per frame
    void Update()
    {
        float targetX = whosJugador.position.x + offset;
        float targetY = whosJugador.position.y + offset;

        if (targetX < minLim.x)
        {
            targetX = minLim.x;
        }
        else if (targetX > maxLim.x)
        {
            targetX = maxLim.x;
        }
        if (targetY < minLim.y)
        {
            targetY = minLim.x;
        }
        else if (targetY > maxLim.y)
        {
            targetY = maxLim.x;
        }
        transform.position = new Vector3(whosJugador.position.x + offset, whosJugador.position.y + offset, transform.position.z);
    }
}
