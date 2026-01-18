using UnityEngine;

public class TutorialScreen : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0f; // կանգնեցնում է խաղը
    }

    public void CloseTutorial()
    {
        Time.timeScale = 1f; // նորից շարժում է խաղը
        gameObject.SetActive(false); // թաքցնում է tutorial-ը
    }
}
