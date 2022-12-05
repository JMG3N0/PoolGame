using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   
    [SerializeField] HitWhiteBall whiteBall = default;
    


    [SerializeField] List<PhysicBody> balls = new List<PhysicBody>();

    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    

    

   

    

    private bool AllBallsAreStoped()
    {
        for (int i = 0; i < balls.Count; i++)
        {
            if(balls[i].GetAcceleration() > 0.1f)
            {
                return false;
            }
        }

        return true;
    }
    
   
}


