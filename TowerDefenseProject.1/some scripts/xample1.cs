using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xample1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //v erzeugt neue Struct / Class
    ClassTest _classTest = new ClassTest();
    Color _color = new Color(1f, 0f, 0f);
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //gameObject.AddComponent<MonoTest>(),
            //ClassTest classTest = new ClassTest();
            //classTest.SayHello();

            StructTest _structTest = new StructTest();
            // Hier wird die Methode "SayHello" auf der Instanz aufgerufen
            _classTest.SayHello();
            _structTest.SayHello();

            // Vector3 ist ein Positions / Movementgeber. wird hier erstellt
            Vector3 _pos = new Vector3(0f, 1f, 0f);

            // wendet Transformation von Vector3 an
            transform.position += _pos;
            //gleicher befehl v wie ^ 
            //transform.position = transform.position + offset
        }
    }
}
