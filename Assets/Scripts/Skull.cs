using UnityEngine;

public class Skull : MonoBehaviour
{
    void OnTriggerEnter(Collider goalTrigger)
    {
        if (gameObject.tag == "Mace")
        {
            Debug.Log("Skulltrigger");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Skullini");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
