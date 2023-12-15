using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   [SerializeField] MeshRenderer meshRenderer;

   void Start()
   {
    meshRenderer = GetComponent<MeshRenderer>();
   }

   public void ChangeColor() 
   {
    meshRenderer.material.color = Random.ColorHSV();
   }
}
