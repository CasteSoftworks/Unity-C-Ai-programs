using UnityEngine;
using System.Collections;

public class ai1 : MonoBehaviour {

    public Transform ia2;
    public float distanzaia1;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {

        agent = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {

        float distanza = Vector3.Distance(transform.position, ia2.transform.position);
        if(distanza <= distanzaia1)
        {
            transform.LookAt(ia2);
            agent.SetDestination(ia2.position);

        }

	}
}
