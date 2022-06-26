using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mainscripts
{
    public class ControllerMenu : MonoBehaviour
    {
        [SerializeField] private ButtonScript exitButton;
        [SerializeField] private ButtonScript playButton;

        void Start()
        {
            playButton.Action = () => GoPlay();
            exitButton.Action = () => ExitGame();
        }

        private void GoPlay()
        {
            SceneManager.LoadScene(1);
        }

        private void ExitGame()
        {
            Application.Quit();
        }
    }
}