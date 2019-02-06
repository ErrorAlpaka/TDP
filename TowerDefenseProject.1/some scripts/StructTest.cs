using UnityEngine;

//public struct StructTest
{ 
    //public void SayHello()
    { 
        //Debug.Log("Hello From Struct Test!");
    }
}
public struct StructTest
{
       private float _test;

    public float _test
    {
        get (return _test;)
    }

    public StructTest(float test)
    {
        _test = test
    }

    public void SayHello()
    {
        Debug.Log("Hello from Struct Test!, test is " + _test);
    }