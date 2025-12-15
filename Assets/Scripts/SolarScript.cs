using UnityEngine;

public class SolarScript : MonoBehaviour
{
    public GameObject PlanetsObjects;
    public Vector3 RotationVector;

    private void Update()
    {
        PlanetsObjects.transform.Rotate(RotationVector * Time.deltaTime);
    }
}
