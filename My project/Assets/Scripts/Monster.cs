

using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) 
        {
           transform.Translate(Vector3.forward * 5 *Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider vlas)
    {
        if (vlas.CompareTag("Player"))
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
