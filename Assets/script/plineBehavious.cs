using UnityEngine;
using System.Collections;

public class plineBehavious : MonoBehaviour {

    public polyline pline_test; //= new polyline();
                                // Use this for initialization
    void Start()
    {
        pline_test = new polyline();
        int i;
        float r = 10.0f;
        float x = 0.0f, y = 0.0f;
        float stepAng = Mathf.PI / 4.0f;
        for (i = 0; i < 8; i++)
        {
            x = Mathf.Cos(i * stepAng) * r;
            y = Mathf.Sin(i * stepAng) * r;

            pline_test.addPoint(new float[] { x, y })
;
        }

    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        float[] point = new float[2];
        point = pline_test.points[0];
        Vector3 positionFrom = new Vector3(point[0], point[1], 0.0f);
        Vector3 positionTo = Vector3.zero;
        for (int i = 1; i < pline_test.points.Count; i++)
        {
            point = pline_test.points[i];
            positionTo = new Vector3(point[0], point[1], 0.0f);
            //Gizmos.DrawLine(positionFrom, positionTo);
            Gizmos.DrawLine(positionFrom, positionTo);
            positionFrom = positionTo;
        }

    }
}
