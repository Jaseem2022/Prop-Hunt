using UnityEngine;
using System.Collections.Generic;

public class PropLogic : MonoBehaviour
{
    [SerializeField] GameObject[] AllPrefabs;
    [SerializeField] float CLONE_DESTRUCT_TIMER = 3.5f;

    Transform Model; //Player->Model->Current Prop Prefab
    Transform CurrentProp;
    
    private List<Collider> PlayerColliders = new List<Collider>();
    int StartIndex = 0;

    private void PrintAllPlayerProps()
    {
        for(int i=0;i<AllPrefabs.Length;i++)
        {
            Debug.Log($"name : {AllPrefabs[i]}");
        }

    }

    private void MakeClone()
    {
        Vector3 SpawnPosition = CurrentProp.transform.position;
        GameObject Clone = Instantiate(AllPrefabs[StartIndex],SpawnPosition,Quaternion.identity);
        Destroy(Clone,CLONE_DESTRUCT_TIMER);
    }

    private void ChangeProp()
    {  
        Destroy(CurrentProp.gameObject);
        StartIndex = (StartIndex + 1) % AllPrefabs.Length;
        GameObject newProp = Instantiate(AllPrefabs[StartIndex], Model);

        // Update the reference for transform
        CurrentProp = newProp.transform;
    
    }

    private void Awake()
    {    
        Model = transform.Find("Model");
        CurrentProp = Model.GetChild(0);
    }

    private void Start() 
    {
        PrintAllPlayerProps();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            ChangeProp();

        if(Input.GetKeyDown(KeyCode.LeftControl))
            MakeClone();
    }
}
