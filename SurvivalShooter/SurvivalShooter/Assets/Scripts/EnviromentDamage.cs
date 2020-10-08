using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentDamage : MonoBehaviour
{
    ParticleSystem hitParticles;
    BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        hitParticles = GetComponentInChildren<ParticleSystem>();
        boxCollider = GetComponent<BoxCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageWall(Vector3 hitPoint)
    {
        hitParticles.transform.position = hitPoint;
        hitParticles.Play();
    }
}
