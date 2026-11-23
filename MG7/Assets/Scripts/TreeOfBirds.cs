using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] _birds;
    [SerializeField] private Transform _player;
    [SerializeField] private float _interactDistance = 5.0f;

    private void Update()
    {
        for (int i = 0; i < _birds.Length; i++)
        {
            float distance = Vector3.Distance(_birds[i].transform.position, _player.position);
            if (distance < _interactDistance)
            {
                _birds[i].SetActive(true);
            }
        }
    }
}