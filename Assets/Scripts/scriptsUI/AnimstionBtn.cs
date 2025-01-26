using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AnimstionBtn : MonoBehaviour
{

    [SerializeField] float fast;
    [SerializeField] Vector2 pointB;
    [SerializeField] Vector2 pointA;
    [SerializeField] UnityEngine.UI.Button btn;
    [SerializeField] public GameObject objet;
    // Start is called before the first frame update
    void Start()
    {
        objet.SetActive(false);
        Positions();
        btn.onClick.AddListener(VisbleObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (objet == true)
        {
            MovObject();
        }
    }
    void VisbleObject()

    {
        objet.SetActive(true);

    }
    void MovObject()

    {

        transform.position = Vector2.MoveTowards(objet.transform.position, pointB, fast * Time.deltaTime);

    }
    void Positions()
    {
        transform.position = new Vector2(pointA.x, pointA.y);
    }
}
