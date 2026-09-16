using UnityEngine;
using UnityEngine.UIElements;

public class Monemed : MonoBehaviour
{
    [SerializeField] private float spped;

    [SerializeField] private GameObject targed;
    private void Update()
    {

        //transform.Translate(Vector3.right * spped * Time.deltaTime);
        // transform.position = Vector3.MoveTowards(transform.position, targed.transform.position, spped * Time.deltaTime);
        transform.Rotate(Vector3.forward * spped * Time.deltaTime);

        // transform.Rotate(Quaternion.RotateTowards(transform.rotation, targed.transform.rotation, spped * Time.deltaTime);

    }




}
