using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ilumisoft.Minesweeper.UI
{
    [RequireComponent(typeof(Button))]
    public class RetryButton : MonoBehaviour
    {
        SceneLoader sceneLoader;

        Button button;

        private void Awake()
        {
            sceneLoader = FindObjectOfType<SceneLoader>();

            button = GetComponent<Button>();
            button.onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            if (sceneLoader != null)
            {
                SoundManager.instance.PlaySE(0);
                sceneLoader.LoadScene(gameObject.scene.name);
            }
            else
            {
                SoundManager.instance.PlaySE(0);
                SceneManager.LoadScene(gameObject.scene.name);
            }
        }
    }
}