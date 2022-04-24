using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject shootPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && CheckCooldown())
        {
            GameObject bullet = Instantiate(bulletPrefab, shootPoint.transform.position, shootPoint.transform.rotation);
        }
    }

    public float lastShootTime = -99f;
    public float shootCD = 1f;
    bool CheckCooldown()
    {
        if (lastShootTime + shootCD  <= Time.time)
        {
            lastShootTime = Time.time;
            return true;
        }

        return false;
    }
}
