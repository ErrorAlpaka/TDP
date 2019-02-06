using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _health;
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }
}