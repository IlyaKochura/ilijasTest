using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;
using Random = System.Random;

namespace Mainscripts
{
    public class ControllerCube : MonoBehaviour
    {
        [Header("Назначалки")] [SerializeField]
        private GameObject cubePrefab;

        [SerializeField] private ButtonScript menuButton;
        [SerializeField] private TextMeshProUGUI score;
        [SerializeField] private ButtonScript restartButton;

        [Header("Скорость пуль")] [SerializeField]
        private int lowSpeedBorder;

        [SerializeField] private int highSpeedBorder;
        private int _score = 0;
        private Vector3 _spawnpoint;
        private List<GameObject> _objects = new();



        void Start()
        {
            menuButton.Action = () => GoToMenu();
            restartButton.Action = () => RestartGame();

            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                float random = rnd.Next(-25, 25);
                _spawnpoint = new Vector3(random / 10, 6);
                var slot = Instantiate(cubePrefab, _spawnpoint, Quaternion.identity);
                _objects.Add(slot);
                float randomSpeed = rnd.Next(lowSpeedBorder, highSpeedBorder);
                _objects[i].GetComponent<CubeScript>().speed = randomSpeed;
            }
        }

        void Update()
        {
            for (int i = 0; i < _objects.Count; i++)
            {
                Random rnd = new Random();
                float random = rnd.Next(-25, 25);
                if (_objects[i].transform.position.y < -6)
                {
                    float randomSpeed = rnd.Next(lowSpeedBorder, highSpeedBorder);
                    _objects[i].transform.position = new Vector3(random / 10, 6);
                    _objects[i].GetComponent<CubeScript>().speed = randomSpeed;
                    _score++;
                }
            }

            score.text = Convert.ToString(_score);
        }

        private void GoToMenu()
        {
            SceneManager.LoadScene(0);
        }

        private void RestartGame()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(1);
        }


    }
}