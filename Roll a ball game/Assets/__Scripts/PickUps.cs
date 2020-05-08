using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUps : MonoBehaviour
{
    //declaring the prefabs and private variables 
    public GameObject cubePrefabVar;
    private GameObject _cube;

    public GameObject cube1PrefabVar;
    private GameObject _cube1;

    public GameObject cylinderPrefabVar;
    private GameObject _cylinder;
  
    void Start()
    {
        //method to create the GameObjects dynamically 
        for (int i = -4; i <= -1; i++)
        {
           Vector3 ImagePosition  = new Vector3(0,0,-2);
            //creates an instance of the cube prefab called cube 
            _cube = Instantiate(cubePrefabVar);
            //positioning the cube within the game
            _cube.transform.position = _cube.transform.position + i*ImagePosition;
        }

        for (int i = -4; i <= 0; i++)
        {
            Vector3 ImagePosition = new Vector3(-2, 0, -2);
            _cube = Instantiate(cubePrefabVar);
            _cube.transform.position = _cube.transform.position + i * ImagePosition;
        }

        for (int i = 1; i <= 6; i++)
        {
            Vector3 ImagePosition = new Vector3(-1, 0, 0);
            _cube1 = Instantiate(cube1PrefabVar);
            _cube1.transform.position = _cube1.transform.position + i * ImagePosition;
        }

        for (int i = 1; i <= 3; i++)
        {
            Vector3 ImagePosition = new Vector3(-2, 0, -2);
            _cylinder = Instantiate(cylinderPrefabVar);
            _cylinder.transform.position = _cylinder.transform.position + i*ImagePosition;
        }


    }


}
