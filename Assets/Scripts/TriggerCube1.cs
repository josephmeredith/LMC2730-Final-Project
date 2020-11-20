using UnityEngine;
using System.Collections;

public class TriggerCube : MonoBehaviour {

    public bool onSwitch;
    public bool lightStatus;
    public GameObject AmbientBuzzingNoise;
    public GameObject ScaryNoise;
    public GameObject CreepyRedLight;
    public GameObject NormalRoomLight;
   

  void Start()
	{
	CreepyRedLight.SetActive(false);
	NormalRoomLight.SetActive(true);
    NatureNoise.SetActive(true);
	ScaryNoise.SetActive(false);
	}
        
  void OnTriggerEnter(Collider other)
    {
        onSwitch = true;
    }

  void OnTriggerExit(Collider other)
    {
        onSwitch = false;
    }

    void Update()
    {
        if(CreepyRedLight.activeSelf == true)
        {
            lightStatus = true;
        }
        else
        {
            lightStatus = false;
        }

        if (onSwitch == true)
        {
            if (lightStatus){
				CreepyRedLight.SetActive(true);
				NormalRoomLight.SetActive(false);
                AmbientBuzzingNoise.SetActive(false);
				ScaryNoise.SetActive(true);
            } else
			{
   				CreepyRedLight.SetActive(true);
				NormalRoomLight.SetActive(false);
                AmbientBuzzingNoise.SetActive(false);
				ScaryNoise.SetActive(true);
    		}
        }
    }
}