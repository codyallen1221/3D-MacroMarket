using UnityEngine;

public class SpinCube : MonoBehaviour
{
    public Vector3 RotateAmount;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code (if needed)
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount);
    }
}
