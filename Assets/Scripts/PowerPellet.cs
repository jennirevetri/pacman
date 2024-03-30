using UnityEngine;

public class PowerPellet : Pellet
{
    public float duration = 8f;

    protected override void Eat()
    {
        GameManager.Instance.PowerPelletEaten(this);
    }

    protected override void Eat2()
    {
        GameManager.Instance.PowerPelletEaten2(this);
    }

}
