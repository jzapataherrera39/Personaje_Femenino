using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeAnimaciones : MonoBehaviour
{
   private Animator _animator;
   private PersonajeMovimiento _personajeMovimiento;
   private void Awake()
   {
    _animator = GetComponent<Animator>();
    _personajeMovimiento = GetComponent<PersonajeMovimiento>();
   }
   
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      
        if(_personajeMovimiento.EnMovimiento == false)
        {
            return;
        }
        _animator.SetFloat(name:"X", _personajeMovimiento.DireccionMovimiento.x);
        _animator.SetFloat(name:"Y", _personajeMovimiento.DireccionMovimiento.y);

    
    }
}
