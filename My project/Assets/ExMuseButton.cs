using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExMuseButton : MonoBehaviour
{
    public int Hp = 100;
    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        textUI.text = ("ü�� : " +  Hp).ToString();

        Debug.Log("ü�� : " + Hp);
        if (Input.GetMouseButtonDown(0))
        {
            Hp -= 10;
            Debug.Log("ü�� : " + Hp);
            if( Hp <= 0 )
            {
                textUI.text = ("ü�� : " + Hp).ToString();
                Destroy(gameObject);
            }
        }
        
    }
}
