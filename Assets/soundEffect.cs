using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public AudioSource Pop;
	public AudioSource GravityChange;
	public AudioSource Escape;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayPop(){
    	Pop.Play();
    }

    public void PlayGravity(){
    	GravityChange.Play();
    }

    public void PlayEscape(){
    	Escape.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
