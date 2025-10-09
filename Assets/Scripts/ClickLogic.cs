using Unity.Mathematics;
using UnityEngine;

public class ClickLogic : MonoBehaviour
{
    //serialized game controller's script for time and clicked time's logic.
    [SerializeField]
    GameObject gameController;

    //serialized golem's script for animation.
    [SerializeField]
    GameObject golem;

    //boolean stablishing playtime state.
    public bool isTimeActive = false;

    //interger for the countdown of available time to click.
    [Range(0, 10)]
    public float smashingTime = 10f;

    //interger for times clicked.
    public int smashedTimes = 0;


    //-----------------------------------------------------------------------------------------------------------------------


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        smashedTimes = 0;
        smashingTime = 10f;
        isTimeActive = true;        
    }

    // Update is called once per frame
    void Update()
    {   


        if (isTimeActive == true)
        {
            //countdown from 10 to 0 clamped, avg run time = 10seconds.
            smashingTime = Mathf.Clamp(smashingTime, 0, 10f);
            smashingTime = smashingTime - 1 * (Time.deltaTime % 60);
            //Debug.Log(smashingTime);


            //-----------------------------------------------------------------------------------------------------------------------

            //counter of times clicked with space.
            if (Input.GetKeyDown("space"))
            {
                smashedTimes = smashedTimes + 1;
                Debug.Log(smashedTimes);
            }
        }
       
    }
}
