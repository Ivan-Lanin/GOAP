using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PatientSpawner : MonoBehaviour
{
    [SerializeField] private GameObject patientPrefab;
    private Vector3 spawnPoint;
    private int numberOfPatients = 6;
    private float spawnDelay = 3f;
    private int nOfPatients = 0;


    void Start()
    {
        spawnPoint = GameObject.FindWithTag("Home").transform.position;
        StartCoroutine(SpawnPatients());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnPatients()
    {
        for (int i = 0; i < numberOfPatients; i++)
        {
            Instantiate(patientPrefab, spawnPoint, Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
