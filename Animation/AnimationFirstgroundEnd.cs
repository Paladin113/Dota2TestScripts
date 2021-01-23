using UnityEngine;
using UnityEngine.UI;

public class AnimationFirstgroundEnd : MonoBehaviour
{
    private int time;
    [SerializeField] Button buttonBackMainMenu = null;
    [SerializeField] Text textButtonBackMainMenu = null;
    [SerializeField] Button buttonRestartClassic = null;
    [SerializeField] Text textButtonRestartClassic = null;
    [SerializeField] Button buttonDetails = null;
    [SerializeField] Text buttonDetailsText = null;
    [SerializeField] GameObject particlePortal1 = null;
    [SerializeField] GameObject particlePortal2 = null;
    [SerializeField] GameObject portalEffect = null;
    [SerializeField] Image imageButtonDetails = null;
    [SerializeField] private Game game = null;
    [SerializeField] private Text endTestTextMmr = null;

    private void Start()
    {
        
        if (game.mMRPlayer != "9800")
        {
            endTestTextMmr.text = $"Твой MMR {game.mMRPlayer}";
        }
        else
        {
            endTestTextMmr.text = $"Твой MMR 10000";
        }
    }

    private void FixedUpdate()
    {
        time++;
        if (time * 0.02 > 0.5 && time * 0.02 < 3.5)
        {
            gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x - 7.5f, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
        }
        else if (time * 0.02 > 3.5 && time * 0.02 < 5.5)
        {
            particlePortal1.gameObject.transform.localPosition = new Vector3(particlePortal1.gameObject.transform.localPosition.x + 2.5f, particlePortal1.gameObject.transform.localPosition.y + 3f, particlePortal1.gameObject.transform.localPosition.z);
            particlePortal2.gameObject.transform.localPosition = new Vector3(particlePortal2.gameObject.transform.localPosition.x + 2.5f, particlePortal2.gameObject.transform.localPosition.y + 3f, particlePortal2.gameObject.transform.localPosition.z);
            portalEffect.SetActive(true);
        }
        else if (time * 0.02 > 5.5 && time * 0.02 < 5.6)
        {
            buttonBackMainMenu.gameObject.SetActive(true);
            buttonRestartClassic.gameObject.SetActive(true);
            buttonDetails.gameObject.SetActive(true);
            endTestTextMmr.gameObject.SetActive(true);
        }
        else if (time * 0.02 > 5.5 && buttonDetailsText.GetComponent<Text>().color.a <= 1)
        {
            if (endTestTextMmr.GetComponent<Text>().rectTransform.localScale.x <= 1)
            {
                endTestTextMmr.GetComponent<Text>().rectTransform.localScale = new Vector3(endTestTextMmr.GetComponent<Text>().rectTransform.localScale.x + 0.06f, endTestTextMmr.GetComponent<Text>().rectTransform.localScale.y + 0.06f, endTestTextMmr.GetComponent<Text>().rectTransform.localScale.z + 0.06f);
            }
            buttonBackMainMenu.image.color = new Color(buttonBackMainMenu.GetComponent<Image>().color.r, buttonBackMainMenu.GetComponent<Image>().color.g, buttonBackMainMenu.GetComponent<Image>().color.b, buttonBackMainMenu.GetComponent<Image>().color.a + 0.01f);
            buttonRestartClassic.image.color = new Color(buttonBackMainMenu.GetComponent<Image>().color.r, buttonBackMainMenu.GetComponent<Image>().color.g, buttonBackMainMenu.GetComponent<Image>().color.b, buttonBackMainMenu.GetComponent<Image>().color.a + 0.01f);
            buttonDetails.image.color = new Color(buttonDetails.GetComponent<Image>().color.r, buttonDetails.GetComponent<Image>().color.g, buttonDetails.GetComponent<Image>().color.b, buttonDetails.GetComponent<Image>().color.a + 0.01f);
            imageButtonDetails.color = new Color(imageButtonDetails.GetComponent<Image>().color.r, imageButtonDetails.GetComponent<Image>().color.g, imageButtonDetails.GetComponent<Image>().color.b, imageButtonDetails.GetComponent<Image>().color.a + 0.01f);
            textButtonBackMainMenu.color = new Color(textButtonBackMainMenu.GetComponent<Text>().color.r, textButtonBackMainMenu.GetComponent<Text>().color.g, textButtonBackMainMenu.GetComponent<Text>().color.b, textButtonBackMainMenu.GetComponent<Text>().color.a + 0.01f);
            buttonDetailsText.color = new Color(buttonDetailsText.GetComponent<Text>().color.r, buttonDetailsText.GetComponent<Text>().color.g, buttonDetailsText.GetComponent<Text>().color.b, buttonDetailsText.GetComponent<Text>().color.a + 0.01f);
            textButtonRestartClassic.color = new Color(buttonDetailsText.GetComponent<Text>().color.r, buttonDetailsText.GetComponent<Text>().color.g, buttonDetailsText.GetComponent<Text>().color.b, buttonDetailsText.GetComponent<Text>().color.a + 0.01f);
        }
    }
}
