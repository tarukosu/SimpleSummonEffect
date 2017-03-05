using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartEffect();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void StartEffect()
    {
        foreach (Transform child in transform)
        {
            var particle = child.gameObject.GetComponent<ParticleSystem>();
            if (particle)
            {
                particle.Play();
            }
        }
    }
}
