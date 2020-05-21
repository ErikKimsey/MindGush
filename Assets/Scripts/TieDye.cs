using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class TieDye : MonoBehaviour
{

    Color green;
    Color pink;
     Renderer m_Renderer;
    public Material _pink;
    public Material _green;
    public GameObject sphere;
    public float xStart;
      GameObject[] nuSpheres = new GameObject[1000];

    void Start()
    {
      green = new Color(255,188,255,1);
      pink = new Color(255,0,225,1);
      CreateSpheres();
    }

    private void CreateSpheres(){
      for (int i = 0; i < nuSpheres.Length; i++)
      {
         GameObject nusphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
         nusphere.transform.position = new Vector3(xStart, i, -1 );
         nusphere.gameObject.GetComponent<MeshRenderer>().material = _pink;
         nusphere.AddComponent<Rigidbody>();
         nusphere.AddComponent<SphereCollider>();
         nuSpheres[i] = nusphere;
         
      }
    }

    private void OnCollisionEnter(Collision collision) {
      // sphere.gameObject.GetComponent<Renderer>().material = _green;
      foreach (GameObject item in nuSpheres){
        item.GetComponent<Renderer>().material = _green;
      }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
