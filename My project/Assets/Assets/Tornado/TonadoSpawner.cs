using UnityEngine;

public class TonadoSpawner : MonoBehaviour
{
    public GameObject tornadoBit;
    public int height = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            for (int x = 0; x < height; x++)
            {
                Instantiate(tornadoBit, new Vector3(0,x, 0), Quaternion.identity);
            }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
