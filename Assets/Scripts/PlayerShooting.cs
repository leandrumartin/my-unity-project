using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject shootPoint;
    public int bulletsAmount;
    public ParticleSystem muzzleEffect;
    public AudioSource shootSound;
    private Animator animator;
    private float lastShootTime;
    public float fireRate;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && bulletsAmount > 0 && Time.timeScale > 0)
        {
            animator.SetBool("Shooting", true);

            var timeSinceLastShoot = Time.time - lastShootTime;
            if (timeSinceLastShoot < fireRate)
                return;

            lastShootTime = Time.time;

            bulletsAmount--;
            muzzleEffect.Play();
            shootSound.Play();

            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
        }
        else
        {
            animator.SetBool("Shooting", false);
        }
    }
}
