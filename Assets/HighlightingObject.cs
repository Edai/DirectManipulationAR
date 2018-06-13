using Leap.Unity.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightingObject : MonoBehaviour {

    Dictionary<Renderer, Color> mapColor = new Dictionary<Renderer, Color>();
    InteractionBehaviour behaviour;


    private void Start()
    {
        behaviour = GetComponent<InteractionBehaviour>();
       
        var colorsComponents = GetComponentsInChildren<Renderer>(true);
      
        foreach (var component in colorsComponents)
            mapColor.Add(component, component.material.color);
    }

    private void Update()
    {
        if ((behaviour.isGrasped || behaviour.isHovered))
        {
            foreach (var c in mapColor)
            {
                Color lighter_color = new Color();
                lighter_color.r = c.Value.r + c.Value.r * 0.95f;
                lighter_color.g = c.Value.g + c.Value.g * 0.95f;
                lighter_color.b = c.Value.b + c.Value.b * 0.95f;
                lighter_color.a = c.Value.a;
                c.Key.material.color = lighter_color;
            }
        }
        else
        {
            foreach (var c in mapColor)
                c.Key.material.color = c.Value;
        }
    }
}
