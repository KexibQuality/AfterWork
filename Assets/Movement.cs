using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeReference] GameObject go;
    [SerializeField] float speed;
    [SerializeField] float health;
    [SerializeField] Color c;
    [SerializeField] 
    void Awake()
    {
        Instantiate<GameObject>(go);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
