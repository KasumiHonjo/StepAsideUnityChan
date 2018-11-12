using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

    public GameObject carPrefab;

    public GameObject coinPrefab;

    public GameObject conePrefab;

    private GameObject Uni;
    
    private int starPos = -160;

    private int goalPos = 120;

    private float posRange = 3.4f;

    private float lastUnipost;
    
	// Use this for initialization
	void Start () {

        this.Uni = GameObject.Find("unitychan");

        lastUnipost = Uni.transform.position.z;
        

        /*for (int i = starPos; i < goalPos; i += 15){

            int num = Random.Range(1,11);
            
            if(num <= 2)
            {
                for(float j = -1; j <=1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }else
            {
                for (int j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);

                    int offsetZ = Random.Range(-5, 6);
                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }*/
    }
	
	// Update is called once per frame
	void Update () {
        
        if(Uni.transform.position.z >lastUnipost+15 && Uni.transform.position.z<=80)
        {
           

            int num = Random.Range(1, 11);

            if (num <= 2)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, lastUnipost+50);
                }
            }
            else
            {
                for (int j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);

                    int offsetZ = Random.Range(-5, 6);
                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, lastUnipost + offsetZ+50);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, lastUnipost + offsetZ+50);
                    }
                }
            }
            lastUnipost = Uni.transform.position.z;
        }
	}
    
}
