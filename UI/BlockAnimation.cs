using UnityEngine;

public class BlockAnimation : MonoBehaviour
{
    private int time = 0;
    private int rnd1 = 0;
    private int rnd2 = 0;
    private readonly GameObject[] blocks = new GameObject[4];
    private float rotate1 = 0;
    private float rotate3 = 0;
    public bool active = false;

    private void Start()
    {
        rnd1 = Random.Range(0, 4);
        if (rnd1 == 0)
        {
            rotate1 = 1;
        }
        else if (rnd1 == 1)
        {
            rotate1 = 1.5f;
        }
        else if (rnd1 == 2)
        {
            rotate1 = -1;
        }
        else if (rnd1 == 3)
        {
            rotate1 = -1.5f;
        }
        rnd2 = Random.Range(0, 4);
        if (rnd2 == 0)
        {
            rotate3 = 1;
        }
        else if (rnd2 == 1)
        {
            rotate3 = 1.5f;
        }
        else if (rnd2 == 2)
        {
            rotate3 = -1;
        }
        else if (rnd2 == 3)
        {
            rotate3 = -1.5f;
        }
        Collider2D coliders = Physics2D.OverlapCircle(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.32f, gameObject.transform.position.z), 0.2f);
        if (coliders != null)
        {
            if (coliders.gameObject.layer == 8 && coliders.gameObject != null)
            {
                blocks[0] = coliders.gameObject;
            }
        }
        coliders = Physics2D.OverlapCircle(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1.32f, gameObject.transform.position.z), 0.2f);
        if (coliders != null)
        {
            if (coliders.gameObject.layer == 8 && coliders.gameObject != null)
            {
                blocks[1] = coliders.gameObject;
            }
        }
        coliders = Physics2D.OverlapCircle(new Vector3(gameObject.transform.position.x - 1.22f, gameObject.transform.position.y, gameObject.transform.position.z), 0.2f);
        if (coliders != null)
        {
            if (coliders.gameObject.layer == 8 && coliders.gameObject != null)
            {
                blocks[2] = coliders.gameObject;
            }
        }
        coliders = Physics2D.OverlapCircle(new Vector3(gameObject.transform.position.x + 1.22f, gameObject.transform.position.y, gameObject.transform.position.z), 0.2f);
        if (coliders != null)
        {
            if (coliders.gameObject.layer == 8 && coliders.gameObject != null)
            {
                blocks[3] = coliders.gameObject;
            }
        }
    }

    private void FixedUpdate()
    {
        if (active)
        {
            time++;
            gameObject.transform.Rotate(new Vector3(rotate1, 0, rotate3));
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x - 0.03f, gameObject.transform.localScale.y - 0.03f, gameObject.transform.localScale.z - 0.03f);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(gameObject.GetComponent<SpriteRenderer>().color.r, gameObject.GetComponent<SpriteRenderer>().color.g, gameObject.GetComponent<SpriteRenderer>().color.b, gameObject.GetComponent<SpriteRenderer>().color.a - 0.02f);
            if (time * 0.02 > 0.3)
            {
                if (blocks[0] != null) blocks[0].GetComponent<BlockAnimation>().active = true;
                if (blocks[1] != null) blocks[1].GetComponent<BlockAnimation>().active = true;
                if (blocks[2] != null) blocks[2].GetComponent<BlockAnimation>().active = true;
                if (blocks[3] != null) blocks[3].GetComponent<BlockAnimation>().active = true;
            }
            if (time * 0.02 % 60 > 2)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
