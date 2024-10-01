using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriContoller : MonoBehaviour
{
    // Start is called before the first frame update
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    // Update is called once per frame
    void Start()
    {
        Application.targetFrameRate = 60;
        Shoot(new Vector3(0, 200, 2000));
    }
}
