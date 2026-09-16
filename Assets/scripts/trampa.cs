using UnityEngine;
using UnityEngine.UIElements;
public class trampa : MonoBehaviour



{
    [SerializeField] private float spped;

    [SerializeField] private GameObject targed;
    private void Update()
    {

        //transform.Translate(Vector3.right * spped * Time.deltaTime);
        
        transform.Rotate(-Vector3.forward * spped * Time.deltaTime);
    }
}