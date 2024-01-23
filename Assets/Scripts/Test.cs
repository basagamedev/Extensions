using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] private GameObject prefab = null;
    [SerializeField] private SpriteRenderer spriteRenderer = null;
    [SerializeField] private UnityEngine.UI.Graphic[] graphics = null;

    private GameObject cube = null;
    private Rigidbody rb = null;
    private Rigidbody2D rb2D = null;
    private string stringTest = "abc";
    private List<string> list = new List<string>()
    {
        "First",
        "Second",
        "Third"
    };
    void Start()
    {
         cube = Instantiate(prefab, transform.position.With(x: 1), Quaternion.identity);
        // cube = Instantiate(prefab, transform.position.With(y: 1), Quaternion.identity);
        // cube = Instantiate(prefab, transform.position.With(z: 1), Quaternion.identity);
        // cube = Instantiate(prefab, transform.position.With(x: 1, y: 1, z: 1), Quaternion.identity);
        // cube = Instantiate(prefab, transform.position.With(x: 1, y: 1, z: 1).Add(x: 1), Quaternion.identity);
        // cube = Instantiate(prefab, transform.position.With(x: 1, y: 1, z: 1).Add(x: 1, y: 1, z: 1), Quaternion.identity);
        // cube.transform.SetPosition(x: 1);    
        // cube.transform.SetPosition(y: 1);    
        // cube.transform.SetPosition(z: 1);    
        // cube.transform.SetPosition(x: 1, y: 1, z: 1);
        // spriteRenderer.SetAlpha(0.5f);
        // cube.transform.LocalReset();
        // cube.transform.GlobalReset();
        // cube.transform.SetPosition(x: 3, y: 3, z: 3);
        // cube.transform.SetLocalPosition(x: 3, y: 3, z: 3);
        // rb2D = spriteRenderer.GetComponent<Rigidbody2D>();
        // rb2D.Freeze();
        // rb = cube.GetComponent<Rigidbody>();
        // rb.Freeze();
        // Debug.Log(stringTest.IsNullOrEmpty());
        // for (int i = 0; i < graphics.Length; i++)
        // graphics[i].SetAlpha(0.5f);
        // Debug.Log(list.Rand());
    }
}
