using Unity.VisualScripting;
using UnityEngine;

public class Golem : MonoBehaviour
{
    ClickLogic clickLogic;
    [SerializeField] GameObject gameController;

    //animation controller
    Animator bonkAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        clickLogic = gameController.GetComponent<ClickLogic>();
    }
    void Start()
    {
        Debug.Log("Golem Golem Golem");
        Debug.Log(clickLogic.smashedTimes);

        bonkAnimator = GetComponent<Animator>();
        bonkAnimator.SetBool("bonk", true);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
