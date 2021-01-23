using UnityEngine;
using UnityEngine.UI;

public class ToggleSelect : MonoBehaviour
{
    private Vector3 vec;
    [SerializeField] private Toggle toggleAnswer1 = null;
    [SerializeField] private Toggle toggleAnswer2 = null;
    [SerializeField] private Toggle toggleAnswer3 = null;
    [SerializeField] private Toggle toggleAnswer4 = null;
    [SerializeField] private AudioClip audioNextQuestion = null;
    [SerializeField] private Game game = null;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            vec = Camera.main.ScreenPointToRay(Input.mousePosition).origin;
            Collider2D[] coliders = Physics2D.OverlapCircleAll(new Vector2(vec.x, vec.y), 0.01f);
            foreach (Collider2D cd in coliders)
            {
                if (cd.gameObject.layer == 5)
                {
                    toggleAnswer1.isOn = false;
                    toggleAnswer2.isOn = false;
                    toggleAnswer3.isOn = false;
                    toggleAnswer4.isOn = false;
                    cd.GetComponent<Toggle>().isOn = true;
                    game.AudioManager(audioNextQuestion);
                }
            }
        }
    }
}
