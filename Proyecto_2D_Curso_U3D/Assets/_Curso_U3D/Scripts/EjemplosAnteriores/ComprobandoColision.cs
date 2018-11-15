using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobandoColision : MonoBehaviour {    
    public static int maxCubes;

    private void OnCollisionEnter(Collision collision)
    {
        if (maxCubes > 100)
            return;
        GameObject gObj = collision.gameObject;
        Debug.Log("Colision: " + gObj.name);
        if (this.gameObject.name.Contains("Plane") && gObj.name.Contains("Cube"))
        {
            GameObject go = Instantiate<GameObject>(gObj);
            go.transform.position = new Vector3(
                go.transform.position.x - Random.Range(2, 4),
                go.transform.position.y + Random.Range(10, 20),
                go.transform.position.z + Random.Range(2, 3));
            gObj.transform.position = new Vector3(
                gObj.transform.position.x + Random.Range(2, 3),
                gObj.transform.position.y + Random.Range(6, 12),
                gObj.transform.position.z - Random.Range(2, 3));

            Destroy(go, 5);
        }
    }

}
