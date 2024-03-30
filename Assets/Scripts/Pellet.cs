using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Pellet : MonoBehaviour
{
    public int points = 10;

    protected virtual void Eat()
    {
        GameManager.Instance.PelletEaten(this);
    }

    protected virtual void Eat2()
    {
        GameManager.Instance.PelletEaten2(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            Eat();
        }

        if (other.gameObject.layer == LayerMask.NameToLayer("PacmanTwo"))
        {
            Eat2();
        }
    }

}
