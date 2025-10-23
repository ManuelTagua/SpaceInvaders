using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erupcion : MonoBehaviour
{
    public GameObject stone;
    public GameObject capsule;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ThrowStone());
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(stone, transform.position, Random.rotation);
        }*/

        /*new WaitForSeconds(2.0f);
        while (true)
        {
            Instantiate(stone, transform.position, Random.rotation);
            new WaitForSeconds(fireRate);
        }*/
    }

    IEnumerator ThrowStone()
    {
        int rand = 0;
        yield return new WaitForSeconds(2.0f);
        while (true)
        {
            rand = Random.Range(0, 2);
            if (rand == 0)
            {
                Instantiate(stone, transform.position, Random.rotation);
            }
            else
            {
                Instantiate(capsule, transform.position, Random.rotation);
            }

            yield return new WaitForSeconds(fireRate);
        }
    }

}
